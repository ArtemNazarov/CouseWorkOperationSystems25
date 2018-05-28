using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask.WinAPI
{
    public class IndexHeaderDir
    {
        /*0x00*/
        //адрес MFT файла
        public ulong IndexedFile { get; set; } 
        /*0x08*/
        //смещение следующего элемента, относительно текущего
        public ushort Length { get; set; }
        /*0x0A*/
        //длина атрибута $FILE_NAME
        public ushort KeyLength { get; set; }
        /*0x0C*/
        //флаги
        public int Flags { get; set; }
        /*0x10*/
        public byte[] FileName { get; set; }
        public string FileNameString { get; set; }
    }
}
