using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Shape()
        {
            Console.WriteLine("Super Constructor called");
        }
    }
    class Triangle : Shape 
    {
        string kind;
        static long DateOfCreation;
        static Triangle()
        {
            DateOfCreation = DateTime.Now.Ticks;
            Console.WriteLine("Static constructor called");
        }
        public Triangle(double Width1, double v2):this(Width1)
        {
            //Width = Width1;
            Height = v2;
        }

        public Triangle(double Width1):base()
        {
            Width = Width1;

            //if the parameter given was not 'Width' it would have worked
        }

 
    }
    class Program
    {
        static void Main(string[] args)
        {
            BasicsOfInheritance();

        }

        private static void BasicsOfInheritance()
        {
            Triangle t1 = new Triangle(12.1, 23.3);
            new Triangle(12.1, 23.3);
            Shape t2 = t1;
            // new Triangle() can't create object from static constructor'
            Triangle twidth = new Triangle(20.0);
            Console.WriteLine(twidth.Width);
            Console.WriteLine(t1.Width);
            Console.WriteLine(t1 == t2);
            Console.Read();
        }
    }
}
