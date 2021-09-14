using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientModule;
namespace Assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient("Ram", "akhil", "ram@g.com", DateTime.Today);
            Console.WriteLine(p1.myId);
            Patient p2 = new Patient("Ram", "akhil", "ram@g.com", DateTime.Today);
            Console.WriteLine(p2.myId);
            Console.Read();
        }
    }
}
