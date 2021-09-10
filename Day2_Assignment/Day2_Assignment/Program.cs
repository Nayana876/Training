using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x=function(5);

            while (true)
            {
                
                string input = Console.ReadLine();
                try
                {
                    if (input == "q")
                    {
                        break;
                    }
                    int x1 = Convert.ToInt32(input);

                    Console.WriteLine(function(x1));
                }
                catch
                {
                    Console.WriteLine("Give an integer");
                }
            }
           
            //Console.ReadLine();
        }

        private static int function(int y)
        {
            int x = ((y * y) + 2 * y + 1);
            return x;
        }
    }
}
