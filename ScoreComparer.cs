using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC1
{
    public class ScoreComparer : IComparer<Score>
    {
        public int Compare(Score? x, Score? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;
            return y.Scoring.CompareTo(x.Scoring);
        }
    }
}
