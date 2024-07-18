using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePerson.Models
{
    internal class Professor:Person
    {
        public double Salary { get; set; }

        public Professor() { }

        public Professor(int id, string address, DateTime dateTime,double salary):base(id,address,dateTime)
        {
            Salary = salary;
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}Salary : {Salary}";
        }
    }
}
