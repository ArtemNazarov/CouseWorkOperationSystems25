using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask.WinAPI
{
    public class IndexRoot
    {
        /*0x00*/
        //тип индексируемого атрибута
        public uint Type { get; set; }
        /*0x04*/
        //правило упорядочения в дереве
        public uint CollarationRule { get; set; }
        /*0x08*/
        //размер индексной записи в байтах 
        public uint IndexBlockSize { get; set; }
        /*0x0C*/
        //size of each index block (record) in clusters 
        public byte ClustersPerIndexBlock { get; set; }

        /*0x0D*/
        //unused
        public byte[] Reserved { get; set; }
        /*0x10*/
        //заголовок индексного узла
        public IndexHeader Index { get; set; } 
    }
}
