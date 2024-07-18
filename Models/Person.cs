using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePerson.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public DateTime Dob { get; set; }

        public Person() { }

        public Person(int id, string address,DateTime dateTime)
        {
            Id = id;
            Address = address;
            Dob = dateTime;
        }

        public virtual string PrintDetails()
        {
            return $"Person Id : {Id}\n" +
                $"Person Address : {Address}\n" +
                $"Person DOB :{Dob}\n";
        }
    }
}
