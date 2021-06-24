using System;

namespace ValueTypeReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int x, y, z;
            x = 3;
            y = 3;
            z = x;

            Person a, b, c;
            a = new Person("Tim", 17);
            b = new Person("Tim", 17);
            c = a;

            // Aufgabe 1
            if (x == y && y == z)
                System.Console.WriteLine("1.a Alle Nummern sind gleich");
            else
                System.Console.WriteLine("1.a Die Nummern sind nicht identisch");

            if (a == b && b == c)
                System.Console.WriteLine("1.b Die Personen sind identisch");
            else
                System.Console.WriteLine("1.b Die Personen sind nicht identisch");
            // Alle anderen Datentypen sind Referenztypen

            // Aufgabe 2
            z = 4;
            if (x == z)
                System.Console.WriteLine("2.a x und z sind gleich");
            else
                System.Console.WriteLine("2.a x und z sind nicht gleich");

            System.Console.WriteLine($"2.b Wert von x ist {x}");

            // Aufgabe 3
            var neuesAlter = 18;
            c.Alter = neuesAlter;
            if (a == c)
                System.Console.WriteLine("3.a Person a und c sind identisch");
            else
                System.Console.WriteLine("3.a Person a und c sind nicht identisch");

            System.Console.WriteLine($"3.b Das Alter der Person a ist {a.Alter}");

            // Aufgabe 4
            System.Console.WriteLine($"4.a Wert von y vor dem Methodenaufruf: {y}");
            Increase(y);
            System.Console.WriteLine($"4.a Wert von y nach dem Methodenaufruf: {y}");

            System.Console.WriteLine($"4.b Alter von b vor dem Methodenaufruf: {b.Alter}");
            Increase(b);
            System.Console.WriteLine($"4.b Alter von b nach dem Methodenaufruf: {b.Alter}");

            // Aufgabe Array
            var arrayGroesse = 10;
            var zahlenArray = new int[arrayGroesse];
            var zahlenList = new System.Collections.Generic.List<int>();
            for (int i = 0; i < arrayGroesse; i++)
            {
                var randomNumber = random.Next();

                zahlenArray[i] = randomNumber;
                zahlenList.Add(randomNumber);
            }

            var zahlenArray2 = zahlenArray;
            if (zahlenArray == zahlenArray2)
                System.Console.WriteLine("Array: Arrays sind identisch.");
            else
                System.Console.WriteLine("Array: Arrays sind nicht identisch.");

            zahlenArray[2] = 100;
            if (zahlenArray == zahlenArray2)
                System.Console.WriteLine("Array Modified: Arrays sind identisch. -> Referenztyp");
            else
                System.Console.WriteLine("Array Modified: Arrays sind nicht identisch.");

            // Aufgabe Array nur mit List
            var zahlenList2 = zahlenList;
            if (zahlenList == zahlenList2)
                System.Console.WriteLine("List: Lists sind identisch.");
            else
                System.Console.WriteLine("List: Lists sind nicht identisch.");

            zahlenList2.Add(200);
            if (zahlenList == zahlenList2)
                System.Console.WriteLine("List Modified: Lists sind identisch. -> Referenztyp");
            else
                System.Console.WriteLine("List Modified: Lists sind nicht identisch.");
        }

        public static void Increase(int zahl)
        {
            // zahl um 1 erhoehen
            zahl += 1;
        }

        public static void Increase(Person p)
        {
            // alter um 1 erhoehen
            p.Alter += 1;
        }
    }
}
