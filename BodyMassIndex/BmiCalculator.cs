using System;
using BodyMassIndex.Types;

namespace BodyMassIndex
{
    public class BmiCalculator
    {
        public static BmiResult CalculateBmi(Person person)
        {
            var bmi = person.Weight / Math.Pow(person.Height, 2);

            return new BmiResult
            {
                Index = bmi,
                Result = EvaluateBmi(bmi, person.Gender)
            };
        }

        private static BmiResultCase EvaluateBmi(double bmi, Gender gender)
        {
            return BmiResultCase.NORMAL;
        }
    }
}
