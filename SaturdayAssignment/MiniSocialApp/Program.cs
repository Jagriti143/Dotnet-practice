using System;
using System.IO;
using System.Reflection.Metadata;
using System.Text.Json;
using MiniSocialMedia;
class Program{
    private static Repository<User> _users=new Repository<User>();
    private static User? _currentUser=null;
    private static readonly string _dataFile="social-data.json";
    //private static readonly string _logFile = "error.log";
    public static void LoadData()
    {
        try{
            if(!File.Exists(_dataFile)){
                Console.WriteLine("File Not Found");
                return;
            }
            string json = File.ReadAllText(_dataFile);
            if(string.IsNullOrWhiteSpace(json)){
                // Console.WriteLine("No user found");
                return;
            }
            List<UserInfo> list = JsonSerializer.Deserialize<List<UserInfo>>(json);
            if(list == null)
                return;
            foreach(var su in list){
                User u = new User(su.Username, su.Email);
                foreach(var p in su.Posts){
                    u.AddPost(p.Content);
                }
                foreach(var name in su.Following){
                    u.Follow(name);
                }
                _users.Add(u);
            }
            Console.WriteLine("Data loaded.");
        }
        catch(Exception ex){
            LogError.Log(ex.Message);
            Console.WriteLine("Failed to load data.");
        }
    }
    public static void SaveData(){
        var data =_users.GetAll().Select(u => new UserInfo
            {
                Username = u.Username,Email = u.Email,
                Following = _users.GetAll().Where(x => u.IsFollowing(x.Username))
                            .Select(x => x.Username).ToList(),
                Posts = u.GetPosts().Select(p => new PostInfo
                        {
                            Content = p.Content,CreatedAt = p.CreatedAt
                        })
                        .ToList()
            })
            .ToList();
            string json = JsonSerializer.Serialize(data,new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_dataFile, json);
            Console.WriteLine("Data saved.");
    }

    public static void Register()
    {
            try
        {
            Console.Write("Enter username: ");
            string u = Console.ReadLine() ?? "";

            Console.Write("Enter email: ");
            string e = Console.ReadLine();

            if (_users.GetAll().Any(x =>
                x.Username.Equals(u.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("User already exists");
                return;
            }

            User user = new User(u, e);
            _users.Add(user);

            Console.WriteLine("Registration successful");
            _currentUser=user;
            ShowMainMenu();

        }
        catch (SocialException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    public static void Login()
    {
        Console.Write("Enter username: ");
        string u = Console.ReadLine();

        User user = _users.GetAll()
            .FirstOrDefault(x =>
                x.Username.Equals(u.Trim(), StringComparison.OrdinalIgnoreCase));

        if (user == null)
        {
            Console.WriteLine("User not found");
            return;
        }

        _currentUser = user;
        Console.WriteLine($"Logged in as @{_currentUser.Username}");
        ShowMainMenu();
    }
    public static void ShowLoginMenu()
    {
        int choice=-1;
        do
        {
        Console.WriteLine("\n1. Register");
        Console.WriteLine("2. Login");
        Console.WriteLine("0. Exit");
        Console.Write("Choice: ");

        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Register();
                break;
            case 2:
                Login();
                break;
            case 0:
            SaveData();
            Console.WriteLine("Exiting Login Menu");
            Environment.Exit(0);
                break;
                
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        }while(choice!=0);
    }
    private static void ShowMainMenu()
    {
        try
        {
            int option=-1;
            do
            {
                Console.WriteLine("1.Post message");
                Console.WriteLine("2.View my posts");
                Console.WriteLine("3.View timeline(feed)");
                Console.WriteLine("4.Follow user");
                Console.WriteLine("5.List users");
                Console.WriteLine("6.Logout");
                Console.WriteLine("0.Exit and save");
                option=int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    PostMessage();
                    break;
                    case 2:
                    MyPost(_currentUser.GetPosts());
                    break;
                    case 3:
                    ViewTimeLine();
                    break;
                    case 4: 
                    FollowUser();
                    break;
                    case 5:
                    ListUser();
                    break;
                    case 6:
                    _currentUser=null;
                    break;
                    case 0:
                    SaveData();
                    Console.WriteLine("Exiting main menu");
                    Environment.Exit(0);
                    break;
                    default:
                    Console.WriteLine("Invalid choice");
                    break;
                }
            }while(option!=0);
        }catch(SocialException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    public static void PostMessage()
    {
        try
        {
            Console.WriteLine("Write post:");
            string text = Console.ReadLine();
            _currentUser.AddPost(text);
            Console.WriteLine("Post added successfully");
        }
        catch (SocialException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void MyPost(IReadOnlyList<Post> l)
    {
        if (l.Count == 0)
        {
            Console.WriteLine("Not done any post yet");
        }
        if (l.Count > 20)
        {
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(l[i].ToString());
            }
            return;
        }
        for(int i = 0; i < l.Count; i++)
        {
            Console.WriteLine(l[i].ToString());
        }
    }
    public static void ViewTimeLine()
    {
        if (_currentUser== null)
        {
            Console.WriteLine("Timeline is accessible only to authenticated users");
            return;
        }
        List<Post> timeline=new List<Post>();
        timeline.AddRange(_currentUser.GetPosts());
        foreach(User u in _users.GetAll()){
            if(_currentUser.IsFollowing(u.Username)){
                timeline.AddRange(u.GetPosts());
            }
        }
        timeline=timeline.OrderByDescending(x=>x.CreatedAt).ToList();
        Console.WriteLine("=== Your Timeline ===");
        foreach(Post p in timeline){
            Console.WriteLine(p);
        }
    }
    public static void FollowUser()
    {
        if (_currentUser == null)
        {
            Console.WriteLine("Only authenticated users can follow others");
            return;
        }
        Console.WriteLine("Enter username they want to follow: ");
        string u=Console.ReadLine();
        u=u.Trim();
        if(string.IsNullOrWhiteSpace(u))
        {
            Console.WriteLine("Cancelled.");
            return;
        }
        bool flag=false;
        foreach(User i in _users.GetAll())
        {
            if(string.Equals(i.Username, u, StringComparison.OrdinalIgnoreCase))
            {
                flag=true;
                break;
            }
        }
        if (flag == false)
        {
            Console.WriteLine("No user found");
            return;
        }
        _currentUser.Follow(u);
        Console.WriteLine($"Now following @{u}");
    }
    public static void ListUser()
    {
        Console.WriteLine("Registered users:");
        var users = _users.GetAll()
                .OrderBy(u => u.Username);

            foreach (var u in users)
                Console.WriteLine($"{u,-20} {u.Email}");
    }

    static void ConsoleColorWrite(ConsoleColor color, string text)
    {
        var old = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ForegroundColor = old;
    }
    public static class LogError
    {
        public static void Log(string message)
        {
            File.AppendAllText("log.txt",
                DateTime.Now + " : " + message + Environment.NewLine);
        }
    }
    public static void Main(string[] args){

        Console.WriteLine("MiniSocial - Console Edition");
        Console.WriteLine("=== MiniSocial ===");
        LoadData();


        while (true)
        {
            try
            {
                if (_currentUser == null)
                    ShowLoginMenu();
                else
                    ShowMainMenu();
            }
            catch (SocialException ex)
            {
                ConsoleColorWrite(ConsoleColor.Red, $"Error: {ex.Message}");
                if (ex.InnerException != null)
                    Console.WriteLine(ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error!!");
                Console.WriteLine(ex.Message);
                LogError.Log(ex.Message);
            }

        }

        
    }
}
