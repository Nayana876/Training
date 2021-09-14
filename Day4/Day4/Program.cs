using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexedClass nameList = new IndexedClass();
            //syntatic sugar
            nameList[0] = "Ram";
            Console.WriteLine(nameList[0]);
            Console.Read();
        }
    }
    class IndexedClass
    {
        private string[] names = new string[10];
        public string this[int index]
        {
            get
            {
                return (index >= 0 && index <= 9) ? names[index] : "";
            }
            set
            {
                if (index >= 0 && index <= 9)
                {
                    names[index] = value;
                }
            }
        }
    }
}
