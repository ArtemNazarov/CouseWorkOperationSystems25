using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask.WinAPI
{
    public class Segment
    {
        public ulong Start { get; set; }
        public ulong End { get; set; }


        public Segment()
        {
            Start = 0;
            End = 0;
        }

        public Segment(ulong start, ulong end)
        {
            Start = start;
            End = end;
        }
    }
}
