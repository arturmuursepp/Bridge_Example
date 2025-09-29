using System;

namespace Bridge_Example
{
    interface IColor
    {
        string ApplyColor();
    }

    class Red : IColor
    {
        public string ApplyColor() => "Red";
    }
    class Blue : IColor
    {
        public string ApplyColor() => "Blue";
    }
    class Green : IColor
    {
        public string ApplyColor() => "Green";
    }

    abstract class Shape
    {
        protected IColor color;

        protected Shape(IColor color)
        {
            this.color = color;
        }

        public abstract void Draw();
    }

    class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.ApplyColor()} Circle");
        }
    }

    class Square : Shape
    {
        public Square(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.ApplyColor()} Square");
        }
    }

    class Triangle : Shape
    {
        public Triangle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.ApplyColor()} Triangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(new Red());
            Shape blueSquare = new Square(new Blue());
            Shape greenTriangle = new Triangle(new Green());

            redCircle.Draw();
            blueSquare.Draw();
            greenTriangle.Draw();

            Console.ReadLine();
        }
    }
}