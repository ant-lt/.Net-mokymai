namespace P038_Inheritance
{
    public class Polygon
    {
        public Polygon()
        {
            NumberOfAngles = 0;
        }

        public Polygon(int numberOfAngles)
        {
            NumberOfAngles = numberOfAngles;
        }

        public int NumberOfAngles { get; set; }

        public virtual double GetPerimeter() // virtual pasako, kad paveldetojo klaseje galima perrasyti
        {
            return 0;
        }
    }

    public class Square : Polygon
    {
        public Square()
        {
            NumberOfAngles = 4;
        }

        public Square(double size)
        {
            Size = size;
            NumberOfAngles = 4;
        }

        public Double Size { get; set; }

        public override double GetPerimeter()
        {
            return NumberOfAngles*4;
        }
    }

    public class Triangle : Polygon
    {
       public Triangle() : base(3) {}

        public override double GetPerimeter()
        {
            return NumberOfAngles * 3;
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Inheritance!");

            Square square = new Square();
            Console.WriteLine("NumberOfAngles->" + square.NumberOfAngles);
            Console.WriteLine("Size in  square->" + square.Size);

            Triangle triangle = new Triangle();
            Console.WriteLine("NumberOfAngles->" + triangle.NumberOfAngles);


            Square square1 = new Square(555);
            Console.WriteLine("NumberOfAngles square1->" + square1.NumberOfAngles);
            Console.WriteLine("Size in  square1->" + square1.Size);
            Console.WriteLine("Perimeter in  square1->" + square1.GetPerimeter());

            Polygon square2 = new Square(444);
            if (square2 is Square)
            {
                Console.WriteLine("Size in  square2->" + ((Square)square2).Size);
                Console.WriteLine("Size in  square2->" + (square2 as Square).Size);
            }

            Polygon polygon1 = new Triangle();
            if (polygon1 is Square)
            {
                Console.WriteLine("Size in  polygon1->" + ((Square)polygon1).Size);
            }

            List<Polygon> polygons = new List<Polygon>();
            
            polygons.Add(square);
            polygons.Add(triangle);
            polygons.Add(square2);

            foreach (var item in polygons)
            {
                Console.WriteLine($" {item.GetType().Name} NumberOfAngles = " + item.NumberOfAngles);
                if (item is Square)
                {
                    Console.WriteLine("Size in item =" + ((Square)item).Size);
                }
                Console.WriteLine("GetPerimeter() in item =" + item.GetPerimeter());
            }

        }
    }
}