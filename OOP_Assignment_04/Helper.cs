namespace OOP_Assignment_04;
#region With Part2
#region Q1
internal interface Helper
{
    public double PropertyArea { get; }
    public void DisplayShapeInfo();
}
internal interface ICircle : Helper
{
    public double Radius { get; set; }

}
internal interface IRectangle : Helper
{
    public double Width { get; set; }
    public double Height { get; set; }

}
public class Circle : ICircle
{
    public double PropertyArea { get; set; }
    public double Radius { get; set; }
    public void DisplayShapeInfo()
    {
        PropertyArea = Math.PI * Math.Pow(Radius, 2);
        Console.WriteLine("The Area of Circle = " + PropertyArea);
    }
}
public class Rectangle : IRectangle
{
    public double PropertyArea { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public void DisplayShapeInfo()
    {
        PropertyArea = Width * Height;
        Console.WriteLine("The Area of Rectangle = " + PropertyArea);

    }
}
#endregion

#region Q2
internal interface IAuthenticationService
{
    public bool AuthenticateUser(string username, string password);
    public bool AuthorizeUser(string username, string role);
}
public class BasicAuthenticationService : IAuthenticationService
{
    // Create Data For UserName
    string[] UserName = { "AhmedSayed", "AboElSayed", "Sayed" };
    // Create Data For Password
    string[] Password = { "123ahmed", "1357Ahmed", "Sayed84" };


    public bool AuthenticateUser(string username, string password)
    {
        if (username == null || password == null)
            return false;
        for (int i = 0; i < UserName.Length; i++)
        {
            if (UserName[i] == username && Password[i] == password)
            {
                return true;
            }
        }
        return false;
    }
    // Create Data For UserName
    string[] Role = { "Admin", "admin", "AS_Admin" };
    public bool AuthorizeUser(string username, string role)
    {
        if (username == null || role == null)
            return false;
        for (int i = 0; i < UserName.Length; i++)
        {
            if (UserName[i] == username && Role[i] == role)
            {
                return true;
            }
        }
        return false;
    }
}
#endregion

#region Q3
internal interface INotificationService
{
    public void SendNotification(string recipient, string message);
}
public class EmailNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Email : {recipient}. You have A message : {message}");
    }
}
public class SmsNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Phone Number : {recipient}. You have A message : {message}");
    }
}
public class PushNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"User : {recipient}. You have A message : {message}");
    }
}
#endregion
#endregion
