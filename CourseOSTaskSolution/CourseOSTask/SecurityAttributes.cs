using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask
{
    [StructLayout(LayoutKind.Sequential)]
    public class SECURITY_ATTRIBUTES
    {
        internal int nLength = 0;
        // don't remove null, or it will fail to set the default ACL, making the folder inaccessible and non-removeable
        // unsafe is available if compile with /unsafe flag, https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0227
        public IntPtr? pSecurityDescriptor = null;
        //or
        //internal unsafe byte* pSecurityDescriptor = null;
        internal int bInheritHandle = 0;
        public IntPtr lpSecurityDescriptor;
    }
}
