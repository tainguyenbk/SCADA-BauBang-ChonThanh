using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class PUMP
    {
        public string Name;
        public ushort Status { get; set; }
        public ushort Time_Reamin_Minute { get; set; }
        public ushort Time_Reamin_Second { get; set; }
        public bool Man { get; set; }
        public bool Auto { get; set; }


        //SCADA là parent của PUMP
        public SCADA Parent;
        int Period = 500;
        System.Timers.Timer UpdateTimer = null;
        public PUMP(string name)
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

        //Hàm write device dùng để ghi dữ liệu từ Faceplate xuống class PLC
        public void Write_Device(string tag, object value)
        {
            switch (Name)
            {
                case "ANO_Khuay1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("ANO.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("ANO.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("ANO.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("ANO.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "ANO_Khuay2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("ANO.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("ANO.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("ANO.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("ANO.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "ANO_Khuay3":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("ANO.Set_P3_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("ANO.Set_P3_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("ANO.Set_P3_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("ANO.Set_P3_Manu_Stop", value);
                            break;
                    }
                    break;

                case "ANO_Khuay4":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("ANO.Set_P4_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("ANO.Set_P4_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("ANO.Set_P4_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("ANO.Set_P4_Manu_Stop", value);
                            break;
                    }
                    break;

                case "BND":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("BND.Set_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("BND.Set_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("BND.Set_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("BND.Set_Manu_Stop", value);
                            break;
                    }
                    break;

                case "DH_MTK1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("DH_MTK.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("DH_MTK.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("DH_MTK.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("DH_MTK.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "DH_MTK2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("DH_MTK.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("DH_MTK.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("DH_MTK.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("DH_MTK.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "DH_Pump1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "DH_Pump2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("DH_PUMP.Set_Manu_Stop", value);
                            break;
                    }
                    break;

                case "DLDD_Pump1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("DLDD.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("DLDD.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("DLDD.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("DLDD.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "DLDD_Pump2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("DLDD.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("DLDD.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("DLDD.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("DLDD.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HG_Pump1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HG_Pump2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HG_PUMP.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HK_MTK1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HK_MTK2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HK_MTK3":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P3_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P3_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P3_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P3_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HK_MTK4":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P4_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P4_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P4_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HK_MTK.Set_P4_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HL_GATBUN":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HL_GATBUN.Set_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HL_GATBUN.Set_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HL_GATBUN.Set_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HL_GATBUN.Set_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HL_Pump1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HL_Pump2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HL_PUMP.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HLU_Pump1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HLU.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HLU.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HLU.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HLU.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "HLU_Pump2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("HLU.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("HLU.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("HLU.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("HLU.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "KT_DL_Pump1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "KT_DL_Pump2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("KT_PUMP.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "PAC_BC_Khuay":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("PAC_KHUAY_BC.Set_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("PAC_KHUAY_BC.Set_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("PAC_KHUAY_BC.Set_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("PAC_KHUAY_BC.Set_Manu_Stop", value);
                            break;
                    }
                    break;

                case "PAC_DL_Pump1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "PAC_DL_Pump2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("PAC_PUMP.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "PAC_Khuay":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("PAC_KHUAY.Set_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("PAC_KHUAY.Set_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("PAC_KHUAY.Set_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("PAC_KHUAY.Set_Manu_Stop", value);
                            break;
                    }
                    break;

                case "PO_BC_Khuay":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("PO_KHUAY_BC.Set_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("PO_KHUAY_BC.Set_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("PO_KHUAY_BC.Set_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("PO_KHUAY_BC.Set_Manu_Stop", value);
                            break;
                    }
                    break;

                case "PO_DL_Pump1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "PO_DL_Pump2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("PO_PUMP.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

                case "PO_Khuay":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("PO_KHUAY.Set_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("PO_KHUAY.Set_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("PO_KHUAY.Set_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("PO_KHUAY.Set_Manu_Stop", value);
                            break;
                    }
                    break;

                case "SH_GATBUN":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("SH_GATBUN.Set_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("SH_GATBUN.Set_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("SH_GATBUN.Set_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("SH_GATBUN.Set_Manu_Stop", value);
                            break;
                    }
                    break;

                case "SH_Pump1":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_P1_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_P1_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_P1_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_P1_Manu_Stop", value);
                            break;
                    }
                    break;

                case "SH_Pump2":
                    switch (tag)
                    {
                        case "Auto":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_P2_Auto", value);
                            break;
                        case "Manu":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_P2_Manu", value);
                            break;
                        case "Manu_Run":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_P2_Manu_Run", value);
                            break;
                        case "Manu_Stop":
                            Parent.S7500.Write_PLC("SH_PUMP.Set_P2_Manu_Stop", value);
                            break;
                    }
                    break;

            }
        }

        //Cập nhật dữ liệu từ PLC lên faceplates
        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Name == "ANO_Khuay1")
            {
                Status = Parent.S7500.Data.ANO_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.ANO_KHUAY1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.ANO_KHUAY1_Remain_Second;
                Man = Parent.S7500.Data.ANO_Man_1;
                Auto = Parent.S7500.Data.ANO_Auto_1;
            }
            if (Name == "ANO_Khuay2")
            {
                Status = Parent.S7500.Data.ANO_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.ANO_KHUAY2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.ANO_KHUAY2_Remain_Second;
                Man = Parent.S7500.Data.ANO_Man_2;
                Auto = Parent.S7500.Data.ANO_Auto_2;
            }
            if (Name == "ANO_Khuay3")
            {
                Status = Parent.S7500.Data.ANO_Status_3;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.ANO_KHUAY3_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.ANO_KHUAY3_Remain_Second;
                Man = Parent.S7500.Data.ANO_Man_3;
                Auto = Parent.S7500.Data.ANO_Auto_3;
            }
            if (Name == "ANO_Khuay4")
            {
                Status = Parent.S7500.Data.ANO_Status_4;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.ANO_KHUAY4_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.ANO_KHUAY4_Remain_Second;
                Man = Parent.S7500.Data.ANO_Man_4;
                Auto = Parent.S7500.Data.ANO_Auto_4;
            }

            if (Name == "BND")
            {
                Status = Parent.S7500.Data.BND_Status;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.MNB_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.MNB_Remain_Second;
                Man = Parent.S7500.Data.BND_Man;
                Auto = Parent.S7500.Data.BND_Auto;
            }

            if (Name == "DH_MTK1")
            {
                Status = Parent.S7500.Data.DH_MTK_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.DH_MTK1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.DH_MTK1_Remain_Second;
                Man = Parent.S7500.Data.DH_MTK_Man_1;
                Auto = Parent.S7500.Data.DH_MTK_Auto_1;
            }
            if (Name == "DH_MTK2")
            {
                Status = Parent.S7500.Data.DH_MTK_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.DH_MTK2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.DH_MTK2_Remain_Second;
                Man = Parent.S7500.Data.DH_MTK_Man_2;
                Auto = Parent.S7500.Data.DH_MTK_Auto_2;
            }
            if (Name == "DH_Pump1")
            {
                Status = Parent.S7500.Data.DH_PUMP_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.DH_Pump1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.DH_Pump1_Remain_Second;
                Man = Parent.S7500.Data.DH_PUMP_Man_1;
                Auto = Parent.S7500.Data.DH_PUMP_Auto_1;
            }
            if (Name == "DH_Pump2")
            {
                Status = Parent.S7500.Data.DH_PUMP_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.DH_Pump2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.DH_Pump2_Remain_Second;
                Man = Parent.S7500.Data.DH_PUMP_Man_2;
                Auto = Parent.S7500.Data.DH_PUMP_Auto_2;
            }
            if (Name == "DLDD_Pump1")
            {
                Status = Parent.S7500.Data.DLDD_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.DLDD_Pump1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.DLDD_Pump1_Remain_Second;
                Man = Parent.S7500.Data.DLDD_Man_1;
                Auto = Parent.S7500.Data.DLDD_Auto_1;
            }
            if (Name == "DLDD_Pump2")
            {
                Status = Parent.S7500.Data.DLDD_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.DLDD_Pump2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.DLDD_Pump2_Remain_Second;
                Man = Parent.S7500.Data.DLDD_Man_2;
                Auto = Parent.S7500.Data.DLDD_Auto_2;
            }

            if (Name == "HG_Pump1")
            {
                Status = Parent.S7500.Data.HG_PUMP_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HG_Pump1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HG_Pump1_Remain_Second;
                Man = Parent.S7500.Data.HG_PUMP_Man_1;
                Auto = Parent.S7500.Data.HG_PUMP_Auto_1;
            }

            if (Name == "HG_Pump2")
            {
                Status = Parent.S7500.Data.HG_PUMP_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HG_Pump2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HG_Pump2_Remain_Second;
                Man = Parent.S7500.Data.HG_PUMP_Man_2;
                Auto = Parent.S7500.Data.HG_PUMP_Auto_2;
            }

            if (Name == "HK_MTK1")
            {
                Status = Parent.S7500.Data.HK_MTK_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HK_MTK1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HK_MTK1_Remain_Second;
                Man = Parent.S7500.Data.HK_MTK_Man_1;
                Auto = Parent.S7500.Data.HK_MTK_Auto_1;
            }

            if (Name == "HK_MTK2")
            {
                Status = Parent.S7500.Data.HK_MTK_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HK_MTK2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HK_MTK2_Remain_Second;
                Man = Parent.S7500.Data.HK_MTK_Man_2;
                Auto = Parent.S7500.Data.HK_MTK_Auto_2;
            }

            if (Name == "HK_MTK3")
            {
                Status = Parent.S7500.Data.HK_MTK_Status_3;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HK_MTK3_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HK_MTK3_Remain_Second;
                Man = Parent.S7500.Data.HK_MTK_Man_3;
                Auto = Parent.S7500.Data.HK_MTK_Auto_3;
            }

            //
            if (Name == "HK_MTK4")
            {
                Status = Parent.S7500.Data.HK_MTK_Status_4;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HK_MTK4_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HK_MTK4_Remain_Second;
                Man = Parent.S7500.Data.HK_MTK_Man_4;
                Auto = Parent.S7500.Data.HK_MTK_Auto_4;
            }

            if (Name == "HL_GATBUN")
            {
                Status = Parent.S7500.Data.HL_GATBUN_Status;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HL_GATBUN_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HL_GATBUN_Remain_Second;
                Man = Parent.S7500.Data.HL_GATBUN_Man;
                Auto = Parent.S7500.Data.HL_GATBUN_Auto;
            }

            if (Name == "HL_Pump1")
            {
                Status = Parent.S7500.Data.HL_PUMP_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HL_Pump1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HL_Pump1_Remain_Second;
                Man = Parent.S7500.Data.HL_PUMP_Man_1;
                Auto = Parent.S7500.Data.HL_PUMP_Auto_1;
            }

            if (Name == "HL_Pump2")
            {
                Status = Parent.S7500.Data.HL_PUMP_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HL_Pump2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HL_Pump2_Remain_Second;
                Man = Parent.S7500.Data.HL_PUMP_Man_2;
                Auto = Parent.S7500.Data.HL_PUMP_Auto_2;
            }

            if (Name == "HLU_Pump1")
            {
                Status = Parent.S7500.Data.HLU_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HLU_Pump1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HLU_Pump1_Remain_Second;
                Man = Parent.S7500.Data.HLU_Man_1;
                Auto = Parent.S7500.Data.HLU_Auto_1;
            }

            if (Name == "HLU_Pump2")
            {
                Status = Parent.S7500.Data.HLU_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.HLU_Pump2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.HLU_Pump2_Remain_Second;
                Man = Parent.S7500.Data.HLU_Man_2;
                Auto = Parent.S7500.Data.HLU_Auto_2;
            }

            if (Name == "KT_DL_Pump1")
            {
                Status = Parent.S7500.Data.KT_PUMP_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.KT_DL_Pump1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.KT_DL_Pump1_Remain_Second;
                Man = Parent.S7500.Data.KT_PUMP_Man_1;
                Auto = Parent.S7500.Data.KT_PUMP_Auto_1;
            }

            if (Name == "KT_DL_Pump2")
            {
                Status = Parent.S7500.Data.KT_PUMP_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.KT_DL_Pump2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.KT_DL_Pump2_Remain_Second;
                Man = Parent.S7500.Data.KT_PUMP_Man_2;
                Auto = Parent.S7500.Data.KT_PUMP_Auto_2;
            }

            if (Name == "PAC_BC_Khuay")
            {
                Status = Parent.S7500.Data.PAC_KHUAY_BC_Status;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.PAC_BC_KHUAY_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.PAC_BC_KHUAY_Remain_Minute;
                Man = Parent.S7500.Data.PAC_KHUAY_BC_Man;
                Auto = Parent.S7500.Data.PAC_KHUAY_BC_Auto;
            }

            if (Name == "PAC_DL_Pump1")
            {
                Status = Parent.S7500.Data.PAC_PUMP_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.PAC_DL_Pump1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.PAC_DL_Pump1_Remain_Second;
                Man = Parent.S7500.Data.PAC_PUMP_Man_1;
                Auto = Parent.S7500.Data.PAC_PUMP_Auto_1;
            }

            if (Name == "PAC_DL_Pump2")
            {
                Status = Parent.S7500.Data.PAC_PUMP_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.PAC_DL_Pump2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.PAC_DL_Pump2_Remain_Second;
                Man = Parent.S7500.Data.PAC_PUMP_Man_2;
                Auto = Parent.S7500.Data.PAC_PUMP_Auto_2;
            }

            if (Name == "PAC_Khuay")
            {
                Status = Parent.S7500.Data.PAC_KHUAY_Status;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.PAC_KHUAY_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.PAC_KHUAY_Remain_Second;
                Man = Parent.S7500.Data.PAC_KHUAY_Man;
                Auto = Parent.S7500.Data.PAC_KHUAY_Auto;
            }

            if (Name == "PO_BC_Khuay")
            {
                Status = Parent.S7500.Data.PO_KHUAY_BC_Status;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.PO_BC_KHUAY_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.PO_BC_KHUAY_Remain_Second;
                Man = Parent.S7500.Data.PAC_KHUAY_BC_Man;
                Auto = Parent.S7500.Data.PAC_KHUAY_BC_Auto;
            }

            if (Name == "PO_DL_Pump1")
            {
                Status = Parent.S7500.Data.PO_PUMP_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.PO_DL_Pump1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.PO_DL_Pump1_Remain_Second;
                Man = Parent.S7500.Data.PO_PUMP_Man_1;
                Auto = Parent.S7500.Data.PO_PUMP_Auto_1;
            }

            if (Name == "PO_DL_Pump2")
            {
                Status = Parent.S7500.Data.PO_PUMP_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.PO_DL_Pump2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.PO_DL_Pump2_Remain_Second;
                Man = Parent.S7500.Data.PO_PUMP_Man_2;
                Auto = Parent.S7500.Data.PO_PUMP_Auto_2;
            }

            if (Name == "PO_Khuay")
            {
                Status = Parent.S7500.Data.PO_KHUAY_Status;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.PO_KHUAY_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.PO_KHUAY_Remain_Second;
                Man = Parent.S7500.Data.PO_KHUAY_Man;
                Auto = Parent.S7500.Data.PO_KHUAY_Auto;
            }

            if (Name == "SH_GATBUN")
            {
                Status = Parent.S7500.Data.SH_GATBUN_Status;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.SH_GATBUN_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.SH_GATBUN_Remain_Second;
                Man = Parent.S7500.Data.SH_GATBUN_Man;
                Auto = Parent.S7500.Data.SH_GATBUN_Auto;
            }

            if (Name == "SH_Pump1")
            {
                Status = Parent.S7500.Data.SH_PUMP_Status_1;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.SH_Pump1_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.SH_Pump1_Remain_Second;
                Man = Parent.S7500.Data.SH_PUMP_Man_1;
                Auto = Parent.S7500.Data.SH_PUMP_Auto_1;
            }

            if (Name == "SH_Pump2")
            {
                Status = Parent.S7500.Data.SH_PUMP_Status_2;
                Time_Reamin_Minute = Parent.S7500.Remain_Time.SH_Pump2_Remain_Minute;
                Time_Reamin_Second = Parent.S7500.Remain_Time.SH_Pump2_Remain_Second;
                Man = Parent.S7500.Data.SH_PUMP_Man_2;
                Auto = Parent.S7500.Data.SH_PUMP_Auto_2;
            }
        }
    }
}
