using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> NeutronGane = new List<Shape>();
        Square Sheen = new Square("red",5);
        Rectangle Jimmey = new Rectangle("blue", 20, 50);
        Circle Carel = new Circle("green", 5);

        NeutronGane.Add(Sheen);
        NeutronGane.Add(Jimmey);
        NeutronGane.Add(Carel);

        foreach (Shape shape in NeutronGane){
            Console.WriteLine( shape.GetArea());
        }

        
    }
}