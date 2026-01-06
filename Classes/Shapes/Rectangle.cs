public class Rectangle : Shape
{
    public double Width { get; } // no accesible setter (set;)
    public double Heigth { get; } // we "set" the values, using a constructor

    public Rectangle(double width, double heigth)
    {
        Width = width;
        Heigth = heigth;
    }

    // method override
    public override double GetArea()
    {
        return Width * Heigth;
    }
}