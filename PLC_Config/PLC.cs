using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using DataBlock;
using PLC_Config;

namespace PLC_Config
{
    public class PLC
    {
        public string IPAddress;
        public short Rack;
        public short Slot;
        public CpuType PLCType;
        public int Period;
        //Timre dể đọc từ PLC
        System.Timers.Timer ReadPLCTimer = new System.Timers.Timer();
        public Plc thePLC;
        //SCADA là parent của PLC
        public SCADA Parent;
        public DB_DATA Data = new DB_DATA();
        public DB_REMAIN_TIME Remain_Time = new DB_REMAIN_TIME();
        public DB_Alarm Alarm = new DB_Alarm();

        public PLC(string ip, short rack, short slot, int UpdatePeriod)
        {
            PLCType = CpuType.S71500;
            IPAddress = ip;
            Rack = rack;
            Slot = slot;
            Period = UpdatePeriod;
            thePLC = new Plc(PLCType, IPAddress, Rack, Slot);
            try
            {
                thePLC.Open();
            }
            catch
            {
                Console.WriteLine("Error when open PLC Pls check connection");
            }
            ReadPLCTimer.Interval = Period;
            ReadPLCTimer.Elapsed += ReadPLCTimer_Elapsed;
            ReadPLCTimer.Start();

            //TestUpdatePLC.Interval = 100;
            //TestUpdatePLC.Elapsed += TestUpdatePLC_Elapsed;
            //TestUpdatePLC.Start();


        }

        public static int i = 0;
        //đọc luân phiên để giảm tải cho PLC
        private void TestUpdatePLC_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            i = i+1;
            if (i == 1)
            {

            }
            else if (i == 2)
            {

            }
            else if (i == 3)
            {

            }
            else if (i == 4)
            {

            }
            else if (i == 5)
            {
                i = 0;
            }
            Console.WriteLine(i);
        }

        //Hàm dùng để ghi xuống PLC theo địa chỉ
        public void Write_PLC(string name, object value)
        {
            switch (name)
            {
                //HG_PUMP
                case "HG_PUMP.Set_Time_Luan_Phien":
                    thePLC.Write("DB4.DBW2", value);
                    break;
                case "HG_PUMP.Set_Reset_Time":
                    thePLC.Write("DB4.DBX4.0", value);
                    break;
                case "HG_PUMP.Set_P1_Auto":
                    thePLC.Write("DB4.DBX4.1", (bool)value);
                    break;
                case "HG_PUMP.Set_P1_Manu":
                    thePLC.Write("DB4.DBX4.2", (bool)value);
                    break;
                case "HG_PUMP.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX4.3", (bool)value);
                    break;
                case "HG_PUMP.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX4.4", (bool)value);
                    break;
                case "HG_PUMP.Set_P2_Auto":
                    thePLC.Write("DB4.DBX4.5", value);
                    break;
                case "HG_PUMP.Set_P2_Manu":
                    thePLC.Write("DB4.DBX4.6", value);
                    break;
                case "HG_PUMP.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX4.7", value);
                    break;
                case "HG_PUMP.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX5.0", value);
                    break;
                ///
                //DH PUMP

                case "DH_PUMP.Set_Time_Luan_Phien":
                    thePLC.Write("DB4.DBW30", value);
                    break;
                case "DH_PUMP.Set_Reset_Time":
                    thePLC.Write("DB4.DBX32.0", value);
                    break;
                case "DH_PUMP.Set_P1_Auto":
                    thePLC.Write("DB4.DBX32.1", value);
                    break;
                case "DH_PUMP.Set_P1_Manu":
                    thePLC.Write("DB4.DBX32.2", value);
                    break;
                case "DH_PUMP.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX32.3", value);
                    break;
                case "DH_PUMP.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX32.4", value);
                    break;
                case "DH_PUMP.Set_P2_Auto":
                    thePLC.Write("DB4.DBX32.5", value);
                    break;
                case "DH_PUMP.Set_P2_Manu":
                    thePLC.Write("DB4.DBX32.6", value);
                    break;
                case "DH_PUMP.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX32.7", value);
                    break;
                case "DH_PUMP.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX33.0", value);
                    break;
                ///
                //DH MTK
                case "DH_MTK.Set_Time_Luan_Phien":
                    thePLC.Write("DB4.DBW58", value);
                    break;
                case "DH_MTK.Set_Reset_Time":
                    thePLC.Write("DB4.DBX60.0", value);
                    break;
                case "DH_MTK.Set_P1_Auto":
                    thePLC.Write("DB4.DBX60.1", value);
                    break;
                case "DH_MTK.Set_P1_Manu":
                    thePLC.Write("DB4.DBX60.2", value);
                    break;
                case "DH_MTK.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX60.3", value);
                    break;
                case "DH_MTK.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX60.4", value);
                    break;
                case "DH_MTK.Set_P2_Auto":
                    thePLC.Write("DB4.DBX60.5", value);
                    break;
                case "DH_MTK.Set_P2_Manu":
                    thePLC.Write("DB4.DBX60.6", value);
                    break;
                case "DH_MTK.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX60.7", value);
                    break;
                case "DH_MTK.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX61.0", value);
                    break;

                //PAC KHUAY
                case "PAC_KHUAY.Set_Auto":
                    thePLC.Write("DB4.DBX82.0", value);
                    break;
                case "PAC_KHUAY.Set_Manu":
                    thePLC.Write("DB4.DBX82.1", value);
                    break;
                case "PAC_KHUAY.Set_Manu_Run":
                    thePLC.Write("DB4.DBX82.2", value);
                    break;
                case "PAC_KHUAY.Set_Manu_Stop":
                    thePLC.Write("DB4.DBX82.3", value);
                    break;

                //PAC KHUAY BC
                case "PAC_KHUAY_BC.Set_Time_Chay":
                    thePLC.Write("DB4.DBX90.0", value);
                    break;
                case "PAC_KHUAY_BC.Set_Time_Nghi":
                    thePLC.Write("DB4.DBX92.0", value);
                    break;
                case "PAC_KHUAY_BC.Set_Reset_Time":
                    thePLC.Write("DB4.DBX94.0", value);
                    break;
                case "PAC_KHUAY_BC.Set_Auto":
                    thePLC.Write("DB4.DBX94.1", value);
                    break;
                case "PAC_KHUAY_BC.Set_Manu":
                    thePLC.Write("DB4.DBX94.2", value);
                    break;
                case "PAC_KHUAY_BC.Set_Manu_Run":
                    thePLC.Write("DB4.DBX94.3", value);
                    break;
                case "PAC_KHUAY_BC.Set_Manu_Stop":
                    thePLC.Write("DB4.DBX94.4", value);
                    break;

                //PAC PUMP
                case "PAC_PUMP.Set_Time_Luan_Phien":
                    thePLC.Write("DB4.DBW114", value);
                    break;
                case "PAC_PUMP.Set_Reset_Time":
                    thePLC.Write("DB4.DBX116.0", value);
                    break;
                case "PAC_PUMP.Set_P1_Auto":
                    thePLC.Write("DB4.DBX116.1", value);
                    break;
                case "PAC_PUMP.Set_P1_Manu":
                    thePLC.Write("DB4.DBX116.2", value);
                    break;
                case "PAC_PUMP.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX116.3", value);
                    break;
                case "PAC_PUMP.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX116.4", value);
                    break;
                case "PAC_PUMP.Set_P2_Auto":
                    thePLC.Write("DB4.DBX116.5", value);
                    break;
                case "PAC_PUMP.Set_P2_Manu":
                    thePLC.Write("DB4.DBX116.6", value);
                    break;
                case "PAC_PUMP.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX116.7", value);
                    break;
                case "PAC_PUMP.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX117.0", value);
                    break;
                //PO PUMP
                case "PO_PUMP.Set_Time_Luan_Phien":
                    thePLC.Write("DB4.DBW170", value);
                    break;
                case "PO_PUMP.Set_Reset_Time":
                    thePLC.Write("DB4.DBX172.0", value);
                    break;
                case "PO_PUMP.Set_P1_Auto":
                    thePLC.Write("DB4.DBX172.1", value);
                    break;
                case "PO_PUMP.Set_P1_Manu":
                    thePLC.Write("DB4.DBX172.2", value);
                    break;
                case "PO_PUMP.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX172.3", value);
                    break;
                case "PO_PUMP.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX172.4", value);
                    break;
                case "PO_PUMP.Set_P2_Auto":
                    thePLC.Write("DB4.DBX172.5", value);
                    break;
                case "PO_PUMP.Set_P2_Manu":
                    thePLC.Write("DB4.DBX172.6", value);
                    break;
                case "PO_PUMP.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX172.7", value);
                    break;
                case "PO_PUMP.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX173.0", value);
                    break;

                //DLDD
                case "DLDD.Set_Time_Luan_Phien":
                    thePLC.Write("DB4.DBW336", value);
                    break;
                case "DLDD.Set_Reset_Time":
                    thePLC.Write("DB4.DBX338.0", value);
                    break;
                case "DLDD.Set_P1_Auto":
                    thePLC.Write("DB4.DBX338.1", value);
                    break;
                case "DLDD.Set_P1_Manu":
                    thePLC.Write("DB4.DBX338.2", value);
                    break;
                case "DLDD.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX338.3", value);
                    break;
                case "DLDD.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX338.4", value);
                    break;
                case "DLDD.Set_P2_Auto":
                    thePLC.Write("DB4.DBX338.5", value);
                    break;
                case "DLDD.Set_P2_Manu":
                    thePLC.Write("DB4.DBX338.6", value);
                    break;
                case "DLDD.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX338.7", value);
                    break;
                case "DLDD.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX339.0", value);
                    break;

                //HLU

                case "HLU.Set_Time_Luan_Phien":
                    thePLC.Write("DB4.DBW362", value);
                    break;
                case "HLU.Set_Reset_Time":
                    thePLC.Write("DB4.DBX364.0", value);
                    break;
                case "HLU.Set_P1_Auto":
                    thePLC.Write("DB4.DBX364.1", value);
                    break;
                case "HLU.Set_P1_Manu":
                    thePLC.Write("DB4.DBX364.2", value);
                    break;
                case "HLU.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX364.3", value);
                    break;
                case "HLU.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX364.4", value);
                    break;
                case "HLU.Set_P2_Auto":
                    thePLC.Write("DB4.DBX364.5", value);
                    break;
                case "HLU.Set_P2_Manu":
                    thePLC.Write("DB4.DBX364.6", value);
                    break;
                case "HLU.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX364.7", value);
                    break;
                case "HLU.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX365.0", value);
                    break;

                //KT PUMP
                case "KT_PUMP.Set_Time_Luan_Phien":
                    thePLC.Write("DB4.DBW440", value);
                    break;
                case "KT_PUMP.Set_Reset_Time":
                    thePLC.Write("DB4.DBX442.0", value);
                    break;
                case "KT_PUMP.Set_P1_Auto":
                    thePLC.Write("DB4.DBX442.1", value);
                    break;
                case "KT_PUMP.Set_P1_Manu":
                    thePLC.Write("DB4.DBX442.2", value);
                    break;
                case "KT_PUMP.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX442.3", value);
                    break;
                case "KT_PUMP.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX442.4", value);
                    break;
                case "KT_PUMP.Set_P2_Auto":
                    thePLC.Write("DB4.DBX442.5", value);
                    break;
                case "KT_PUMP.Set_P2_Manu":
                    thePLC.Write("DB4.DBX442.6", value);
                    break;
                case "KT_PUMP.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX442.7", value);
                    break;
                case "KT_PUMP.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX443.0", value);
                    break;

                //PAC KHUAY

                //case "PAC_KHUAY.Set_Auto":
                //    thePLC.Write("DB4.DBX82.0", value);
                //    break;
                //case "PAC_KHUAY.Set_Manu":
                //    thePLC.Write("DB4.DBX82.1", value);
                //    break;
                //case "PAC_KHUAY.Set_Manu_Run":
                //    thePLC.Write("DB4.DBX82.2", value);
                //    break;
                //case "PAC_KHUAY.Set_Manu_Stop":
                //    thePLC.Write("DB4.DBX82.3", value);
                //    break;
                //PO KHUAY
                case "PO_KHUAY.Set_Auto":
                    thePLC.Write("DB4.DBX138.0", value);
                    break;
                case "PO_KHUAY.Set_Manu":
                    thePLC.Write("DB4.DBX138.1", value);
                    break;
                case "PO_KHUAY.Set_Manu_Run":
                    thePLC.Write("DB4.DBX138.2", value);
                    break;
                case "PO_KHUAY.Set_Manu_Stop":
                    thePLC.Write("DB4.DBX138.3", value);
                    break;

                //BND
                case "BND.Set_Auto":
                    thePLC.Write("DB4.DBX464.0", value);
                    break;
                case "BND.Set_Manu":
                    thePLC.Write("DB4.DBX464.1", value);
                    break;
                case "BND.Set_Manu_Run":
                    thePLC.Write("DB4.DBX464.2", value);
                    break;
                case "BND.Set_Manu_Stop":
                    thePLC.Write("DB4.DBX464.3", value);
                    break;

                //PAC KHUAY PC

                //case "PAC_KHUAY_BC.Set_Time_Chay":
                //    thePLC.Write("DB4.DBW90.0", value);
                //    break;
                //case "PAC_KHUAY_BC.Set_Time_Nghi":
                //    thePLC.Write("DB4.DBW92.0", value);
                //    break;
                //case "PAC_KHUAY_BC.Set_Reset_Time":
                //    thePLC.Write("DB4.DBX94.0", value);
                //    break;
                //case "PAC_KHUAY_BC.Set_Auto":
                //    thePLC.Write("DB4.DBX94.1", value);
                //    break;
                //case "PAC_KHUAY_BC.Set_Manu":
                //    thePLC.Write("DB4.DBX94.2", value);
                //    break;
                //case "PAC_KHUAY_BC.Set_Manu_Run":
                //    thePLC.Write("DB4.DBX94.3", value);
                //    break;
                //case "PAC_KHUAY_BC.Set_Manu_Stop":
                //    thePLC.Write("DB4.DBX94.4", value);
                //    break;

                //PO KHUAY BC
                case "PO_KHUAY_BC.Set_Time_Chay":
                    thePLC.Write("DB4.DBW146.0", value);
                    break;
                case "PO_KHUAY_BC.Set_Time_Nghi":
                    thePLC.Write("DB4.DBW148.0", value);
                    break;
                case "PO_KHUAY_BC.Set_Reset_Time":
                    thePLC.Write("DB4.DBX150.0", value);
                    break;
                case "PO_KHUAY_BC.Set_Auto":
                    thePLC.Write("DB4.DBX150.1", value);
                    break;
                case "PO_KHUAY_BC.Set_Manu":
                    thePLC.Write("DB4.DBX150.2", value);
                    break;
                case "PO_KHUAY_BC.Set_Manu_Run":
                    thePLC.Write("DB4.DBX150.3", value);
                    break;
                case "PO_KHUAY_BC.Set_Manu_Stop":
                    thePLC.Write("DB4.DBX150.4", value);
                    break;

                //HL GAT BUN

                case "HL_GATBUN.Set_Time_Chay":
                    thePLC.Write("DB4.DBW196.0", value);
                    break;
                case "HL_GATBUN.Set_Time_Nghi":
                    thePLC.Write("DB4.DBW198.0", value);
                    break;
                case "HL_GATBUN.Set_Reset_Time":
                    thePLC.Write("DB4.DBX200.0", value);
                    break;
                case "HL_GATBUN.Set_Auto":
                    thePLC.Write("DB4.DBX200.1", value);
                    break;
                case "HL_GATBUN.Set_Manu":
                    thePLC.Write("DB4.DBX200.2", value);
                    break;
                case "HL_GATBUN.Set_Manu_Run":
                    thePLC.Write("DB4.DBX200.3", value);
                    break;
                case "HL_GATBUN.Set_Manu_Stop":
                    thePLC.Write("DB4.DBX200.4", value);
                    break;
                //SH GAT BUN

                case "SH_GATBUN.Set_Time_Chay":
                    thePLC.Write("DB4.DBW388.0", value);
                    break;
                case "SH_GATBUN.Set_Time_Nghi":
                    thePLC.Write("DB4.DBW390.0", value);
                    break;
                case "SH_GATBUN.Set_Reset_Time":
                    thePLC.Write("DB4.DBX392.0", value);
                    break;
                case "SH_GATBUN.Set_Auto":
                    thePLC.Write("DB4.DBX392.1", value);
                    break;
                case "SH_GATBUN.Set_Manu":
                    thePLC.Write("DB4.DBX392.2", value);
                    break;
                case "SH_GATBUN.Set_Manu_Run":
                    thePLC.Write("DB4.DBX392.3", value);
                    break;
                case "SH_GATBUN.Set_Manu_Stop":
                    thePLC.Write("DB4.DBX392.4", value);
                    break;

                //HL PUMP
                case "HL_PUMP.Set_Time_Chay":
                    thePLC.Write("DB4.DBW220.0", value);
                    break;
                case "HL_PUMP.Set_Time_Nghi":
                    thePLC.Write("DB4.DBW222.0", value);
                    break;
                case "HL_PUMP.Set_Reset_Time":
                    thePLC.Write("DB4.DBX224.0", value);
                    break;
                case "HL_PUMP.Set_P1_Auto":
                    thePLC.Write("DB4.DBX224.1", value);
                    break;
                case "HL_PUMP.Set_P1_Manu":
                    thePLC.Write("DB4.DBX224.2", value);
                    break;
                case "HL_PUMP.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX224.3", value);
                    break;
                case "HL_PUMP.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX224.4", value);
                    break;
                case "HL_PUMP.Set_P2_Auto":
                    thePLC.Write("DB4.DBX224.5", value);
                    break;
                case "HL_PUMP.Set_P2_Manu":
                    thePLC.Write("DB4.DBX224.6", value);
                    break;
                case "HL_PUMP.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX224.7", value);
                    break;
                case "HL_PUMP.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX225.0", value);
                    break;

                //HL PUMP
                case "SH_PUMP.Set_Time_Chay":
                    thePLC.Write("DB4.DBW412.0", value);
                    break;
                case "SH_PUMP.Set_Time_Nghi":
                    thePLC.Write("DB4.DBW414.0", value);
                    break;
                case "SH_PUMP.Set_Reset_Time":
                    thePLC.Write("DB4.DBX416.0", value);
                    break;
                case "SH_PUMP.Set_P1_Auto":
                    thePLC.Write("DB4.DBX416.1", value);
                    break;
                case "SH_PUMP.Set_P1_Manu":
                    thePLC.Write("DB4.DBX416.2", value);
                    break;
                case "SH_PUMP.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX416.3", value);
                    break;
                case "SH_PUMP.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX416.4", value);
                    break;
                case "SH_PUMP.Set_P2_Auto":
                    thePLC.Write("DB4.DBX416.5", value);
                    break;
                case "SH_PUMP.Set_P2_Manu":
                    thePLC.Write("DB4.DBX416.6", value);
                    break;
                case "SH_PUMP.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX416.7", value);
                    break;
                case "SH_PUMP.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX417.0", value);
                    break;

                //ANO

                case "ANO.Set_Time_Luan_Phien":
                    thePLC.Write("DB4.DBW248.0", value);
                    break;
                case "ANO.Set_Reset_Time":
                    thePLC.Write("DB4.DBX250.0", value);
                    break;
                case "ANO.Set_P1_Auto":
                    thePLC.Write("DB4.DBX250.1", value);
                    break;
                case "ANO.Set_P1_Manu":
                    thePLC.Write("DB4.DBX250.2", value);
                    break;
                case "ANO.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX250.3", value);
                    break;
                case "ANO.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX250.4", value);
                    break;
                case "ANO.Set_P2_Auto":
                    thePLC.Write("DB4.DBX250.5", value);
                    break;
                case "ANO.Set_P2_Manu":
                    thePLC.Write("DB4.DBX250.6", value);
                    break;
                case "ANO.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX250.7", value);
                    break;
                case "ANO.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX251.0", value);
                    break;
                case "ANO.Set_P3_Auto":
                    thePLC.Write("DB4.DBX251.1", value);
                    break;
                case "ANO.Set_P3_Manu":
                    thePLC.Write("DB4.DBX251.2", value);
                    break;
                case "ANO.Set_P3_Manu_Run":
                    thePLC.Write("DB4.DBX251.3", value);
                    break;
                case "ANO.Set_P3_Manu_Stop":
                    thePLC.Write("DB4.DBX251.4", value);
                    break;
                case "ANO.Set_P4_Auto":
                    thePLC.Write("DB4.DBX251.5", value);
                    break;
                case "ANO.Set_P4_Manu":
                    thePLC.Write("DB4.DBX251.6", value);
                    break;
                case "ANO.Set_P4_Manu_Run":
                    thePLC.Write("DB4.DBX251.7", value);
                    break;
                case "ANO.Set_P4_Manu_Stop":
                    thePLC.Write("DB4.DBX252.0", value);
                    break;
                //HK MTK

                case "HK_MTK.Set_Time_Chay":
                    thePLC.Write("DB4.DBW284.0", value);
                    break;
                case "HK_MTK.Set_Time_Nghi":
                    thePLC.Write("DB4.DBW286.0", value);
                    break;
                case "HK_MTK.Set_Delay_Time":
                    thePLC.Write("DB4.DBW288.0", value);
                    break;
                case "HK_MTK.Set_Reset_Time":
                    thePLC.Write("DB4.DBW290.0", value);
                    break;
                case "HK_MTK.Set_P1_Auto":
                    thePLC.Write("DB4.DBX290.1", value);
                    break;
                case "HK_MTK.Set_P1_Manu":
                    thePLC.Write("DB4.DBX290.2", value);
                    break;
                case "HK_MTK.Set_P1_Manu_Run":
                    thePLC.Write("DB4.DBX290.3", value);
                    break;
                case "HK_MTK.Set_P1_Manu_Stop":
                    thePLC.Write("DB4.DBX290.4", value);
                    break;
                case "HK_MTK.Set_P2_Auto":
                    thePLC.Write("DB4.DBX290.5", value);
                    break;
                case "HK_MTK.Set_P2_Manu":
                    thePLC.Write("DB4.DBX290.6", value);
                    break;
                case "HK_MTK.Set_P2_Manu_Run":
                    thePLC.Write("DB4.DBX290.7", value);
                    break;
                case "HK_MTK.Set_P2_Manu_Stop":
                    thePLC.Write("DB4.DBX291.0", value);
                    break;
                case "HK_MTK.Set_P3_Auto":
                    thePLC.Write("DB4.DBX291.1", value);
                    break;
                case "HK_MTK.Set_P3_Manu":
                    thePLC.Write("DB4.DBX291.2", value);
                    break;
                case "HK_MTK.Set_P3_Manu_Run":
                    thePLC.Write("DB4.DBX291.3", value);
                    break;
                case "HK_MTK.Set_P3_Manu_Stop":
                    thePLC.Write("DB4.DBX291.4", value);
                    break;
                case "HK_MTK.Set_P4_Auto":
                    thePLC.Write("DB4.DBX291.5", value);
                    break;
                case "HK_MTK.Set_P4_Manu":
                    thePLC.Write("DB4.DBX291.6", value);
                    break;
                case "HK_MTK.Set_P4_Manu_Run":
                    thePLC.Write("DB4.DBX291.7", value);
                    break;
                case "HK_MTK.Set_P4_Manu_Stop":
                    thePLC.Write("DB4.DBX292.0", value);
                    break;
            }
        }

        System.Timers.Timer TestUpdatePLC = new System.Timers.Timer();


        
        //đọc từ PLC vào các class ở Datablock
        private void ReadPLCTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (thePLC.IsConnected)
            {
                try
                {
                    thePLC.ReadClass(Remain_Time, 20);
                    thePLC.ReadClass(Data, 4);
                    thePLC.ReadClass(Alarm, 21);
                }
                catch
                {
                    Console.WriteLine("PLC not connect!!!!");
                }
            }
        }
    }
}
