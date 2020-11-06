using System;
using System.Collections.Generic;
using System.Linq;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency): this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            List<string> jobFields = new List<string>();

            if (this.Name == null && this.EmployerName == null && this.EmployerLocation == null && this.JobType == null && this.JobCoreCompetency == null)
            {
                return ("\n" + "OOPS! This job does not seem to exist." + "\n");
            }
            else
            {
                jobFields.Add($"ID: {this.Id}");
                jobFields.Add($"Name: {(this.Name != "" ? this.Name : "Data not Available")}");
                jobFields.Add($"Employer: {(this.EmployerName.Value != "" ? this.EmployerName.Value : "Data not Available")}");
                jobFields.Add($"Location: {(this.EmployerLocation.Value != "" ? this.EmployerLocation.Value : "Data not Available")}");
                jobFields.Add($"Position Type: {(this.JobType.Value != "" ? this.JobType.Value : "Data not Available")}");
                jobFields.Add($"Core Competency: {(this.JobCoreCompetency.Value != "" ? this.JobCoreCompetency.Value : "Data not Available")}");

                return "\n" + String.Join('\n', jobFields) + "\n";
            }
        }
    }
}
