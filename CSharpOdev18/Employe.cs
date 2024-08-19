using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev18
{
    internal class Employe : Person
    {
        public Employe(string firstName, string lastName, string dept) : base(firstName, lastName, dept)
        {
            Console.WriteLine($"Merhaba ben {firstName} {lastName}. {dept}'nında çalışıyorum.");
        }

        public void Proffesion(string data)
        {
            Console.WriteLine($"{data} olarak çalışmaktayım.");
        }
    }
}
