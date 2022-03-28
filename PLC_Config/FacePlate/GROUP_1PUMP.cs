using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class GROUP_1PUMP
    {
        public string Name;
        public ushort Status { get; set; }
        public ushort Time_Total_Minute { get; set; }
        public ushort Time_Total_Second { get; set; }
        public ushort Time_1_Minute { get; set; }
        public ushort Time_1_Second { get; set; }
        public ushort Time_2_Minute { get; set; }
        public ushort Time_2_Second { get; set; }

        public SCADA Parent;
        int Period = 500;
        System.Timers.Timer UpdateTimer = null;
        public GROUP_1PUMP(string name)
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
                case "Group_PAC_KHUAY_BC":
                    switch (tag)
                    {
                        case "Reset":
                            Parent.S7500.Write_PLC("PAC_KHUAY_BC.Set_Reset_Time", value);
                            break;
                        case "Set_Time_Chay":
                            Parent.S7500.Write_PLC("PAC_KHUAY_BC.Set_Time_Chay", value);
                            break;
                        case "Set_Time_Nghi":
                            Parent.S7500.Write_PLC("PAC_KHUAY_BC.Set_Time_Nghi", value);
                            break;
                    }
                    break;

                case "Group_PO_KHUAY_BC":
                    switch (tag)
                    {
                        case "Reset":
                            Parent.S7500.Write_PLC("PO_KHUAY_BC.Set_Reset_Time", value);
                            break;
                        case "Set_Time_Chay":
                            Parent.S7500.Write_PLC("PO_KHUAY_BC.Set_Time_Chay", value);
                            break;
                        case "Set_Time_Nghi":
                            Parent.S7500.Write_PLC("PO_KHUAY_BC.Set_Time_Nghi", value);
                            break;
                    }
                    break;

                case "Group_HL_GATBUN":
                    switch (tag)
                    {
                        case "Reset":
                            Parent.S7500.Write_PLC("HL_GATBUN.Set_Reset_Time", value);
                            break;
                        case "Set_Time_Chay":
                            Parent.S7500.Write_PLC("HL_GATBUN.Set_Time_Chay", value);
                            break;
                        case "Set_Time_Nghi":
                            Parent.S7500.Write_PLC("HL_GATBUN.Set_Time_Nghi", value);
                            break;
                    }
                    break;

                case "Group_SH_GATBUN":
                    switch (tag)
                    {
                        case "Reset":
                            Parent.S7500.Write_PLC("SH_GATBUN.Set_Reset_Time", value);
                            break;
                        case "Set_Time_Chay":
                            Parent.S7500.Write_PLC("SH_GATBUN.Set_Time_Chay", value);
                            break;
                        case "Set_Time_Nghi":
                            Parent.S7500.Write_PLC("SH_GATBUN.Set_Time_Nghi", value);
                            break;
                    }
                    break;
            }
        }


        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Name == "Group_PAC_KHUAY_BC")
            {
                Status = Parent.S7500.Data.PAC_KHUAY_BC_Status;
                Time_Total_Minute = Parent.S7500.Data.PAC_KHUAY_BC_Time_total_min;
                Time_Total_Second = Parent.S7500.Data.PAC_KHUAY_BC_Time_total_sec;
                Time_1_Minute = Parent.S7500.Data.PAC_KHUAY_BC_Run_time_min;
                Time_1_Second = Parent.S7500.Data.PAC_KHUAY_BC_Run_time_sec;
                Time_2_Minute = Parent.S7500.Data.PAC_KHUAY_BC_Stop_time_min;
                Time_2_Second = Parent.S7500.Data.PAC_KHUAY_BC_Stop_time_sec;
            }

            if (Name == "Group_PO_KHUAY_BC")
            {
                Status = Parent.S7500.Data.PO_KHUAY_BC_Status;
                Time_Total_Minute = Parent.S7500.Data.PO_KHUAY_BC_Time_total_min;
                Time_Total_Second = Parent.S7500.Data.PO_KHUAY_BC_Time_total_sec;
                Time_1_Minute = Parent.S7500.Data.PO_KHUAY_BC_Run_time_min;
                Time_1_Second = Parent.S7500.Data.PO_KHUAY_BC_Run_time_sec;
                Time_2_Minute = Parent.S7500.Data.PO_KHUAY_BC_Stop_time_min;
                Time_2_Second = Parent.S7500.Data.PO_KHUAY_BC_Stop_time_sec;
            }

            if (Name == "Group_HL_GATBUN")
            {
                Status = Parent.S7500.Data.HL_GATBUN_Status;
                Time_Total_Minute = Parent.S7500.Data.HL_GATBUN_Time_total_min;
                Time_Total_Second = Parent.S7500.Data.HL_GATBUN_Time_total_sec;
                Time_1_Minute = Parent.S7500.Data.HL_GATBUN_Run_time_min;
                Time_1_Second = Parent.S7500.Data.HL_GATBUN_Run_time_sec;
                Time_2_Minute = Parent.S7500.Data.HL_GATBUN_Stop_time_min;
                Time_2_Second = Parent.S7500.Data.HL_GATBUN_Stop_time_sec;
            }

            if (Name == "Group_SH_GATBUN")
            {
                Status = Parent.S7500.Data.SH_GATBUN_Status;
                Time_Total_Minute = Parent.S7500.Data.SH_GATBUN_Time_total_min;
                Time_Total_Second = Parent.S7500.Data.SH_GATBUN_Time_total_sec;
                Time_1_Minute = Parent.S7500.Data.SH_GATBUN_Run_time_min;
                Time_1_Second = Parent.S7500.Data.SH_GATBUN_Run_time_sec;
                Time_2_Minute = Parent.S7500.Data.SH_GATBUN_Stop_time_min;
                Time_2_Second = Parent.S7500.Data.SH_GATBUN_Stop_time_sec;
            }
        }
    }
}
