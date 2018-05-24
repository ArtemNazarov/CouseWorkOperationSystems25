using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask
{
    public class BPB
    {
        public string Signature;
        public int BytePerSec;
        public byte SectorPerCluster;
        public byte TypeOfDrive;
        public ushort SecPerTrack;
        public ushort NumHeads;
        public long HiddenSec;
        public ulong SecCount;
        public ulong FirstClusterMFT;
        public ulong FirstClusterMirror;
        public int ClustersPerMFT;
        public int ClustertPerIndex;
        public ulong SerialNumber;

        
    }
}
