using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;



namespace CourseOSTask
{
    public class HandleDriveAPI
    {
        public const uint GENERIC_READ = 0x80000000;
        public const uint FILE_SHARE_READ = 0x00000001;
        public const uint FILE_SHARE_WRITE = 0x00000002;
        public const uint OPEN_EXISTING = 0x3;
        public const uint IOCTL_DISK_GET_DRIVE_GEOMETRY = 0x70000;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall,
    SetLastError = true)]
        public static extern SafeFileHandle CreateFile(
      string lpFileName,
      uint dwDesiredAccess,
      uint dwShareMode,
      IntPtr SecurityAttributes,
      uint dwCreationDisposition,
      uint dwFlagsAndAttributes,
      IntPtr hTemplateFile
      );

        public enum EMoveMethod : uint
        {
            Begin = 0,
            Current = 1,
            End = 2
        }

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern unsafe uint SetFilePointer(
            [In] SafeFileHandle hFile,
            [In] int lDistanceToMove,
            [Out] int* lpDistanceToMoveHigh,
            [In] EMoveMethod dwMoveMethod);

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern uint SetFilePointer(
            [In] SafeFileHandle hFile,
            [In] int lDistanceToMove,
            [Out] out int lpDistanceToMoveHigh,
            [In] EMoveMethod dwMoveMethod);

        [DllImport(@"kernel32.dll", SetLastError = true)]
        public static extern unsafe bool ReadFile(
            SafeFileHandle hFile,      // handle to file
            byte* pBuffer,        // data buffer, should be fixed
            int NumberOfBytesToRead,  // number of bytes to read
            IntPtr pNumberOfBytesRead,  // number of bytes read, provide IntPtr.Zero here
                                        /*NativeOverlapped**/IntPtr lpOverlapped // should be fixed, if not IntPtr.Zero
            );

        //If the value of SECURITY_ATTRIBUTES is NULL, the object is assigned the default security descriptor associated with the access token of the calling process
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto, BestFitMapping = false)]
        public static extern bool CreateDirectory(String path, SECURITY_ATTRIBUTES lpSecurityAttributes);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFileEx(string lpExistingFileName, string lpNewFileName,
           CopyProgressRoutine lpProgressRoutine, IntPtr lpData, ref Int32 pbCancel,
           CopyFileFlags dwCopyFlags);

        public delegate CopyProgressResult CopyProgressRoutine(
        long TotalFileSize,
        long TotalBytesTransferred,
        long StreamSize,
        long StreamBytesTransferred,
        uint dwStreamNumber,
        CopyProgressCallbackReason dwCallbackReason,
        IntPtr hSourceFile,
        IntPtr hDestinationFile,
        IntPtr lpData);

        private int pbCancel;

        public enum CopyProgressResult : uint
        {
            PROGRESS_CONTINUE = 0,
            PROGRESS_CANCEL = 1,
            PROGRESS_STOP = 2,
            PROGRESS_QUIET = 3
        }

        public enum CopyProgressCallbackReason : uint
        {
            CALLBACK_CHUNK_FINISHED = 0x00000000,
            CALLBACK_STREAM_SWITCH = 0x00000001
        }

        [Flags]
        public enum CopyFileFlags : uint
        {
            COPY_FILE_FAIL_IF_EXISTS = 0x00000001,
            COPY_FILE_RESTARTABLE = 0x00000002,
            COPY_FILE_OPEN_SOURCE_FOR_WRITE = 0x00000004,
            COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 0x00000008
        }

    }
}
