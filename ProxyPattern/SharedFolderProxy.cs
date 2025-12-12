namespace ProxyPattern;

public class SharedFolderProxy(Employee employee) : ISharedFolder
{
    private SharedFolder? sharedFolder;
    private Employee employee = employee;


    public void PerformRWOperations()
    {
        if(employee.Premission.ToLower() == "admin")
        {
            sharedFolder = new SharedFolder();
            sharedFolder.PerformRWOperations();
        }
        else
        {
            Console.WriteLine("Access Denied");
        }
    }
}