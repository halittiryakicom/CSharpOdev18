using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev18
{
    //burada Abstract tanımlaması yapıyoruz.
    public abstract class Person
    {
        //property tanımlamaları
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dept { get; set; }

        //constructor
        public Person(string firstName, string lastName, string dept)
        {
            FirstName = firstName;
            LastName = lastName;
            Dept = dept;
        }
    }
}
