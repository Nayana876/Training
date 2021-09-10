using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                Console.Write("Enter value");
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

            int[,,] arr3d1 = new int[1, 2, 2] { { { 1, 2 }, { 3, 4 } } };
            int[,,] arr3d2 = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } }; 
            int[,,] arr3d3 = new int[2, 2, 3]{ { { 1, 2, 3}, {4, 5, 6} },{ { 7, 8, 9}, {10, 11, 12} }};

            Console.WriteLine(arr3d2[0, 0, 0]);
            Console.WriteLine(arr3d2[1, 1, 1]);
            Console.WriteLine(arr3d1[0, 0, 1]);
            Console.WriteLine(arr3d2[0, 1, 1]);
            Console.WriteLine(arr3d2[1, 0, 0]);
            Console.WriteLine(arr3d2[1, 0, 1]);
            Console.WriteLine(arr3d2[1, 1, 1]);

            
            string[] names = { "Steve", "Bill", "bill","Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
            var stringToFind = "Bill";

            //Find literal value
            var result = Array.Find(names, element => element == stringToFind); // returns "Bill"
            Console.WriteLine(result);

            //Find all literal value
            string stringToFind1 = "bill";
            string[] result1 = Array.FindAll(names, element => element.ToLower() == stringToFind); // return Bill, bill
            foreach(string s in result1)
            {
                Console.Write(s+" ");
            }

            //Find elements that starts with B
            result = Array.Find(names, element => element.StartsWith("B")); // returns Bill
            Console.WriteLine(result);

            //Find all elements that starts with B
            string[] result2 = Array.FindAll(names, element => element.StartsWith("B")); // return Bill, Boski
            foreach (string s in result2)
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine(); 

            //Find by length
            result = Array.Find(names, element => element.Length >= 5); //returns Steve
            Console.WriteLine(result);

            //Find all elements by length
            result2 = Array.FindAll(names, element => element.Length >= 5); // returns Steve, James, Mohan, Salman, Boski 
            foreach (string s in result2)
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine();

            //Find last element
            result = Array.FindLast(names, element => element.Contains(stringToFind)); //returns Bill Gates
            Console.WriteLine(result);

            //find last elements by length
            result = Array.FindLast(names, element => element.Length >= 6); // returns Boski
            Console.WriteLine(result);


            //COUNT TOTAL NUMBER OF ARRAY ELEMENTS
            string[] empty = new string[5];
            var totalElements = empty.Count(); //5
            string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
            totalElements = animals.Count(); //6
            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
            totalElements = nums.Count(); //12

            //Count Specific Elements
            var totalCats = animals.Count(s => s == "Cat");
            Console.WriteLine(totalCats);
            var animalsStartsWithA = animals.Count(s => s.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
            var totalEvenNums = nums.Count(n => n % 2 == 0);
            Console.WriteLine(totalEvenNums);

            //Regex with count
            var animalsWithCapitalLetter = animals.Count(s =>
            {
                return Regex.IsMatch(s, "^[A-Z]");
            });
            Console.WriteLine(animalsWithCapitalLetter);

            //Combining array
            int[] num1 = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] num2 = { 55, 23, 45, 50, 80 };
            var all = num1.Union(num2).ToArray();
            foreach(int i in all)
            Console.Write(i+" ");

            //

            Console.ReadLine();
        }

        private static int function(int y)
        {
            int x = ((y * y) + 2 * y + 1);
            return x;
        }
    }
}
