using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class AbstractDemo
    {
        private static void Main(string[] args)
        {
            Employee1 e1 = new Employee1("Ram");
            e1.Enter();
            
            Console.WriteLine(User1.COUNT);
            User1 u1 = new Employee1("Rahul");
            u1.Enter();
            Console.Read();
        }
    }
    enum role1
    {
        Developer, Delivery_Manager = 2
    }
    abstract class User1
    {
        public static int COUNT;
        const int age = 10;//instance const
        public role1 role;
        public string name { get; }//read only
        public User1(string name)
        {
            const int age = 100;//local constant
            Console.WriteLine("User constructor {0}", User1.age);
            Console.WriteLine("instance {0}", age);
            this.name = name;
        }
        public abstract void Enter();
        public string getName()
        {
            return this.name;
        }
    }
    class Employee1 : User1
    {

        public Employee1(string name) : base(name) { }

        public override void Enter()//overriding
        {
            Console.WriteLine("subclass enter");
        }
       
    }
}
