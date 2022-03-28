using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class TAG
    {
        //TAG đọc từ PLC lên bao gồm tag name/ tag address/ tag value và tag timestamp nếu dùng OPC UA
        public string Name;
        public string Address;
        public object Value;
        public DateTime TimeStamp;

        //Lấy TASK làm Parent của TAG
        public TASK Parent;

        //Khai báo tag name và tag address khi tạo mới một tag
        public TAG(string name, string add)
        {
            Name = name;
            Address = add;
        }
    }
}
