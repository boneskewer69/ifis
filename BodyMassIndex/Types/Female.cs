namespace BodyMassIndex.Types
{
    public class Female : Person
    {
        public Female(int age, double height, double weight)
            : base(age, height, weight, Gender.FEMALE) { }
    }
}
