using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assessment1;
namespace PatientModule
{
    class Patient : User
    {
        private static byte Id = 0;
        public byte myId { get; }
        public Patient(string firstName, string lastName, string email, DateTime dob) : base(firstName, lastName, email, dob, Role.Patient)
        {
            this.myId = ++Id;
            IndexedClass alergies = new IndexedClass();
        }
        class IndexedClass
        {
            private string[] names = new string[10];
            private static int ind
            void add(string allergy)
            {

            }
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
}
