using System;

namespace BodyMassIndex.Types
{
    public class Person
    {
        public int Age { get; protected set; }
        public double Height { get; protected set; }
        public double Weight { get; protected set; }
        public Gender Gender { get; protected set; }

        public Person(int age, double height, double weight, Gender gender)
        {
            Age = age;
            Height = height;
            Weight = weight;
            Gender = gender;
        }
    }
}
