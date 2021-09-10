using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            sum();
        }

        private static void sum()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
