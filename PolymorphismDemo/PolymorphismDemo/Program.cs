using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    enum role
    {
        Developer,Delivery_Manager=2
    }
    class User
    {
        public static int COUNT;
        const int age = 10;//instance const
        public role role;
        public string name { get; }//read only
        public User(string name)
        {
            const int age = 100;//local constant
            Console.WriteLine("User constructor {0}", User.age);
            Console.WriteLine("instance {0}", age);
            this.name = name;
        }
        public virtual void Enter()
        {
            Console.WriteLine("Superclass Enter");
        }
    }
    class Employee : User
    {
        
        public Employee(string name) : base(name) { }
        
        public void Enter()//overriding
        {
            Console.WriteLine("subclass enter");
        }
    }
    class Program
    {
        //static void Main(string[] args){
        //    demo();
        //}

        private static void demo()
        {
            Employee e1 = new Employee("Ram");
            e1.Enter();
            e1.role = role.Delivery_Manager;
            Console.WriteLine(e1.role + " => " + (int)e1.role);
            string str = role.Delivery_Manager.ToString();
            Console.WriteLine(str);
            Console.WriteLine(User.COUNT);
            User u1 = new Employee("Rahul");
            u1.Enter();
            Console.Read();
        }
    }
}
