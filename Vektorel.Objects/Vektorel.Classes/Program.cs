namespace Vektorel.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Rectangle(4, 5);
            Console.WriteLine(r1);
            Console.WriteLine("Alan  : " + r1.GetArea());
            Console.WriteLine("Çevre : " + r1.GetPerimeter());

            Console.WriteLine("\n\n\n");

            var r2 = new Rectangle { ShortEdge = 5, LongEdge = 7 };
            Console.WriteLine(r2);
            Console.WriteLine("Alan  : " + r2.GetArea());
            Console.WriteLine("Çevre : " + r2.GetPerimeter());

            Console.WriteLine("\n\n\n");

            Rectangle r3 = new Rectangle() { ShortEdge = 2, LongEdge = 4 };
            Console.WriteLine(r3);
            Console.WriteLine("Alan  : " + r3.GetArea());
            Console.WriteLine("Çevre : " + r3.GetPerimeter());

            Console.WriteLine("\n\n\n");

            Rectangle r4 = new() { ShortEdge = 6, LongEdge = 9 };
            Console.WriteLine(r3);
            Console.WriteLine("Alan  : " + r4.GetArea());
            Console.WriteLine("Çevre : " + r4.GetPerimeter());

            Console.WriteLine("\n\nKare Tanımı");
            var s1 = new Square(10);
            Console.WriteLine(s1.GetArea());

            var l1 = new Line(12);
            Console.WriteLine(l1.Length);
        }
    }

    class Rectangle
    {
        //Constructor
        public Rectangle()
        {

        }

        public Rectangle(double se, double le)
        {
            ShortEdge = se;
            LongEdge = le;
        }
        public double ShortEdge;
        public double LongEdge;

        public double GetArea()
        {
            return ShortEdge * LongEdge;
        }

        public double GetPerimeter()
        {
            return 2 * (ShortEdge + LongEdge);
        }

        public override string ToString()
        {
            return "Kısa Kenar : " + ShortEdge + ", Uzun Kenar : " + LongEdge;
        }
    }

    class Square
    {
        public Square(ushort edge)
        {
            if (edge == 0)
            {
                throw new Exception("Uygun olmayn değer");
            }
            Edge = edge;
        }

        public ushort Edge;

        public int GetArea()
        {
            return Edge * Edge;
        }
    }

    record Line(double Length);
}


/*
 CLEAN CODE

- Avoid using else
 */