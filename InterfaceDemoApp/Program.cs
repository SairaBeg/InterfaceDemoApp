using System;
using System.Reflection.Metadata;

//abstract class Figure
//{
//    protected int Dimension;
//    public Figure() { }
//    public Figure(int dimension)
//    {
//        Dimension = dimension;
//    }
//    public abstract double Area();
//    public abstract double Perimeter();

//}
interface IFigure
{
    int Dimension { get; set; }

    double Area();
    double Perimeter();

}

class Circle: IFigure
{
    public Circle() { }
    public Circle(int radius)
        { _radius = radius; }
    private int _radius;
    public int Dimension { get { return _radius; } set { _radius = value; } }
    public double Area()
    {
        return Math.PI * Dimension * Dimension;
    }
    public  double Perimeter()
    {
        return 2 * Math.PI * Dimension;
    }
}
class Square : IFigure
{
public Square(int side)
         { Dimension = side; }

    public int Dimension { get; set; }
    public  double Area()
    {
        return Dimension * Dimension;
    }

    public  double Perimeter()
    {
        return 4 * Dimension;
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        IFigure fig;
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter C for circle or S for Square");
        }
        if (args[0] == "C")
            fig = new Circle(10);
        else
            fig = new Square(10);
        Console.WriteLine(fig.Area());
        Console.WriteLine(fig.Perimeter());
    }
}