using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay4CSharp
{
    internal class CustomComparerOnClassTrainee : IComparer<Trainee>
    {
        public int Compare(Trainee? x, Trainee? y)
        {
            if (x == null || y == null)
            {
                return 0;
            }
            return x.Nid.CompareTo(y.Nid);
        }
    }
}
