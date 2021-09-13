using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2

{  
    class Person : IEquatable<Person>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Equals(Person other)
        {
            return FirstName.Equals(other.FirstName) && LastName.Equals(other.LastName);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ (FirstName == null ? 0 : FirstName.GetHashCode()) ^ (LastName == null ? 0 : LastName.GetHashCode());
        }
    }
    class PersonComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Person)x).LastName, ((Person)y).LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };
            string[] birds = { "Sparrow", "Peacock", "Dove", "Crow" };

            var all = animals.Union(birds).ToArray();

            var str = String.Join(",", animals);
            Console.WriteLine(str);
            //Remove duplicate from integer array
            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] dist = nums.Distinct().ToArray();

            //Sort 
            Array.Sort(animals);
            Array.ForEach<string>(animals, s => Console.WriteLine(s));

            var sortedStr = from name in animals
                            orderby name descending
                            select name;
            Console.WriteLine("sortedStr");
            Array.ForEach<string>(sortedStr.ToArray<string>(), s => Console.WriteLine(s)); // Result: ["Goat", "Fox", "Elephant", "Donkey", "Cat", "Bear", "Alligator"]
            Person[] people = {
                new Person(){ FirstName="Steve", LastName="Jobs"},
                new Person(){ FirstName="Bill", LastName="Gates"},
                new Person(){ FirstName="Lary", LastName="Page"}
            };
            var qry = from p in people
                      orderby p.LastName
                      select p;
            //Array.ForEach<string>(qry, s => Console.WriteLine(s)); // Result: ["Goat", "Fox", "Elephant", "Donkey", "Cat", "Bear", "Alligator"]
            Console.WriteLine(qry);
            Array.Sort(people, new PersonComparer());
            Console.ReadLine();
        }
    }
}
