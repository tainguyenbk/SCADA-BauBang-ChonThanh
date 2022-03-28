using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class GROUP_2PUMP
    {
        public string Name;
        public ushort Status_1 { get; set; }
        public ushort Status_2 { get; set; }
        public ushort Time_total_min { get; set; }
        public ushort Time_total_sec { get; set; }
        public ushort Time_min_1 { get; set; }
        public ushort Time_sec_1 { get; set; }
        public ushort Time_min_2 { get; set; }
        public ushort Time_sec_2 { get; set; }

        public ushort CRV_TIMELP { get; set; }

        public SCADA Parent;
        int Period = 500;
        System.Timers.Timer UpdateTimer = null;

        public GROUP_2PUMP(string name)
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
                case "Group_DH_PUMP":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_Time_Luan_Phien",value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_Reset_Time", value);
                            break;
                    }
                    break;
                case "Group_HG_PUMP":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_Reset_Time", value);
                            break;
                    }
                    break;

                case "Group_DH_MTK":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("DH_MTK.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("DH_MTK.Set_Reset_Time", value);
                            break;
                    }
                    break;

                case "Group_PAC_PUMP":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_Reset_Time", value);
                            break;
                    }
                    break;

                case "Group_PO_PUMP":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_Reset_Time", value);
                            break;
                    }
                    break;

                case "Group_DLDD":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("DLDD.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("DLDD.Set_Reset_Time", value);
                            break;
                    }
                    break;

                case "Group_KT_PUMP":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_Reset_Time", value);
                            break;
                    }
                    break;

                case "Group_HLU":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("HLU.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("HLU.Set_Reset_Time", value);
                            break;
                    }
                    break;

                case "Group_HL_PUMP":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_Reset_Time", value);
                            break;
                    }
                    break;

                case "Group_SH_PUMP":
                    switch (tag)
                    {
                        case "SET_TIME_LP":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_Time_Luan_Phien", value);
                            break;
                        case "RESET":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_Reset_Time", value);
                            break;
                    }
                    break;
            }
        }


        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Name == "Group_DH_PUMP")
            {
                Status_1 = Parent.S7500.Data.DH_PUMP_Status_1;
                Status_2 = Parent.S7500.Data.DH_PUMP_Status_2;
                Time_total_min = Parent.S7500.Data.DH_PUMP_Time_total_min;
                Time_total_sec = Parent.S7500.Data.DH_PUMP_Time_total_sec;
                Time_min_1 = Parent.S7500.Data.DH_PUMP_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.DH_PUMP_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.DH_PUMP_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.DH_PUMP_Time_sec_2;
                CRV_TIMELP = Parent.S7500.Data.DH_PUMP_Time_LP;
            }

            if (Name == "Group_HG_PUMP")
            {
                Status_1 = Parent.S7500.Data.HG_PUMP_Status_1;
                Status_2 = Parent.S7500.Data.HG_PUMP_Status_2;
                Time_total_min = Parent.S7500.Data.HG_PUMP_Time_total_min;
                Time_total_sec = Parent.S7500.Data.HG_PUMP_Time_total_sec;
                Time_min_1 = Parent.S7500.Data.HG_PUMP_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.HG_PUMP_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.HG_PUMP_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.HG_PUMP_Time_sec_2;
                CRV_TIMELP = Parent.S7500.Data.HG_PUMP_Time_LP;
            }

            if (Name == "Group_DH_MTK")
            {
                Status_1 = Parent.S7500.Data.DH_MTK_Status_1;
                Status_2 = Parent.S7500.Data.DH_MTK_Status_2;
                Time_total_min = Parent.S7500.Data.DH_MTK_Time_total_min;
                Time_total_sec = Parent.S7500.Data.DH_MTK_Time_total_sec;
                Time_min_1 = Parent.S7500.Data.DH_MTK_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.DH_MTK_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.DH_MTK_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.DH_MTK_Time_sec_2;
                CRV_TIMELP = Parent.S7500.Data.DH_MTK_Time_LP;
            }

            if (Name == "Group_PAC_PUMP")
            {
                Status_1 = Parent.S7500.Data.PAC_PUMP_Status_1;
                Status_2 = Parent.S7500.Data.PAC_PUMP_Status_2;
                Time_total_min = Parent.S7500.Data.PAC_PUMP_Time_total_min;
                Time_total_sec = Parent.S7500.Data.PAC_PUMP_Time_total_sec;
                Time_min_1 = Parent.S7500.Data.PAC_PUMP_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.PAC_PUMP_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.PAC_PUMP_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.PAC_PUMP_Time_sec_2;
                CRV_TIMELP = Parent.S7500.Data.PAC_PUMP_Time_LP;
            }

            if (Name == "Group_PO_PUMP")
            {
                Status_1 = Parent.S7500.Data.PO_PUMP_Status_1;
                Status_2 = Parent.S7500.Data.PO_PUMP_Status_2;
                Time_total_min = Parent.S7500.Data.PO_PUMP_Time_total_min;
                Time_total_sec = Parent.S7500.Data.PO_PUMP_Time_total_sec;
                Time_min_1 = Parent.S7500.Data.PO_PUMP_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.PO_PUMP_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.PO_PUMP_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.PO_PUMP_Time_sec_2;
                CRV_TIMELP = Parent.S7500.Data.PO_PUMP_Time_LP;
            }

            if (Name == "Group_DLDD")
            {
                Status_1 = Parent.S7500.Data.DLDD_Status_1;
                Status_2 = Parent.S7500.Data.DLDD_Status_2;
                Time_total_min = Parent.S7500.Data.DLDD_Time_total_min;
                Time_total_sec = Parent.S7500.Data.DLDD_Time_total_sec;
                Time_min_1 = Parent.S7500.Data.DLDD_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.DLDD_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.DLDD_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.DLDD_Time_sec_2;
                CRV_TIMELP = Parent.S7500.Data.DLDD_Time_LP;
            }

            if (Name == "Group_KT_PUMP")
            {
                Status_1 = Parent.S7500.Data.KT_PUMP_Status_1;
                Status_2 = Parent.S7500.Data.KT_PUMP_Status_2;
                Time_total_min = Parent.S7500.Data.KT_PUMP_Time_total_min;
                Time_total_sec = Parent.S7500.Data.KT_PUMP_Time_total_sec;
                Time_min_1 = Parent.S7500.Data.KT_PUMP_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.KT_PUMP_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.KT_PUMP_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.KT_PUMP_Time_sec_2;
                CRV_TIMELP = Parent.S7500.Data.KT_PUMP_Time_LP;
            }

            if (Name == "Group_HLU")
            {
                Status_1 = Parent.S7500.Data.HLU_Status_1;
                Status_2 = Parent.S7500.Data.HLU_Status_2;
                Time_total_min = Parent.S7500.Data.HLU_Time_total_min;
                Time_total_sec = Parent.S7500.Data.HLU_Time_total_sec;
                Time_min_1 = Parent.S7500.Data.HLU_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.HLU_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.HLU_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.HLU_Time_sec_2;
                CRV_TIMELP = Parent.S7500.Data.HLU_Time_LP;
            }

            if (Name == "Group_HL_PUMP")
            {
                Status_1 = Parent.S7500.Data.HL_PUMP_Status_1;
                Status_2 = Parent.S7500.Data.HL_PUMP_Status_2;
                Time_total_min = Parent.S7500.Data.HL_PUMP_Time_total_min;
                Time_total_sec = Parent.S7500.Data.HL_PUMP_Time_total_sec;
                Time_min_1 = Parent.S7500.Data.HL_PUMP_Time_min_1;
                Time_sec_1 = Parent.S7500.Data.HL_PUMP_Time_sec_1;
                Time_min_2 = Parent.S7500.Data.HL_PUMP_Time_min_2;
                Time_sec_2 = Parent.S7500.Data.HL_PUMP_Time_sec_2;
                CRV_TIMELP = Parent.S7500.Data.HG_PUMP_Time_LP;
            }
        }
    }
}
