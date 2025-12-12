namespace ProxyPattern;

public class Employee
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string Premission { get; set; }

    public Employee(string name, string password, string premission) => (Name, Password, Premission) = (name, password, premission);
}
