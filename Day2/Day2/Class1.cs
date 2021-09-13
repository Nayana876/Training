using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Class1
    {
        static void Main(string[] args)
        {
            string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };

            string[] dist = animals.Distinct().ToArray();

            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
            var totalEvenNums = nums.Count(n => n % 2 == 0);
            var totalCats = animals.Count(s => s == "Cat");
        }
    }
}
