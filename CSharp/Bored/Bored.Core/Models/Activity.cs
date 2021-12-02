namespace Bored.Core.Models
{
    public class Activity
    {
        public string Key { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
        public double Accessibility { get; set; }
        public int NumberOfParticipants { get; set; }
        public double Price { get; set; }
    }
}
