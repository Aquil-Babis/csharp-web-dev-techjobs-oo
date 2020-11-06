using System;
using System.Dynamic;

namespace TechJobsOO
{
    public class CoreCompetency: JobField
    {


        public CoreCompetency(string value) : base()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
    
}
