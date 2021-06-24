namespace BodyMassIndex.Types
{
    public class BmiResult
    {
        public BmiResultCase Result { get; set; }
        public double Index { get; set; }
    }
    
    public enum BmiResultCase
    {
        EXTRREMEOVERWEIGHT,
        OVERWEIGHT,
        NORMAL,
        UNDERWEIGHT,
        SEVERELYUNDERWEIGHT
    }
}