using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class GROUP_4PUMP
    {
        public string Name;
        public ushort Status_1 { get; set; }
        public ushort Status_2 { get; set; }
        public ushort Status_3 { get; set; }
        public ushort Status_4 { get; set; }
        public ushort Time_total_min { get; set; }
        public ushort Time_total_sec { get; set; }
        public ushort Time_min_13 { get; set; }
        public ushort Time_sec_13 { get; set; }
        public ushort Time_min_24 { get; set; }
        public ushort Time_sec_24 { get; set; }
        public ushort TimeLP { get; set; }

        public SCADA Parent;
        int Period = 500;
        System.Timers.Timer UpdateTimer = null;

        public GROUP_4PUMP(string name)
        {
            Name = name;
        }

        public void Engine()
        {
            UpdateTimer = new System.Timers.Timer(Period);
            UpdateTimer.AutoReset = true;
            UpdateTimer.Elapsed += UpdateTimer_Elapsed;
            UpdateTimer.Start();
        }

        public void Write_Device(string tag, object value)
        {
            switch (Name)
            {
                case "Group_ANO":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("ANO.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("ANO.Set_Reset_Time", value);
                            break;
                    }
                    break;
            }
        }


        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Name == "Group_ANO")
            {
                Status_1 = Parent.S7500.Data.ANO_Status_1;
                Status_2 = Parent.S7500.Data.ANO_Status_2;
                Status_3 = Parent.S7500.Data.ANO_Status_3;
                Status_4 = Parent.S7500.Data.ANO_Status_4;
                Time_total_min = Parent.S7500.Data.ANO_Time_total_min;
                Time_total_sec = Parent.S7500.Data.ANO_Time_total_sec;
                Time_min_13 = Parent.S7500.Data.ANO_Time_min_13;
                Time_sec_13 = Parent.S7500.Data.ANO_Time_sec_13;
                Time_min_24 = Parent.S7500.Data.ANO_Time_min_24;
                Time_sec_24 = Parent.S7500.Data.ANO_Time_sec_24;
                TimeLP = Parent.S7500.Data.ANO_Time_LP;
            }
        }
    }
}
