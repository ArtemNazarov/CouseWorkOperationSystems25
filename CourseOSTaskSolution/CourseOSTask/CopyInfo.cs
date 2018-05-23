using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static CourseOSTask.HandleDriveAPI;

namespace CourseOSTask
{
    public class CopyInfo
    {

        public string NeededPath { get; set; }
        public string SelectedDrive { get; set; }

        public void CopyDirs(string fromPath, string toPath)
        {

            CreateDir(toPath);
            foreach (string s1 in Directory.GetFiles(fromPath))
            {
                string s2 = toPath + "\\" + Path.GetFileName(s1);
                CopyFile(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(fromPath))
            {
                CopyDirs(s, toPath + "\\" + Path.GetFileName(s));
            }
        }

        public CopyProgressResult CopyProgressHandler(long total, long transferred, long streamSize, long StreamByteTrans, uint dwStreamNumber, CopyProgressCallbackReason reason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData)
        {
            return CopyProgressResult.PROGRESS_CONTINUE;
        }

        public void CopyFile(string oldFile, string newFile)
        {
            int pbCancel = 0;
            CopyFileEx(oldFile, newFile, new CopyProgressRoutine(this.CopyProgressHandler), IntPtr.Zero, ref pbCancel, CopyFileFlags.COPY_FILE_RESTARTABLE);
        }

        public void CreateDir(string path)
        {
            if (!CreateDirectory(path, null))
            {
                //считываем код текущей ошибки
                var err = Marshal.GetLastWin32Error();
                //если код равен 3, что означает PATH_NOT_FOUND, создаем необходимые для копирования каталоги
                if (err == 3)
                {
                    var catalogs = path.Split('\\');
                    for (int i = 1; i < catalogs.Length - 1; i++)
                    {
                        var resPath = "";
                        for (int j = 0; j <= i; j++)
                        {
                            resPath += catalogs[j] + '\\';
                        }
                        CreateDirectory(resPath, null);
                    }
                    CreateDirectory(path, null);
                }

            }
        }
    }
}
