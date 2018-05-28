using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask
{
    public class Constants
    {
        public const int BYTE_IN_LINE = 16;
        public const int LINE_IN_SECTOR = 32;
        public const int BYTE_IN_SECTOR = 512;
        public const byte SEC_PER_CLUS = 0x0D;
        public const ushort SEC_PER_TRACK = 0x18;
        public const long START_CLUS_MFT = 0x30;
        public const byte CLUS_ON_RECORD_MFT = 0x40;
        public const byte HEX = 16;
    }
}
