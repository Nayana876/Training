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
            OutDemo();
            RefDemo();
            Console.Read();

        }
        private static void RefDemo()
        {
            string str1 = "Ram";//for ref initialization is required
            setValue(ref str1);
            Console.WriteLine(str1);

        }

        static void setValue(ref string str)
        {
            str = "qwerty";
        }

        private static void OutDemo()
        {
            int result;
            float resFloat;
            Add(out result, out resFloat);
            Console.WriteLine(result + " " + resFloat);
        }
        //out- the out variables must be initialised within the function -initialization before fun call not required
        //ref -initialisation required before fnction call
        public static bool Add(out int a,out float b)
        {
            a = 20;
            a = a + a1;
            b = 10;
            return true;
        }
    }
}
