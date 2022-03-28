using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLC_Config;

namespace BAU_BANG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Home home;
        public static Home_NM home_nm;
        public static Alarm alarm;
        public static Alarm_NM alarm_nm;
        public static Login login;
        public static int Role;

        public static SCADA Root;

        [STAThread]
        static void Main()
        {
            Root = new SCADA();
            home = new Home(Root);
            home_nm = new Home_NM(Root);
            login = new Login();
            alarm = new Alarm(Root);
            alarm_nm = new Alarm_NM(Root);

            PLC plc = new PLC("192.168.0.1", 0, 1, 1500);
            Root.AddPLC(plc);
            TASK Task_1 = new TASK("Task_1", 500);

            //group 4 pump
            GROUP_4PUMP Group_ANO = new GROUP_4PUMP("Group_ANO");
            Root.AddG4P(Group_ANO);
            Root.RunG4P("Group_ANO");

            GROUP_4PUMP_FacePlate Group_ANO_FacePlate = new GROUP_4PUMP_FacePlate(Group_ANO);
            Root.AddG4P_FacePlate(Group_ANO_FacePlate);

            //group 4 mtk
            GROUP_4MTK Group_HK_MTK = new GROUP_4MTK("Group_HK_MTK");
            Root.AddG4MTK(Group_HK_MTK);
            Root.RunG4MTK("Group_HK_MTK");

            GROUP_4MTK_FacePlate Group_HK_MTK_FacePlate = new GROUP_4MTK_FacePlate(Group_HK_MTK);
            Root.AddG4MTK_FacePlate(Group_HK_MTK_FacePlate);


            //Group 2 pump
            GROUP_2PUMP Group_DH_PUMP = new GROUP_2PUMP("Group_DH_PUMP");//0
            Root.AddG2P(Group_DH_PUMP);
            Root.RunG2PUMP("Group_DH_PUMP");
            GROUP_2PUMP Group_HG_PUMP = new GROUP_2PUMP("Group_HG_PUMP");//1
            Root.AddG2P(Group_HG_PUMP);
            Root.RunG2PUMP("Group_HG_PUMP");
            GROUP_2PUMP Group_DH_MTK = new GROUP_2PUMP("Group_DH_MTK");//2
            Root.AddG2P(Group_DH_MTK);
            Root.RunG2PUMP("Group_DH_MTK");
            GROUP_2PUMP Group_PAC_PUMP = new GROUP_2PUMP("Group_PAC_PUMP");//3
            Root.AddG2P(Group_PAC_PUMP);
            Root.RunG2PUMP("Group_PAC_PUMP");
            GROUP_2PUMP Group_PO_PUMP = new GROUP_2PUMP("Group_PO_PUMP");//4
            Root.AddG2P(Group_PO_PUMP);
            Root.RunG2PUMP("Group_PO_PUMP");
            GROUP_2PUMP Group_DLDD = new GROUP_2PUMP("Group_DLDD");//5
            Root.AddG2P(Group_DLDD);
            Root.RunG2PUMP("Group_DLDD");
            GROUP_2PUMP Group_KT_PUMP = new GROUP_2PUMP("Group_KT_PUMP");//6
            Root.AddG2P(Group_KT_PUMP);
            Root.RunG2PUMP("Group_KT_PUMP");
            GROUP_2PUMP Group_HLU = new GROUP_2PUMP("Group_HLU");//7
            Root.AddG2P(Group_HLU);
            Root.RunG2PUMP("Group_HLU");
            GROUP_2PUMP Group_HL_PUMP = new GROUP_2PUMP("Group_HL_PUMP");//8
            Root.AddG2P(Group_HL_PUMP);
            Root.RunG2PUMP("Group_HL_PUMP");
            GROUP_2PUMP Group_SH_PUMP = new GROUP_2PUMP("Group_SH_PUMP");//9
            Root.AddG2P(Group_SH_PUMP);
            Root.RunG2PUMP("Group_SH_PUMP");

            GROUP_2PUMP_FacePlate Group_DH_PUMP_FacePLate = new GROUP_2PUMP_FacePlate(Group_DH_PUMP);
            Root.AddG2P_FacePlate(Group_DH_PUMP_FacePLate);
            GROUP_2PUMP_FacePlate Group_HG_PUMP_FacePLate = new GROUP_2PUMP_FacePlate(Group_HG_PUMP);
            Root.AddG2P_FacePlate(Group_HG_PUMP_FacePLate);
            GROUP_2PUMP_FacePlate Group_DH_MTK_FacePLate = new GROUP_2PUMP_FacePlate(Group_DH_MTK);
            Root.AddG2P_FacePlate(Group_DH_MTK_FacePLate);
            GROUP_2PUMP_FacePlate Group_PAC_PUMP_FacePLate = new GROUP_2PUMP_FacePlate(Group_PAC_PUMP);
            Root.AddG2P_FacePlate(Group_PAC_PUMP_FacePLate);
            GROUP_2PUMP_FacePlate Group_PO_PUMP_FacePLate = new GROUP_2PUMP_FacePlate(Group_PO_PUMP);
            Root.AddG2P_FacePlate(Group_PO_PUMP_FacePLate);
            GROUP_2PUMP_FacePlate Group_DLDD_FacePLate = new GROUP_2PUMP_FacePlate(Group_DLDD);
            Root.AddG2P_FacePlate(Group_DLDD_FacePLate);
            GROUP_2PUMP_FacePlate Group_KT_PUMP_FacePLate = new GROUP_2PUMP_FacePlate(Group_KT_PUMP);
            Root.AddG2P_FacePlate(Group_KT_PUMP_FacePLate);
            GROUP_2PUMP_FacePlate Group_HLU_FacePLate = new GROUP_2PUMP_FacePlate(Group_HLU);
            Root.AddG2P_FacePlate(Group_HLU_FacePLate);
            GROUP_2PUMP_FacePlate Group_HL_PUMP_FacePLate = new GROUP_2PUMP_FacePlate(Group_HL_PUMP);
            Root.AddG2P_FacePlate(Group_HL_PUMP_FacePLate);
            GROUP_2PUMP_FacePlate Group_SH_PUMP_FacePLate = new GROUP_2PUMP_FacePlate(Group_SH_PUMP);
            Root.AddG2P_FacePlate(Group_SH_PUMP_FacePLate);

            //Group 1 pump
            GROUP_1PUMP Group_PAC_KHUAY_BC = new GROUP_1PUMP("Group_PAC_KHUAY_BC");
            Root.AddG1P(Group_PAC_KHUAY_BC);
            Root.RunG1PUMP("Group_PAC_KHUAY_BC");
            GROUP_1PUMP Group_PO_KHUAY_BC = new GROUP_1PUMP("Group_PO_KHUAY_BC");
            Root.AddG1P(Group_PO_KHUAY_BC);
            Root.RunG1PUMP("Group_PO_KHUAY_BC");
            GROUP_1PUMP Group_HL_GATBUN = new GROUP_1PUMP("Group_HL_GATBUN");
            Root.AddG1P(Group_HL_GATBUN);
            Root.RunG1PUMP("Group_HL_GATBUN");
            GROUP_1PUMP Group_SH_GATBUN = new GROUP_1PUMP("Group_SH_GATBUN");
            Root.AddG1P(Group_SH_GATBUN);
            Root.RunG1PUMP("Group_SH_GATBUN");



            GROUP_1PUMP_FacePlate Group_PAC_KHUAY_BC_FacePLate = new GROUP_1PUMP_FacePlate(Group_PAC_KHUAY_BC);
            Root.AddG1P_FacePlate(Group_PAC_KHUAY_BC_FacePLate);
            GROUP_1PUMP_FacePlate Group_PO_KHUAY_BC_FacePLate = new GROUP_1PUMP_FacePlate(Group_PO_KHUAY_BC);
            Root.AddG1P_FacePlate(Group_PO_KHUAY_BC_FacePLate);
            GROUP_1PUMP_FacePlate Group_HL_GATBUN_FacePLate = new GROUP_1PUMP_FacePlate(Group_HL_GATBUN);
            Root.AddG1P_FacePlate(Group_HL_GATBUN_FacePLate);
            GROUP_1PUMP_FacePlate Group_SH_GATBUN_FacePLate = new GROUP_1PUMP_FacePlate(Group_SH_GATBUN);
            Root.AddG1P_FacePlate(Group_SH_GATBUN_FacePLate);
           

            //PUMP
            PUMP Sigle_ANO_Khuay1 = new PUMP("ANO_Khuay1");
            Root.AddP(Sigle_ANO_Khuay1);
            Root.RunP("ANO_Khuay1");
            PUMP Sigle_ANO_Khuay2 = new PUMP("ANO_Khuay2");
            Root.AddP(Sigle_ANO_Khuay2);
            Root.RunP("ANO_Khuay2");
            PUMP Sigle_ANO_Khuay3 = new PUMP("ANO_Khuay3");
            Root.AddP(Sigle_ANO_Khuay3);
            Root.RunP("ANO_Khuay3");
            PUMP Sigle_ANO_Khuay4 = new PUMP("ANO_Khuay4");
            Root.AddP(Sigle_ANO_Khuay4);
            Root.RunP("ANO_Khuay4");
            PUMP Sigle_BND = new PUMP("BND");
            Root.AddP(Sigle_BND);
            Root.RunP("BND");
            PUMP Sigle_DH_MTK1 = new PUMP("DH_MTK1");//5 
            Root.AddP(Sigle_DH_MTK1);
            Root.RunP("DH_MTK1");
            PUMP Sigle_DH_MTK2 = new PUMP("DH_MTK2");//6
            Root.AddP(Sigle_DH_MTK2);
            Root.RunP("DH_MTK2");
            PUMP Sigle_DH_Pump1 = new PUMP("DH_Pump1");//7
            Root.AddP(Sigle_DH_Pump1);
            Root.RunP("DH_Pump1");
            PUMP Sigle_DH_Pump2 = new PUMP("DH_Pump2");//8
            Root.AddP(Sigle_DH_Pump2);
            Root.RunP("DH_Pump2");
            PUMP Sigle_DLDD_Pump1 = new PUMP("DLDD_Pump1");//9
            Root.AddP(Sigle_DLDD_Pump1);
            Root.RunP("DLDD_Pump1");
            PUMP Sigle_DLDD_Pump2 = new PUMP("DLDD_Pump2");//10
            Root.AddP(Sigle_DLDD_Pump2);
            Root.RunP("DLDD_Pump2");
            PUMP Sigle_HG_Pump1 = new PUMP("HG_Pump1");//11
            Root.AddP(Sigle_HG_Pump1);
            Root.RunP("HG_Pump1");
            PUMP Sigle_HG_Pump2 = new PUMP("HG_Pump2");//12
            Root.AddP(Sigle_HG_Pump2);
            Root.RunP("HG_Pump2");
            PUMP Sigle_HK_MTK1 = new PUMP("HK_MTK1");//13
            Root.AddP(Sigle_HK_MTK1);
            Root.RunP("HK_MTK1");
            PUMP Sigle_HK_MTK2 = new PUMP("HK_MTK2");//14
            Root.AddP(Sigle_HK_MTK2);
            Root.RunP("HK_MTK2");
            PUMP Sigle_HK_MTK3 = new PUMP("HK_MTK3");//15
            Root.AddP(Sigle_HK_MTK3);
            Root.RunP("HK_MTK3");
            PUMP Sigle_HK_MTK4 = new PUMP("HK_MTK4");//16
            Root.AddP(Sigle_HK_MTK4);
            Root.RunP("HK_MTK4");
            PUMP Sigle_HL_GATBUN = new PUMP("HL_GATBUN");//17
            Root.AddP(Sigle_HL_GATBUN);
            Root.RunP("HL_GATBUN");
            PUMP Sigle_HL_Pump1 = new PUMP("HL_Pump1");//18
            Root.AddP(Sigle_HL_Pump1);
            Root.RunP("HL_Pump1");
            PUMP Sigle_HL_Pump2 = new PUMP("HL_Pump2");//19
            Root.AddP(Sigle_HL_Pump2);
            Root.RunP("HL_Pump2");
            PUMP Sigle_HLU_Pump1 = new PUMP("HLU_Pump1");//20
            Root.AddP(Sigle_HLU_Pump1);
            Root.RunP("HLU_Pump1");
            PUMP Sigle_HLU_Pump2 = new PUMP("HLU_Pump2");//21
            Root.AddP(Sigle_HLU_Pump2);
            Root.RunP("HLU_Pump2");
            PUMP Sigle_KT_DL_Pump1 = new PUMP("KT_DL_Pump1");//22
            Root.AddP(Sigle_KT_DL_Pump1);
            Root.RunP("KT_DL_Pump1");
            PUMP Sigle_KT_DL_Pump2 = new PUMP("KT_DL_Pump2");//23
            Root.AddP(Sigle_KT_DL_Pump2);
            Root.RunP("KT_DL_Pump2");
            PUMP Sigle_PAC_BC_Khuay = new PUMP("PAC_BC_Khuay");//24
            Root.AddP(Sigle_PAC_BC_Khuay);
            Root.RunP("PAC_BC_Khuay");
            PUMP Sigle_PAC_DL_Pump1 = new PUMP("PAC_DL_Pump1");//25
            Root.AddP(Sigle_PAC_DL_Pump1);
            Root.RunP("PAC_DL_Pump1");
            PUMP Sigle_PAC_DL_Pump2 = new PUMP("PAC_DL_Pump2");//26
            Root.AddP(Sigle_PAC_DL_Pump2);
            Root.RunP("PAC_DL_Pump2");
            PUMP Sigle_PAC_Khuay = new PUMP("PAC_Khuay");//27
            Root.AddP(Sigle_PAC_Khuay);
            Root.RunP("PAC_Khuay");
            PUMP Sigle_PO_BC_Khuay = new PUMP("PO_BC_Khuay");//28
            Root.AddP(Sigle_PO_BC_Khuay);
            Root.RunP("PO_BC_Khuay");
            PUMP Sigle_PO_DL_Pump1 = new PUMP("PO_DL_Pump1");//29
            Root.AddP(Sigle_PO_DL_Pump1);
            Root.RunP("PO_DL_Pump1");
            PUMP Sigle_PO_DL_Pump2 = new PUMP("PO_DL_Pump2");//30
            Root.AddP(Sigle_PO_DL_Pump2);
            Root.RunP("PO_DL_Pump2");
            PUMP Sigle_PO_Khuay = new PUMP("PO_Khuay");//31
            Root.AddP(Sigle_PO_Khuay);
            Root.RunP("PO_Khuay");
            PUMP Sigle_SH_GATBUN = new PUMP("SH_GATBUN");//32
            Root.AddP(Sigle_SH_GATBUN);
            Root.RunP("SH_GATBUN");
            PUMP Sigle_SH_Pump1 = new PUMP("SH_Pump1");//33
            Root.AddP(Sigle_SH_Pump1);
            Root.RunP("SH_Pump1");
            PUMP Sigle_SH_Pump2 = new PUMP("SH_Pump2");//34
            Root.AddP(Sigle_SH_Pump2);
            Root.RunP("SH_Pump2");

            PUMP_FacePlateBB Sigle_ANO_Khuay1_FacePlate = new PUMP_FacePlateBB(Sigle_ANO_Khuay1);
            Root.AddP_FacePlate(Sigle_ANO_Khuay1_FacePlate);
            PUMP_FacePlateBB Sigle_ANO_Khuay2_FacePlate = new PUMP_FacePlateBB(Sigle_ANO_Khuay2);
            Root.AddP_FacePlate(Sigle_ANO_Khuay2_FacePlate);
            PUMP_FacePlateBB Sigle_ANO_Khuay3_FacePlate = new PUMP_FacePlateBB(Sigle_ANO_Khuay3);
            Root.AddP_FacePlate(Sigle_ANO_Khuay3_FacePlate);
            PUMP_FacePlateBB Sigle_ANO_Khuay4_FacePlate = new PUMP_FacePlateBB(Sigle_ANO_Khuay4);
            Root.AddP_FacePlate(Sigle_ANO_Khuay4_FacePlate);
            PUMP_FacePlateBB Sigle_BND_FacePlate = new PUMP_FacePlateBB(Sigle_BND);
            Root.AddP_FacePlate(Sigle_BND_FacePlate);
            PUMP_FacePlateBB Sigle_DH_MTK1_FacePlate = new PUMP_FacePlateBB(Sigle_DH_MTK1);
            Root.AddP_FacePlate(Sigle_DH_MTK1_FacePlate);
            PUMP_FacePlateBB Sigle_DH_MTK2_FacePlate = new PUMP_FacePlateBB(Sigle_DH_MTK2);
            Root.AddP_FacePlate(Sigle_DH_MTK2_FacePlate);
            PUMP_FacePlateBB Sigle_DH_Pump1_FacePlate = new PUMP_FacePlateBB(Sigle_DH_Pump1);
            Root.AddP_FacePlate(Sigle_DH_Pump1_FacePlate);
            PUMP_FacePlateBB Sigle_DH_Pump2_FacePlate = new PUMP_FacePlateBB(Sigle_DH_Pump2);
            Root.AddP_FacePlate(Sigle_DH_Pump2_FacePlate);
            PUMP_FacePlateBB Sigle_DLDD_Pump1_FacePlate = new PUMP_FacePlateBB(Sigle_DLDD_Pump1);
            Root.AddP_FacePlate(Sigle_DLDD_Pump1_FacePlate);
            PUMP_FacePlateBB Sigle_DLDD_Pump2_FacePlate = new PUMP_FacePlateBB(Sigle_DLDD_Pump2);
            Root.AddP_FacePlate(Sigle_DLDD_Pump2_FacePlate);
            PUMP_FacePlateBB Sigle_HG_Pump1_FacePlate = new PUMP_FacePlateBB(Sigle_HG_Pump1);
            Root.AddP_FacePlate(Sigle_HG_Pump1_FacePlate);
            PUMP_FacePlateBB Sigle_HG_Pump2_FacePlate = new PUMP_FacePlateBB(Sigle_HG_Pump2);
            Root.AddP_FacePlate(Sigle_HG_Pump2_FacePlate);
            PUMP_FacePlateBB Sigle_HK_MTK1_FacePlate = new PUMP_FacePlateBB(Sigle_HK_MTK1);
            Root.AddP_FacePlate(Sigle_HK_MTK1_FacePlate);
            PUMP_FacePlateBB Sigle_HK_MTK2_FacePlate = new PUMP_FacePlateBB(Sigle_HK_MTK2);
            Root.AddP_FacePlate(Sigle_HK_MTK2_FacePlate);
            PUMP_FacePlateBB Sigle_HK_MTK3_FacePlate = new PUMP_FacePlateBB(Sigle_HK_MTK3);
            Root.AddP_FacePlate(Sigle_HK_MTK3_FacePlate);
            PUMP_FacePlateBB Sigle_HK_MTK4_FacePlate = new PUMP_FacePlateBB(Sigle_HK_MTK4);
            Root.AddP_FacePlate(Sigle_HK_MTK4_FacePlate);
            PUMP_FacePlateBB Sigle_HL_GATBUN_FacePlate = new PUMP_FacePlateBB(Sigle_HL_GATBUN);
            Root.AddP_FacePlate(Sigle_HL_GATBUN_FacePlate);
            PUMP_FacePlateBB Sigle_HL_Pump1_FacePlate = new PUMP_FacePlateBB(Sigle_HL_Pump1);
            Root.AddP_FacePlate(Sigle_HL_Pump1_FacePlate);
            PUMP_FacePlateBB Sigle_HL_Pump2_FacePlate = new PUMP_FacePlateBB(Sigle_HL_Pump2);
            Root.AddP_FacePlate(Sigle_HL_Pump2_FacePlate);
            PUMP_FacePlateBB Sigle_HLU_Pump1_FacePlate = new PUMP_FacePlateBB(Sigle_HLU_Pump1);
            Root.AddP_FacePlate(Sigle_HLU_Pump1_FacePlate);
            PUMP_FacePlateBB Sigle_HLU_Pump2_FacePlate = new PUMP_FacePlateBB(Sigle_HLU_Pump2);
            Root.AddP_FacePlate(Sigle_HLU_Pump2_FacePlate);
            PUMP_FacePlateBB Sigle_KT_DL_Pump1_FacePlate = new PUMP_FacePlateBB(Sigle_KT_DL_Pump1);
            Root.AddP_FacePlate(Sigle_KT_DL_Pump1_FacePlate);
            PUMP_FacePlateBB Sigle_KT_DL_Pump2_FacePlate = new PUMP_FacePlateBB(Sigle_KT_DL_Pump2);
            Root.AddP_FacePlate(Sigle_KT_DL_Pump2_FacePlate);
            PUMP_FacePlateBB Sigle_PAC_BC_Khuay_FacePlate = new PUMP_FacePlateBB(Sigle_PAC_BC_Khuay);
            Root.AddP_FacePlate(Sigle_PAC_BC_Khuay_FacePlate);
            PUMP_FacePlateBB Sigle_PAC_DL_Pump1_FacePlate = new PUMP_FacePlateBB(Sigle_PAC_DL_Pump1);
            Root.AddP_FacePlate(Sigle_PAC_DL_Pump1_FacePlate);
            PUMP_FacePlateBB Sigle_PAC_DL_Pump2_FacePlate = new PUMP_FacePlateBB(Sigle_PAC_DL_Pump2);
            Root.AddP_FacePlate(Sigle_PAC_DL_Pump2_FacePlate);
            PUMP_FacePlateBB Sigle_PAC_Khuay_FacePlate = new PUMP_FacePlateBB(Sigle_PAC_Khuay);
            Root.AddP_FacePlate(Sigle_PAC_Khuay_FacePlate);
            PUMP_FacePlateBB Sigle_PO_BC_Khuay_FacePlate = new PUMP_FacePlateBB(Sigle_PO_BC_Khuay);
            Root.AddP_FacePlate(Sigle_PO_BC_Khuay_FacePlate);
            PUMP_FacePlateBB Sigle_PO_DL_Pump1_FacePlate = new PUMP_FacePlateBB(Sigle_PO_DL_Pump1);
            Root.AddP_FacePlate(Sigle_PO_DL_Pump1_FacePlate);
            PUMP_FacePlateBB Sigle_PO_DL_Pump2_FacePlate = new PUMP_FacePlateBB(Sigle_PO_DL_Pump2);
            Root.AddP_FacePlate(Sigle_PO_DL_Pump2_FacePlate);
            PUMP_FacePlateBB Sigle_PO_Khuay_FacePlate = new PUMP_FacePlateBB(Sigle_PO_Khuay);
            Root.AddP_FacePlate(Sigle_PO_Khuay_FacePlate);
            PUMP_FacePlateBB Sigle_SH_GATBUN_FacePlate = new PUMP_FacePlateBB(Sigle_SH_GATBUN);
            Root.AddP_FacePlate(Sigle_SH_GATBUN_FacePlate);
            PUMP_FacePlateBB Sigle_SH_Pump1_FacePlate = new PUMP_FacePlateBB(Sigle_SH_Pump1);
            Root.AddP_FacePlate(Sigle_SH_Pump1_FacePlate);
            PUMP_FacePlateBB Sigle_SH_Pump2_FacePlate = new PUMP_FacePlateBB(Sigle_SH_Pump2);
            Root.AddP_FacePlate(Sigle_SH_Pump2_FacePlate);


            #region ADD TAG
            TAG HG_PUMP_Status_1 = new TAG("HG_PUMP_Status_1", "DB_DATA.HG_PUMP_Status_1");
            TAG HG_PUMP_Status_2 = new TAG("HG_PUMP_Status_2", "DB_DATA.HG_PUMP_Status_2");
            Task_1.AddTag(HG_PUMP_Status_1);
            Task_1.AddTag(HG_PUMP_Status_2);

            TAG DH_PUMP_Status_1 = new TAG("DH_PUMP_Status_1", "DB_DATA.DH_PUMP_Status_1");
            TAG DH_PUMP_Status_2 = new TAG("DH_PUMP_Status_2", "DB_DATA.DH_PUMP_Status_2");
            Task_1.AddTag(DH_PUMP_Status_1);
            Task_1.AddTag(DH_PUMP_Status_2);

            TAG DH_MTK_Status_1 = new TAG("DH_MTK_Status_1", "DB_DATA.DH_MTK_Status_1");
            TAG DH_MTK_Status_2 = new TAG("DH_MTK_Status_2", "DB_DATA.DH_MTK_Status_2");
            Task_1.AddTag(DH_MTK_Status_1);
            Task_1.AddTag(DH_MTK_Status_2);

            TAG PAC_KHUAY_Status = new TAG("PAC_KHUAY_Status", "DB_DATA.PAC_KHUAY_Status");
            Task_1.AddTag(PAC_KHUAY_Status);

            TAG PAC_KHUAY_BC_Status = new TAG("PAC_KHUAY_BC_Status", "DB_DATA.PAC_KHUAY_BC_Status");
            Task_1.AddTag(PAC_KHUAY_BC_Status);

            TAG PAC_PUMP_Status_1 = new TAG("PAC_PUMP_Status_1", "DB_DATA.PAC_PUMP_Status_1");
            TAG PAC_PUMP_Status_2 = new TAG("PAC_PUMP_Status_2", "DB_DATA.PAC_PUMP_Status_2");
            Task_1.AddTag(PAC_PUMP_Status_1);
            Task_1.AddTag(PAC_PUMP_Status_2);

            TAG PO_KHUAY_Status = new TAG("PO_KHUAY_Status", "DB_DATA.PO_KHUAY_Status");
            Task_1.AddTag(PO_KHUAY_Status);

            TAG PO_KHUAY_BC_Status = new TAG("PO_KHUAY_BC_Status", "DB_DATA.PO_KHUAY_BC_Status");
            Task_1.AddTag(PO_KHUAY_BC_Status);

            TAG PO_PUMP_Status_1 = new TAG("PO_PUMP_Status_1", "DB_DATA.PO_PUMP_Status_1");
            TAG PO_PUMP_Status_2 = new TAG("PO_PUMP_Status_2", "DB_DATA.PO_PUMP_Status_2");
            Task_1.AddTag(PO_PUMP_Status_1);
            Task_1.AddTag(PO_PUMP_Status_2);

            TAG HL_GATBUN_Status = new TAG("HL_GATBUN_Status", "DB_DATA.HL_GATBUN_Status");
            Task_1.AddTag(HL_GATBUN_Status);

            TAG HL_PUMP_Status_1 = new TAG("HL_PUMP_Status_1", "DB_DATA.HL_PUMP_Status_1");
            TAG HL_PUMP_Status_2 = new TAG("HL_PUMP_Status_2", "DB_DATA.HL_PUMP_Status_2");
            Task_1.AddTag(HL_PUMP_Status_1);
            Task_1.AddTag(HL_PUMP_Status_2);

            TAG ANO_Status_1 = new TAG("ANO_Status_1", "DB_DATA.ANO_Status_1");
            TAG ANO_Status_2 = new TAG("ANO_Status_2", "DB_DATA.ANO_Status_2");
            TAG ANO_Status_3 = new TAG("ANO_Status_3", "DB_DATA.ANO_Status_3");
            TAG ANO_Status_4 = new TAG("ANO_Status_4", "DB_DATA.ANO_Status_4");
            Task_1.AddTag(ANO_Status_1);
            Task_1.AddTag(ANO_Status_2);
            Task_1.AddTag(ANO_Status_3);
            Task_1.AddTag(ANO_Status_4);

            TAG HK_MTK_Status_1 = new TAG("HK_MTK_Status_1", "DB_DATA.HK_MTK_Status_1");
            TAG HK_MTK_Status_2 = new TAG("HK_MTK_Status_2", "DB_DATA.HK_MTK_Status_2");
            TAG HK_MTK_Status_3 = new TAG("HK_MTK_Status_3", "DB_DATA.HK_MTK_Status_3");
            TAG HK_MTK_Status_4 = new TAG("HK_MTK_Status_4", "DB_DATA.HK_MTK_Status_4");
            Task_1.AddTag(HK_MTK_Status_1);
            Task_1.AddTag(HK_MTK_Status_2);
            Task_1.AddTag(HK_MTK_Status_3);
            Task_1.AddTag(HK_MTK_Status_4);


            TAG DLDD_Status_1 = new TAG("DLDD_Status_1", "DB_DATA.DLDD_Status_1");
            TAG DLDD_Status_2 = new TAG("DLDD_Status_2", "DB_DATA.DLDD_Status_2");
            Task_1.AddTag(DLDD_Status_1);
            Task_1.AddTag(DLDD_Status_2);


            TAG HLU_Status_1 = new TAG("HLU_Status_1", "DB_DATA.HLU_Status_1");
            TAG HLU_Status_2 = new TAG("HLU_Status_2", "DB_DATA.HLU_Status_2");
            Task_1.AddTag(HLU_Status_1);
            Task_1.AddTag(HLU_Status_2);

            TAG SH_GATBUN_Status = new TAG("SH_GATBUN_Status", "DB_DATA.SH_GATBUN_Status");
            Task_1.AddTag(SH_GATBUN_Status);

            TAG SH_PUMP_Status_1 = new TAG("SH_PUMP_Status_1", "DB_DATA.SH_PUMP_Status_1");
            TAG SH_PUMP_Status_2 = new TAG("SH_PUMP_Status_2", "DB_DATA.SH_PUMP_Status_2");
            Task_1.AddTag(SH_PUMP_Status_1);
            Task_1.AddTag(SH_PUMP_Status_2);

            TAG KT_PUMP_Status_1 = new TAG("KT_PUMP_Status_1", "DB_DATA.KT_PUMP_Status_1");
            TAG KT_PUMP_Status_2 = new TAG("KT_PUMP_Status_2", "DB_DATA.KT_PUMP_Status_2");
            Task_1.AddTag(KT_PUMP_Status_1);
            Task_1.AddTag(KT_PUMP_Status_2);


            TAG BND_Status = new TAG("BND_Status", "DB_DATA.BND_Status");
            Task_1.AddTag(BND_Status);
            #endregion

            Root.AddTask(Task_1);
            Root.RunTask("Task_1");

            Application.EnableVisualStyles();
            Application.Run(login);
        }
    }
}
