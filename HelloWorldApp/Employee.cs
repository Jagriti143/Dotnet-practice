using System.IO.Compression;
namespace HelloWorldApp
{
class Employee{
    int Id;
    string Name;
    string Department;
    float Salary;
    char Gender;
    public void AcceptDetails(){
            Console.WriteLine("Employee Details: ");
            Console.WriteLine("Enter Employee Id: ");
            Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employees Name: ");
            Name=Console.ReadLine();
            Console.WriteLine("Enter Employees Department: ");
            Department=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            Salary=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Employee Gender: ");
            Gender=Convert.ToChar(Console.ReadLine());
    }
        public void DisplayDetails(){
           Console.WriteLine("Employee Details are:  ");
           Console.WriteLine($"Employee Id: {Id}");
           Console.WriteLine($"Employee Name: {Name}");
           Console.WriteLine($"Employee Salary: {Salary}");
           Console.WriteLine($"Employee Department: {Department}");
           Console.WriteLine($"Employee Gender: {Gender}");
        }
}

}