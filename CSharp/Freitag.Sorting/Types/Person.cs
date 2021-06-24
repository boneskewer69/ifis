using System;

namespace Freitag.Sorting.Types
{
    public class Person : IComparable<Person>
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Ich heiße {FristName} {LastName} und ich bin {Age} Jahre alt.";
        }

        private int CustomCompareAge(Person person)
        {
            if (Age == person.Age)
                return 0;
            else if (Age > person.Age)
                return 1;
            else
                return -1;
        }

        private int CompareAgeAndName(Person person)
        {
            return Age.CompareTo(person.Age) == 0 ?
                LastName.CompareTo(person.LastName) :
                Age.CompareTo(person.Age);
        }

        private int CompareName(Person person)
        {
            return LastName.CompareTo(person.LastName);
        }

        private int CompareAge(Person person)
        {
            return Age.CompareTo(person.Age);
        }

        public int CompareTo(Person person)
        {
            return CustomCompareAge(person);
        }
    }
}
