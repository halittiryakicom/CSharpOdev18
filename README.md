# AbstractionExample

Bu projede patika dev .net-core e�itimi i�in C# dili kullanarak Abstraction �rne�i yap�lm��t�r.

## ��erik

- [Kullan�m](<#kullan�m-(usage)>)
- [Kod A��klamas�](#kod-a��klamas�)

## Kullan�m (Usage)
	public abstract class Person
    {
        //property tan�mlamalar�
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
Yukar�daki kod blo�u Person abstract s�n�f� olu�turmu�tur.

    internal class Employe : Person
    {
        public Employe(string firstName, string lastName, string dept) : base(firstName, lastName, dept)
        {
            Console.WriteLine($"Merhaba ben {firstName} {lastName}. {dept}'n�nda �al���yorum.");
        }

        public void Proffesion(string data)
        {
            Console.WriteLine($"{data} olarak �al��maktay�m.");
        }
    }
Burada Employe s�n�f�na Person s�n�f� kal�t�m yap�lm��t�r.

## Kod A��klamas�
Person s�n�f�
FirstName, LastName: Person Class da prototype
Person(): Bu constructor da de�i�kenler propertylere atanm��t�r.

Employe S�n�f�
Employe(): Burada employe s�n�f�na contructor tna�mlanm��t�r.
Proffession(): Ki�inin mesle�ini belirtmek i�in olu�turulmu� bir s�n�f.
