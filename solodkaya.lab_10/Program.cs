using System;

class Vector2D
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }

    public double Length()
    {
        return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    }
}

class Parallelogram : Vector2D
{
    public double A { get; set; }
    public double B { get; set; }

    public Parallelogram(double x1, double y1, double x2, double y2, double a, double b)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2 + a;
        Y2 = y2 + b;
        A = a;
        B = b;
    }

    public double Area()
    {
        double length1 = Length();
        double height = Math.Abs(B);
        return length1 * height;
    }
}

class Program
{
    static void Main()
    {
        double x1 = 1, y1 = 1, x2 = 4, y2 = 5, a = 2, b = 3;
        Parallelogram parallelogram = new Parallelogram(x1, y1, x2, y2, a, b);
        double area = parallelogram.Area();
        Console.WriteLine($"Площадь параллелограмма: {area}");
    }
}
