using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask.WinAPI
{
    public class TableView
    {
        private MFTHandle mft;

        [DisplayName("Имя файла")]
        public string FileName => mft.FileName;

        [DisplayName("Номер записи MFT")]
        public string MftNumber => "0x" + mft.MFTRecordNumber.ToString("X4");

        [DisplayName("Отрезки")]
        public string Clusters
        {
            get
            {
                string result = "";
                Attribute data = mft.Attributes.Where(a => a.Type == AttributeTypes.AT_DATA).FirstOrDefault(); //Выбираем атрибут Data
                if (data != null)
                {
                    if (data.NonResidentFlg == 0)
                        result = "Файл резидентный, хранится в MFT";
                    else
                    {
                        foreach (Segment item in data.NotResidentAttr.Clusters) //Для каждого списка кластеров
                        {
                            string startHex = item.Start.ToString("X4");
                            string endHex = item.End.ToString("X4");
                            result += $"0x{startHex} - 0x{endHex}; ";
                        }
                    }
                }

                return result == "" ? "Отсутствует атрибут Data" : result;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="mft">Запись МФТ для отображения</param>
        public TableView(MFTHandle mft)
        {
            this.mft = mft;
        }
    }
}
