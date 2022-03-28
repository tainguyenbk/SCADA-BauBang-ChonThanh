using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class GROUP_4MTK
    {
        public string Name;
        public ushort Status_1 { get; set; }
        public ushort Status_2 { get; set; }
        public ushort Status_3 { get; set; }
        public ushort Status_4 { get; set; }
        public ushort Time_total_min_12 { get; set; }
        public ushort Time_total_sec_12 { get; set; }
        public ushort Time_total_min_34 { get; set; }
        public ushort Time_total_sec_34 { get; set; }
        public ushort Time_min_1 { get; set; }
        public ushort Time_sec_1 { get; set; }
        public ushort Time_min_2 { get; set; }
        public ushort Time_sec_2 { get; set; }
        public ushort Time_min_3 { get; set; }
        public ushort Time_sec_3 { get; set; }
        public ushort Time_min_4 { get; set; }
        public ushort Time_sec_4 { get; set; }
        public ushort CurrentTime_run { get; set; }
        public ushort CurrentTime_stop { get; set; }
        public ushort CurrentTime_delay { get; set; }


        public SCADA Parent;
        int Period = 500;
        System.Timers.Timer UpdateTimer = null;

        public GROUP_4MTK(string name)
        {
            Name = name;
        }

        public void Write_Device(string tag,object value)
        {
            switch (Name)
            {
                case "Group_HK_MTK":
                    switch (tag)
                    {
                        case "SET_TRUN":
                            Parent.S7500.Write_PLC("HK_MTK.Set_Time_Chay",value);

                            break;
                        case "SET_TSTOP":

                            Parent.S7500.Write_PLC("HK_MTK.Set_Time_Nghi", value);
                            break;
                        case "SET_TDELAY":

                            Parent.S7500.Write_PLC("HK_MTK.Set_Delay_Time", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("HK_MTK.Set_Reset_Time", value);
                            break;
                    }
                    break;
            }
        }


        public void Engine()
        {
            UpdateTimer = new System.Timers.Timer(Period);
            UpdateTimer.AutoReset = true;
            UpdateTimer.Elapsed += UpdateTimer_Elapsed; ;
            UpdateTimer.Start();
        }

        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Name == "Group_HK_MTK")
            {
                Status_1 = Parent.S7500.Data.HK_MTK_Status_1;
                Status_2 = Parent.S7500.Data.HK_MTK_Status_2;
                Status_3 = Parent.S7500.Data.HK_MTK_Status_3;
                Status_4 = Parent.S7500.Data.HK_MTK_Status_4;
                Time_total_min_12 = Parent.S7500.Data.HK_MTK_Time_total_min_12;
                Time_total_sec_12 = Parent.S7500.Data.HK_MTK_Time_total_sec_12;
                Time_total_min_34 = Parent.S7500.Data.HK_MTK_Time_total_min_34;
                Time_total_sec_34 = Parent.S7500.Data.HK_MTK_Time_total_sec_34;
                Time_min_1 = Parent.S7500.Data.HK_MTK_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.HK_MTK_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.HK_MTK_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.HK_MTK_Time_sec_2;
                Time_min_3 = Parent.S7500.Data.HK_MTK_Time_min_3;
                Time_sec_3 = Parent.S7500.Data.HK_MTK_Time_sec_3;
                Time_min_4 = Parent.S7500.Data.HK_MTK_Time_min_4;
                Time_sec_4 = Parent.S7500.Data.HK_MTK_Time_sec_4;
                CurrentTime_run = Parent.S7500.Data.HK_MTK_Time_chay;
                CurrentTime_stop = Parent.S7500.Data.HK_MTK_Time_nghi;
                CurrentTime_delay = Parent.S7500.Data.HK_MTK_Delay;

            }
        }
    }
}
