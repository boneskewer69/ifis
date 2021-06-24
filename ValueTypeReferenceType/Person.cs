using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeReferenceType
{
    public class Person
    {
        public String Name { get; set; }
        public int Alter { get; set; }

        public Person(String name, int alter)
        {
            this.Name = name;
            this.Alter = alter;
        }
    }
}
