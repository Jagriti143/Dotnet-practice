using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
namespace MiniSocialMedia
{
    class SocialException:Exception
    {
        public SocialException(string message):base(message){}
        public SocialException(string message,Exception inner):base(message,inner){}

    }
    interface IPostable
    {
        void AddPost(string content);
        IReadOnlyList<Post> GetPosts();
        
    }
    public class Post
    {
        public User Author{get;init;}
        public string Content{get;init;}
        public DateTime CreatedAt{get;}=DateTime.UtcNow;

        public Post(User author,string content)
        {
            if (author == null)
            {
                throw new SocialException("Invalid user name");
            }
            this.Author=author;
            this.Content=content;
        }
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"{Author} . {CreatedAt}");
            sb.AppendLine(Content);
             Regex regex = new Regex(@"#[A-Za-z]+");
            MatchCollection hashtags = regex.Matches(Content);
              if (hashtags.Count > 0)
            {
                sb.Append("Tags: ");
                sb.AppendJoin(", ", hashtags.Cast<Match>().Select(m => m.Value));
            }
            return sb.ToString().TrimEnd();

        }

    }
    public partial class User : IPostable, IComparable<User>
    {
        public string Username{get; init;}
        public string Email{get;init;}
        private List<Post> _posts;
        private readonly HashSet<string> _following;
        public event Action<Post>? OnNewPost;

        public User(string u,string e)
        {
            
            _posts=new List<Post>();
            _following=new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            if (string.IsNullOrWhiteSpace(u)|| u.Length==0)
            {
                throw new SocialException("Invalid username");
            }
            string pattern=@"^\w+@\w+\.\w+$";
            u=u.Trim();
            this.Username=u;
            e=e.Trim();
            e=e.ToLower();
            this.Email=e;
              if (!Regex.IsMatch(e, pattern))
            {
                throw new SocialException("Invalid email format");
            }

        }

        public void Follow(string username)
        {
           
            if(string.Equals(username, this.Username, StringComparison.OrdinalIgnoreCase))
            {
                throw new SocialException("Cannot follow yourself");
            }
            if (!_following.Add(username))
            {
                throw new SocialException("Already following this user");
            }

            _following.Add(username);
        }
        public IReadOnlyCollection<string> GetFollowingNames()
        {
            return _following;
        }




        public bool IsFollowing(string s)
        {

            if (_following.Contains(s))
            {
                return true;
            }
            return false;
        }

        public void AddPost(string c)
        {
            if(string.IsNullOrWhiteSpace(c) || c.Length==0)
            {
                throw new SocialException("Post content cannot be empty");
            }
            if (c.Length > 280)
            {
                throw new SocialException("Post too long (max 280 characters)");
            }
            c=c.Trim();
            Post p=new Post(this,c);
            _posts.Add(p);
            OnNewPost?.Invoke(p);

        }

        public IReadOnlyList<Post> GetPosts()=> _posts.AsReadOnly();
        
        public int CompareTo(User? other)
        {
            if (other == null)
            {
                return 1;
            }

            return string.Compare(this.Username, other.Username, StringComparison.OrdinalIgnoreCase);
           
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append($"@{this.Username}");
            return sb.ToString();
        }

        
        
    }
    public partial class User
        {
            public string GetDisplayName()
        {
            return $"User: {this.Username} <{this.Email}>";
        }
        }
    class Repository<T> where T:class
    {
        private readonly List<T> _items=new List<T>();
        public void Add(T item)=>_items.Add(item);
        public IReadOnlyList<T> GetAll()=>_items.AsReadOnly();
        public T? Find(Predicate<T> match)
        {
            return _items.Find(match);
        }
    }
    public static class SocialUtils
    {
        public static string FormatTimeAgo(this DateTime pastTime)
        {
            DateTime utcTime=DateTime.UtcNow;
            TimeSpan diff=utcTime-pastTime;
            if (diff.TotalSeconds < 60)
            {
                return "just now";
            }else if (diff.TotalMinutes < 60)
            {
                return $"{(int)diff.TotalMinutes} min ago";
            }else if (diff.TotalHours < 24)
            {
                return $"{(int)diff.TotalHours} h ago";
            }
            
            return pastTime.ToString("MMM dd"); //past time ("MMM dd,yyyy);
            
        }
    }
 public class UserInfo
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public List<string>? Following { get; set; }
        public List<PostInfo>? Posts { get; set; }
    }

    public class PostInfo
    {
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    
    




}