# AbstractionExample

Bu projede patika dev .net-core eðitimi için C# dili kullanarak Abstraction örneði yapýlmýþtýr.

## Ýçerik

- [Kullaným](<#kullaným-(usage)>)
- [Kod Açýklamasý](#kod-açýklamasý)

## Kullaným (Usage)
	public abstract class Person
    {
        //property tanýmlamalarý
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
Yukarýdaki kod bloðu Person abstract sýnýfý oluþturmuþtur.

    internal class Employe : Person
    {
        public Employe(string firstName, string lastName, string dept) : base(firstName, lastName, dept)
        {
            Console.WriteLine($"Merhaba ben {firstName} {lastName}. {dept}'nýnda çalýþýyorum.");
        }

        public void Proffesion(string data)
        {
            Console.WriteLine($"{data} olarak çalýþmaktayým.");
        }
    }
Burada Employe sýnýfýna Person sýnýfý kalýtým yapýlmýþtýr.

## Kod Açýklamasý
Person sýnýfý
FirstName, LastName: Person Class da prototype
Person(): Bu constructor da deðiþkenler propertylere atanmýþtýr.

Employe Sýnýfý
Employe(): Burada employe sýnýfýna contructor tnaýmlanmýþtýr.
Proffession(): Kiþinin mesleðini belirtmek için oluþturulmuþ bir sýnýf.
