using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPage17
{
    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; }
        public DateTime TimeReached { get; }

        public ThresholdReachedEventArgs(int threshold, DateTime timeReached)
        {
            Threshold = threshold;
            TimeReached = timeReached;
        }
    }

}
