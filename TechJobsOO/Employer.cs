using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {
        public Employer(string v) : base(v)
        {
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is Employer employer &&
        //           Id == employer.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}
    }
}
