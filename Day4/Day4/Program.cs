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
        public string this[int index] //indexer
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
        public int this[string name] //indexer
        {
            get
            {
                int index = 0;
                while (index < 10)
                {
                    if (names[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
            
        }
    }
}
