public class Circle : Shape
{
    private double _radius = 0;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double pi = 3.1495;
        double area = pi * (_radius * _radius);
        return area;
        
    }
}