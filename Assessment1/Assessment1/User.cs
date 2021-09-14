using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    enum Role
    {
        Patient,Physician,Nurse,EmergencyContact
    }
    class User
    {
        private string Title { get; set; }
        public string firstName { get; }
        public string lastName { get; }
        private string emailId { get; set; }
        public DateTime dob { get;  }
        private sbyte age { get; }
        public Role role { get; }
        public User(string fName,string lName,string email,DateTime dob,Role role)
        {
            Console.WriteLine(dob);
            this.firstName = fName;
            this.lastName = lName;
            this.emailId = email;
            this.dob = dob;
            this.age = 0;
            this.role = role;
        }
            
    }
    
}
