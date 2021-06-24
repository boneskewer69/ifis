namespace BodyMassIndex.Types
{
    public class Male : Person
    {
        public Male(int age, double height, double weight)
            : base(age, height, weight, Gender.MALE) { }
    }
}
