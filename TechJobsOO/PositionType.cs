using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType(string v) : base(v)
        {
        }
        //public override bool Equals(object obj)
        //{
        //    return obj is PositionType type &&
        //           Id == type.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}
    }
}
