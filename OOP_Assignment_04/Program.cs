using System.Drawing;

namespace OOP_Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part(1)
            /*
             
             Q1* (b) To define a blueprint for a class
            
             Q2* (a) private

             Q3* (c) Only if they are static
             
             Q4* (b) Yes, interfaces can inherit from multiple interfaces
             
             Q5* (d) implements
             
             Q6* (a) Yes
             
             Q7* (b) No, all members are implicitly public
             
             Q8* (a) To hide the interface members from outside access
             
             Q9* (b) No, interfaces cannot have constructors
             
             Q10*(c) By separating interface names with commas

            */

            #endregion

            #region Part(2)
            #region Q1
            Circle circle = new Circle();
            Console.Write("Enter Radius = ");
            circle.Radius = double.Parse(Console.ReadLine()!);
            circle.DisplayShapeInfo();
            Rectangle rectangle = new Rectangle();
            Console.Write("Enter Width = ");
            rectangle.Width = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Height = ");
            rectangle.Height = double.Parse(Console.ReadLine()!);
            rectangle.DisplayShapeInfo();
            #endregion

            #region Q2
            Console.WriteLine("\n");
            IAuthenticationService basicAuthenticationService = new BasicAuthenticationService();
            Console.Write("Enter UserName = ");
            string username = Console.ReadLine()!;
            Console.Write("Enter Password = ");
            string password = Console.ReadLine()!;
            Console.WriteLine("AuthenticateUser IS " + basicAuthenticationService.AuthenticateUser(username, password));
            Console.Write("Enter Role     = ");
            string role = Console.ReadLine()!;
            Console.Write("AuthorizeUser    IS " + basicAuthenticationService.AuthorizeUser(username, role));
            Console.WriteLine("\n");
            #endregion

            #region Q3
            string email = "ahmedshkra246@gmail.com";
            string Phone = "+20100057933";
            string UserName = "user123";
            EmailNotificationService emailNotificationService = new EmailNotificationService();
            SmsNotificationService smsNotificationService = new SmsNotificationService();
            PushNotificationService pushNotificationService = new PushNotificationService();
            emailNotificationService.SendNotification(email, "Welcome to our service!");
            smsNotificationService.SendNotification(Phone, "Welcome to our service!");
            pushNotificationService.SendNotification(UserName, "Welcome to our service!");
            #endregion
            #endregion

            Console.ReadKey();
        }
    }
}
