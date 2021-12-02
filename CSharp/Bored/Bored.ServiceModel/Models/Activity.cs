using System.Runtime.Serialization;

namespace Bored.ServiceModel.Models
{
    [DataContract]
    public class Activity
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }
        
        [DataMember(Name = "activity")]
        public string Description { get; set; }
        
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "accessibility")]
        public double Accessibility { get; set; }
        
        [DataMember(Name = "participants")]
        public int NumberOfParticipants { get; set; }
        
        [DataMember(Name = "price")]
        public double Price { get; set; }
    }
}
