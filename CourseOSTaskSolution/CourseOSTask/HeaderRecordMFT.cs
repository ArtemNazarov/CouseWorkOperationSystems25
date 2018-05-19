using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseOSTask
{
    public class HeaderRecordMFT
    {
        public string signature;
        public ushort usa_offs;
        public ushort usa_count;
        public int lsn;
        public ushort sequence_number;
        public ushort link_count;
        public ushort attrs_offset;
        public ushort flags;
        public uint bytes_in_use;
        public uint bytes_allocated;
        public ulong base_mft_record;
        public ushort next_attr_instance;
        public ushort reserved;
        public uint mft_record_number;

        public override string ToString()
        {
            string result = "";

            result += "Сигнатура:" + signature + "\n";
            result += "Смещение массива данных:" + usa_offs.ToString() + "\n";
            result += "Размер в словах номера последовательности обновления:" + usa_count.ToString() + "\n";
            result += "Номер последовательности файла транзакций:" + lsn.ToString() + "\n";
            result += "Номер последовательности:" + sequence_number.ToString() + "\n";
            result += "Счетчик жестких ссылок:" + link_count.ToString() + "\n";
            result += "Смещение первого атрибута:" + attrs_offset.ToString() + "\n";
            result += "Флаги записи:" + flags.ToString() + "\n";
            result += "Реальный размер файловой записи в байтах :" + bytes_in_use.ToString() + "\n";
            result += "Выделенный размер файловой записи:" + bytes_allocated.ToString() + "\n";
            result += "Ссылка на базовую файловую запись:" + base_mft_record.ToString() + "\n";
            result += "Идентификатор следующего атрибута:" + next_attr_instance.ToString() + "\n";
            result += "Индекс данной файловой записи:" + mft_record_number.ToString() + "\n";

            return result;
        }

        public HeaderRecordMFT(byte[] sector)
        {
            signature = "";
            for (int i = 0; i < 4; i++)
                signature += (char)sector[0x00 + i];

            usa_offs = 0;
            for (int i = 0; i < 2; i++)
                usa_offs += (ushort)(sector[0x04 + i] << (i * 8));

            usa_count = 0;
            for (int i = 0; i < 2; i++)
                usa_count += (ushort)(sector[0x06 + i] << (i * 8));

            lsn = 0;
            for (int i = 0; i < 8; i++)
                lsn += sector[0x08 + i] << (i * 8);

            sequence_number = 0;
            for (int i = 0; i < 2; i++)
                sequence_number += (ushort)(sector[0x10 + i] << (i * 8));

            link_count = 0;
            for (int i = 0; i < 2; i++)
                link_count += (ushort)(sector[0x12 + i] << (i * 8));

            attrs_offset = 0;
            for (int i = 0; i < 2; i++)
                attrs_offset += (ushort)(sector[0x14 + i] << (i * 8));

            flags = 0;
            for (int i = 0; i < 2; i++)
                flags += (ushort)(sector[0x16 + i] << (i * 8));

            bytes_in_use = 0;
            for (int i = 0; i < 4; i++)
                bytes_in_use += (uint)sector[0x18 + i] << (i * 8);

            bytes_allocated = 0;
            for (int i = 0; i < 4; i++)
                bytes_allocated += (uint)sector[0x1C + i] << (i * 8);

            base_mft_record = 0;
            for (int i = 0; i < 8; i++)
                base_mft_record += (ulong)sector[0x20 + i] << (i * 8);

            next_attr_instance = 0;
            for (int i = 0; i < 2; i++)
                next_attr_instance += (ushort)(sector[0x28 + i] << (i * 8));

            reserved = 0;
            for (int i = 0; i < 2; i++)
                reserved += (ushort)(sector[0x2A + i] << (i * 8));

            mft_record_number = 0;
            for (int i = 0; i < 4; i++)
                mft_record_number += (uint)sector[0x2C + i] << (i * 8);
        }
    }
}
