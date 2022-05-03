using System;
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
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
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

        private string checkEmpty(string str)
        {
            if (str == "")
            {
                return "Data not available";
            }
            return str;
        }

        public override string ToString()
        {
            string str = "\n";
            if (Name != null)
            {
                str += $"ID: {Id}\nName: {checkEmpty(Name)}\nEmployer: {checkEmpty(EmployerName.ToString())}\nLocation: {checkEmpty(EmployerLocation.ToString())}\nPosition Type: {checkEmpty(JobType.ToString())}\nCore Competency: {checkEmpty(JobCoreCompetency.ToString())}";
            }
            else
            {
                str += "OOPS! This job does not seem to exist.";
            }

            return str += "\n";
        }
    }
}
