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
            #endregion

            Console.ReadKey();
        }
    }
}
