using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_ÖvningGenerics
{
    internal class StudentSameValue : EqualityComparer<Student>
    {
        public override bool Equals(Student? S1, Student? S2)
        {
            if (S1.ID == S2.ID && S1.Grade == S2.Grade && S1.Total == S2.Total)


            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Student obj)
        {
            var hcode = obj.ID ^ obj.Grade ^ obj.Total;
            Console.WriteLine( "HC : {0}",hcode.GetHashCode());
            return hcode.GetHashCode();
        }
    }
}
