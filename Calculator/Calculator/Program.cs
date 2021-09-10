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
            //sum();
            string val = null;
            string val2 = "100.11";
            string val3 = "999999999999999";
            int result;
            bool ifSuccess = int.TryParse(val, out result);
            bool ifSuccess2 = int.TryParse(val2, out result);

            Console.WriteLine(ifSuccess);
            Console.WriteLine(result);
            Console.WriteLine(ifSuccess2);
            
            Object MyObj = 30;
            int i =MyObj;
            Console.WriteLine(i);
            Console.ReadLine();

        }
        private static void sum()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.ReadLine();
        }

    }
}
