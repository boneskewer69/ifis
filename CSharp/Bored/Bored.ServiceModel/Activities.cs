using ServiceStack;

using Bored.ServiceModel.Models;
using System.Runtime.Serialization;

namespace Bored.ServiceModel
{
    [DataContract]
    [Route("/activity")]
    public class GetActivity : IGet, IReturn<Activity>
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }
        
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "participants")]
        public int Participants { get; set; }

        [DataMember(Name = "price")]
        public double Price { get; set; }

        [DataMember(Name = "maxprice")]
        public double MaxPrice { get; set; }

        [DataMember(Name = "minprice")]
        public double MinPrice { get; set; }

        [DataMember(Name = "accessibility")]
        public double Accessibility { get; set; }

        [DataMember(Name = "minaccessibility")]
        public double MinAccessibility { get; set; }

        [DataMember(Name = "maxaccessibility")]
        public double MaxAccessibility { get; set; }
    }
}
