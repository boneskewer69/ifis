using System;
using System.Linq;
using System.Collections.Generic;

using Freitag.Interfaces.Interfaces;
using Freitag.Interfaces.Calculators;

using Freitag.Sorting.Types;

namespace Freitag
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //InterfacesDemo();
            SortingDemo();
        }

        private static void InterfacesDemo()
        {
            var maxRandomValue = 100;
            var rand = new Random();

            List<ICalculator> calculators = new();
            
            calculators.Add(new Add());
            calculators.Add(new Subtract());
            calculators.Add(new Multiply());
            calculators.Add(new Devide());

            calculators = calculators.OrderByDescending(x => x.OperationName).ToList();

            foreach (var calculator in calculators)
            {
                var a = rand.Next(maxRandomValue);
                var b = rand.Next(maxRandomValue);

                var result = calculator.Calculate(a, b);

                Console.WriteLine($"[{calculator.OperationName}] {a} {calculator.Operator} {b} = {result}");
            }
        }

        private static void SortingDemo()
        {
            List<Person> persons = new();

            persons.Add(new Person
            {
                FristName = "Hans",
                LastName = "Dietrich",
                Age = 34
            });
            persons.Add(new Person
            {
                FristName = "Daniel",
                LastName = "Müller",
                Age = 21
            });
            persons.Add(new Person
            {
                FristName = "Luise",
                LastName = "Marx",
                Age = 19
            });

            PrintPersons(persons);
            persons.Sort();
            PrintPersons(persons);
        }

        private static void PrintPersons(List<Person> persons)
        {
            Spacer();

            foreach (var person in persons)
                Console.WriteLine(person);

            Spacer();
        }

        private static void Spacer()
        {
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
