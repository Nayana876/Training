using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class RefAndOutDemo
    {
        static int a1 = 10;
        public static void Main(string[] values)
        {
            int result;
            Add(out result);
            Console.Write(result);
            Console.Read();
        }

        public static bool Add(out int a)
        {
            a = 20;
            a = a + a1;
            return true;
        }
    }
}
