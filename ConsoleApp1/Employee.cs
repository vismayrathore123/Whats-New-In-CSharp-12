using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee(string firstName,  string lastName)
    {
        public Employee():this("A","B")
        {

        }
        public Employee (string firstName, string lastName, string salary):this(firstName, lastName)
        {

        }
        public string FullName() => $"Full Name={firstName}{lastName}";
    }
}
