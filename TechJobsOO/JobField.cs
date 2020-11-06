using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }
    }
}
