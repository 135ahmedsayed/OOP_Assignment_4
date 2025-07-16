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
#endregion
