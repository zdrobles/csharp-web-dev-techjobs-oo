using System;
namespace TechJobsOO
{
    public class Location : JobField
    {
        public Location(string v) : base(v)
        {
        }
        //public override bool Equals(object obj)
        //{
        //    return obj is Location location &&
        //           Id == location.Id;
        //}
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}
    }
}
