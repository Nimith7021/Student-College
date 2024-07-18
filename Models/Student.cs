using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePerson.Models
{
    internal class Student:Person
    {
        public string Branch { get; set; }

        public Student() { }

        public Student(int id, string address, DateTime dateTime, string branch):base(id,address,dateTime)
        {
            Branch = branch;
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}Branch : {Branch}";
        }
    }
}
