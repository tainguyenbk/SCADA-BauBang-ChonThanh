using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBlock
{
    public class DB_DATA
    {
        //HG PUMP
        public bool HG_PUMP_Enable { get; set; }
        public bool HG_PUMP_Fault_1 { get; set; }
        public bool HG_PUMP_Fault_2 { get; set; }
        public bool HG_PUMP_Run_1 { get; set; }
        public bool HG_PUMP_Run_2 { get; set; }
        public byte HG_PUMP_End { get; set; }
        public ushort HG_PUMP_Time_LP { get; set; }
        public bool HG_PUMP_Reset { get; set; }
        public bool HG_PUMP_Auto_1 { get; set; }
        public bool HG_PUMP_Man_1 { get; set; }
        public bool HG_PUMP_Man_run_1 { get; set; }
        public bool HG_PUMP_Man_stop_1 { get; set; }
        public bool HG_PUMP_Auto_2 { get; set; }
        public bool HG_PUMP_Man_2 { get; set; }
        public bool HG_PUMP_Man_run_2 { get; set; }
        public bool HG_PUMP_Man_stop_2 { get; set; }
        public ushort HG_PUMP_Time_total_min { get; set; }
        public ushort HG_PUMP_Time_total_sec { get; set; }
        public ushort HG_PUMP_Float { get; set; }
        public ushort HG_PUMP_Control_1 { get; set; }
        public ushort HG_PUMP_Status_1 { get; set; }
        public ushort HG_PUMP_Time_min_1 { get; set; }
        public ushort HG_PUMP_Time_sec_1 { get; set; }
        public ushort HG_PUMP_Control_2 { get; set; }
        public ushort HG_PUMP_Status_2 { get; set; }
        public ushort HG_PUMP_Time_min_2 { get; set; }
        public ushort HG_PUMP_Time_sec_2 { get; set; }

        //DH PUMP
        public bool DH_PUMP_Enable { get; set; }
        public bool DH_PUMP_Fault_1 { get; set; }
        public bool DH_PUMP_Fault_2 { get; set; }
        public bool DH_PUMP_Run_1 { get; set; }
        public bool DH_PUMP_Run_2 { get; set; }
        public byte DH_PUMP_End { get; set; }
        public ushort DH_PUMP_Time_LP { get; set; }
        public bool DH_PUMP_Reset { get; set; }
        public bool DH_PUMP_Auto_1 { get; set; }
        public bool DH_PUMP_Man_1 { get; set; }
        public bool DH_PUMP_Man_run_1 { get; set; }
        public bool DH_PUMP_Man_stop_1 { get; set; }
        public bool DH_PUMP_Auto_2 { get; set; }
        public bool DH_PUMP_Man_2 { get; set; }
        public bool DH_PUMP_Man_run_2 { get; set; }
        public bool DH_PUMP_Man_stop_2 { get; set; }
        public ushort DH_PUMP_Time_total_min { get; set; }
        public ushort DH_PUMP_Time_total_sec { get; set; }
        public ushort DH_PUMP_Float { get; set; }
        public ushort DH_PUMP_Control_1 { get; set; }
        public ushort DH_PUMP_Status_1 { get; set; }
        public ushort DH_PUMP_Time_min_1 { get; set; }
        public ushort DH_PUMP_Time_sec_1 { get; set; }
        public ushort DH_PUMP_Control_2 { get; set; }
        public ushort DH_PUMP_Status_2 { get; set; }
        public ushort DH_PUMP_Time_min_2 { get; set; }
        public ushort DH_PUMP_Time_sec_2 { get; set; }

        //DH MTK
        public bool DH_MTK_Enable { get; set; }
        public ushort DH_MTK_Time_LP { get; set; }
        public bool DH_MTK_Reset { get; set; }
        public bool DH_MTK_Auto_1 { get; set; }
        public bool DH_MTK_Man_1 { get; set; }
        public bool DH_MTK_Man_run_1 { get; set; }
        public bool DH_MTK_Man_stop_1 { get; set; }
        public bool DH_MTK_Auto_2 { get; set; }
        public bool DH_MTK_Man_2 { get; set; }
        public bool DH_MTK_Man_run_2 { get; set; }
        public bool DH_MTK_Man_stop_2 { get; set; }
        public ushort DH_MTK_Time_total_min { get; set; }
        public ushort DH_MTK_Time_total_sec { get; set; }
        public ushort DH_MTK_Control_1 { get; set; }
        public ushort DH_MTK_Status_1 { get; set; }
        public ushort DH_MTK_Time_min_1 { get; set; }
        public ushort DH_MTK_Time_sec_1 { get; set; }
        public ushort DH_MTK_Control_2 { get; set; }
        public ushort DH_MTK_Status_2 { get; set; }
        public ushort DH_MTK_Time_min_2 { get; set; }
        public ushort DH_MTK_Time_sec_2 { get; set; }

        //PAC KHUAY
        public bool PAC_KHUAY_Auto { get; set; }
        public bool PAC_KHUAY_Man { get; set; }
        public bool PAC_KHUAY_Man_run { get; set; }
        public bool PAC_KHUAY_Man_stop { get; set; }
        public ushort PAC_KHUAY_Control { get; set; }
        public ushort PAC_KHUAY_Status { get; set; }


        //PAC KHUAY BC
        public bool PAC_KHUAY_BC_Enable { get; set; }
        public ushort PAC_KHUAY_BC_Time_chay { get; set; }
        public ushort PAC_KHUAY_BC_Time_nghi { get; set; }
        public bool PAC_KHUAY_BC_Reset { get; set; }
        public bool PAC_KHUAY_BC_Auto { get; set; }
        public bool PAC_KHUAY_BC_Man { get; set; }
        public bool PAC_KHUAY_BC_Man_run { get; set; }
        public bool PAC_KHUAY_BC_Man_stop { get; set; }
        public ushort PAC_KHUAY_BC_Time_total_min { get; set; }
        public ushort PAC_KHUAY_BC_Time_total_sec { get; set; }
        public ushort PAC_KHUAY_BC_Control { get; set; }
        public ushort PAC_KHUAY_BC_Status { get; set; }
        public ushort PAC_KHUAY_BC_Run_time_min { get; set; }
        public ushort PAC_KHUAY_BC_Run_time_sec { get; set; }
        public ushort PAC_KHUAY_BC_Stop_time_min { get; set; }
        public ushort PAC_KHUAY_BC_Stop_time_sec { get; set; }


        //PAC PUMP
        public bool PAC_PUMP_Enable { get; set; }
        public ushort PAC_PUMP_Time_LP { get; set; }
        public bool PAC_PUMP_Reset { get; set; }
        public bool PAC_PUMP_Auto_1 { get; set; }
        public bool PAC_PUMP_Man_1 { get; set; }
        public bool PAC_PUMP_Man_run_1 { get; set; }
        public bool PAC_PUMP_Man_stop_1 { get; set; }
        public bool PAC_PUMP_Auto_2 { get; set; }
        public bool PAC_PUMP_Man_2 { get; set; }
        public bool PAC_PUMP_Man_run_2 { get; set; }
        public bool PAC_PUMP_Man_stop_2 { get; set; }
        public ushort PAC_PUMP_Time_total_min { get; set; }
        public ushort PAC_PUMP_Time_total_sec { get; set; }
        public ushort PAC_PUMP_Control_1 { get; set; }
        public ushort PAC_PUMP_Status_1 { get; set; }
        public ushort PAC_PUMP_Time_min_1 { get; set; }
        public ushort PAC_PUMP_Time_sec_1 { get; set; }
        public ushort PAC_PUMP_Control_2 { get; set; }
        public ushort PAC_PUMP_Status_2 { get; set; }
        public ushort PAC_PUMP_Time_min_2 { get; set; }
        public ushort PAC_PUMP_Time_sec_2 { get; set; }

        //PO KHUAY
        public bool PO_KHUAY_Auto { get; set; }
        public bool PO_KHUAY_Man { get; set; }
        public bool PO_KHUAY_Man_run { get; set; }
        public bool PO_KHUAY_Man_stop { get; set; }
        public ushort PO_KHUAY_Control { get; set; }
        public ushort PO_KHUAY_Status { get; set; }


        //PO KHUAY BC
        public bool PO_KHUAY_BC_Enable { get; set; }
        public ushort PO_KHUAY_BC_Time_chay { get; set; }
        public ushort PO_KHUAY_BC_Time_nghi { get; set; }
        public bool PO_KHUAY_BC_Reset { get; set; }
        public bool PO_KHUAY_BC_Auto { get; set; }
        public bool PO_KHUAY_BC_Man { get; set; }
        public bool PO_KHUAY_BC_Man_run { get; set; }
        public bool PO_KHUAY_BC_Man_stop { get; set; }
        public ushort PO_KHUAY_BC_Time_total_min { get; set; }
        public ushort PO_KHUAY_BC_Time_total_sec { get; set; }
        public ushort PO_KHUAY_BC_Control { get; set; }
        public ushort PO_KHUAY_BC_Status { get; set; }
        public ushort PO_KHUAY_BC_Run_time_min { get; set; }
        public ushort PO_KHUAY_BC_Run_time_sec { get; set; }
        public ushort PO_KHUAY_BC_Stop_time_min { get; set; }
        public ushort PO_KHUAY_BC_Stop_time_sec { get; set; }


        //PO PUMP
        public bool PO_PUMP_Enable { get; set; }
        public ushort PO_PUMP_Time_LP { get; set; }
        public bool PO_PUMP_Reset { get; set; }
        public bool PO_PUMP_Auto_1 { get; set; }
        public bool PO_PUMP_Man_1 { get; set; }
        public bool PO_PUMP_Man_run_1 { get; set; }
        public bool PO_PUMP_Man_stop_1 { get; set; }
        public bool PO_PUMP_Auto_2 { get; set; }
        public bool PO_PUMP_Man_2 { get; set; }
        public bool PO_PUMP_Man_run_2 { get; set; }
        public bool PO_PUMP_Man_stop_2 { get; set; }
        public ushort PO_PUMP_Time_total_min { get; set; }
        public ushort PO_PUMP_Time_total_sec { get; set; }
        public ushort PO_PUMP_Control_1 { get; set; }
        public ushort PO_PUMP_Status_1 { get; set; }
        public ushort PO_PUMP_Time_min_1 { get; set; }
        public ushort PO_PUMP_Time_sec_1 { get; set; }
        public ushort PO_PUMP_Control_2 { get; set; }
        public ushort PO_PUMP_Status_2 { get; set; }
        public ushort PO_PUMP_Time_min_2 { get; set; }
        public ushort PO_PUMP_Time_sec_2 { get; set; }


        //HL GATBUN
        public bool HL_GATBUN_Enable { get; set; }
        public ushort HL_GATBUN_Time_chay { get; set; }
        public ushort HL_GATBUN_Time_nghi { get; set; }
        public bool HL_GATBUN_Reset { get; set; }
        public bool HL_GATBUN_Auto { get; set; }
        public bool HL_GATBUN_Man { get; set; }
        public bool HL_GATBUN_Man_run { get; set; }
        public bool HL_GATBUN_Man_stop { get; set; }
        public ushort HL_GATBUN_Time_total_min { get; set; }
        public ushort HL_GATBUN_Time_total_sec { get; set; }
        public ushort HL_GATBUN_Control { get; set; }
        public ushort HL_GATBUN_Status { get; set; }
        public ushort HL_GATBUN_Run_time_min { get; set; }
        public ushort HL_GATBUN_Run_time_sec { get; set; }
        public ushort HL_GATBUN_Stop_time_min { get; set; }
        public ushort HL_GATBUN_Stop_time_sec { get; set; }


        //HL PUMP
        public bool HL_PUMP_Enable { get; set; }
        public ushort HL_PUMP_Time_chay { get; set; }
        public ushort HL_PUMP_Time_nghi { get; set; }
        public bool HL_PUMP_Reset { get; set; }
        public bool HL_PUMP_Auto_1 { get; set; }
        public bool HL_PUMP_Man_1 { get; set; }
        public bool HL_PUMP_Man_run_1 { get; set; }
        public bool HL_PUMP_Man_stop_1 { get; set; }
        public bool HL_PUMP_Auto_2 { get; set; }
        public bool HL_PUMP_Man_2 { get; set; }
        public bool HL_PUMP_Man_run_2 { get; set; }
        public bool HL_PUMP_Man_stop_2 { get; set; }
        public ushort HL_PUMP_Time_total_min { get; set; }
        public ushort HL_PUMP_Time_total_sec { get; set; }
        public ushort HL_PUMP_Control_1 { get; set; }
        public ushort HL_PUMP_Status_1 { get; set; }
        public ushort HL_PUMP_Time_min_1 { get; set; }
        public ushort HL_PUMP_Time_sec_1 { get; set; }
        public ushort HL_PUMP_Control_2 { get; set; }
        public ushort HL_PUMP_Status_2 { get; set; }
        public ushort HL_PUMP_Time_min_2 { get; set; }
        public ushort HL_PUMP_Time_sec_2 { get; set; }


        //ANO
        public bool ANO_Enable { get; set; }
        public ushort ANO_Time_LP { get; set; }
        public bool ANO_Reset { get; set; }
        public bool ANO_Auto_1 { get; set; }
        public bool ANO_Man_1 { get; set; }
        public bool ANO_Man_run_1 { get; set; }
        public bool ANO_Man_stop_1 { get; set; }
        public bool ANO_Auto_2 { get; set; }
        public bool ANO_Man_2 { get; set; }
        public bool ANO_Man_run_2 { get; set; }
        public bool ANO_Man_stop_2 { get; set; }
        public bool ANO_Auto_3 { get; set; }
        public bool ANO_Man_3 { get; set; }
        public bool ANO_Man_run_3 { get; set; }
        public bool ANO_Man_stop_3 { get; set; }
        public bool ANO_Auto_4 { get; set; }
        public bool ANO_Man_4 { get; set; }
        public bool ANO_Man_run_4 { get; set; }
        public bool ANO_Man_stop_4 { get; set; }
        public ushort ANO_Time_total_min { get; set; }
        public ushort ANO_Time_total_sec { get; set; }
        public ushort ANO_Control_1 { get; set; }
        public ushort ANO_Status_1 { get; set; }
        public ushort ANO_Time_min_13 { get; set; }
        public ushort ANO_Time_sec_13 { get; set; }
        public ushort ANO_Control_2 { get; set; }
        public ushort ANO_Status_2 { get; set; }
        public ushort ANO_Time_min_24 { get; set; }
        public ushort ANO_Time_sec_24 { get; set; }
        public ushort ANO_Control_3 { get; set; }
        public ushort ANO_Status_3 { get; set; }
        public ushort ANO_Control_4 { get; set; }
        public ushort ANO_Status_4 { get; set; }

        //HK MTK
        public bool HK_MTK_Enable { get; set; }
        public ushort HK_MTK_Time_chay { get; set; }
        public ushort HK_MTK_Time_nghi { get; set; }
        public ushort HK_MTK_Delay { get; set; }
        public bool HK_MTK_Reset { get; set; }
        public bool HK_MTK_Auto_1 { get; set; }
        public bool HK_MTK_Man_1 { get; set; }
        public bool HK_MTK_Man_run_1 { get; set; }
        public bool HK_MTK_Man_stop_1 { get; set; }
        public bool HK_MTK_Auto_2 { get; set; }
        public bool HK_MTK_Man_2 { get; set; }
        public bool HK_MTK_Man_run_2 { get; set; }
        public bool HK_MTK_Man_stop_2 { get; set; }
        public bool HK_MTK_Auto_3 { get; set; }
        public bool HK_MTK_Man_3 { get; set; }
        public bool HK_MTK_Man_run_3 { get; set; }
        public bool HK_MTK_Man_stop_3 { get; set; }
        public bool HK_MTK_Auto_4 { get; set; }
        public bool HK_MTK_Man_4 { get; set; }
        public bool HK_MTK_Man_run_4 { get; set; }
        public bool HK_MTK_Man_stop_4 { get; set; }
        public ushort HK_MTK_Time_total_min_12 { get; set; }
        public ushort HK_MTK_Time_total_sec_12 { get; set; }
        public ushort HK_MTK_Time_total_min_34 { get; set; }
        public ushort HK_MTK_Time_total_sec_34 { get; set; }
        public ushort HK_MTK_Control_1 { get; set; }
        public ushort HK_MTK_Status_1 { get; set; }
        public ushort HK_MTK_Time_min_1 { get; set; }
        public ushort HK_MTK_Time_sec_1 { get; set; }
        public ushort HK_MTK_Control_2 { get; set; }
        public ushort HK_MTK_Status_2 { get; set; }
        public ushort HK_MTK_Time_min_2 { get; set; }
        public ushort HK_MTK_Time_sec_2 { get; set; }
        public ushort HK_MTK_Control_3 { get; set; }
        public ushort HK_MTK_Status_3 { get; set; }
        public ushort HK_MTK_Time_min_3 { get; set; }
        public ushort HK_MTK_Time_sec_3 { get; set; }
        public ushort HK_MTK_Control_4 { get; set; }
        public ushort HK_MTK_Status_4 { get; set; }
        public ushort HK_MTK_Time_min_4 { get; set; }
        public ushort HK_MTK_Time_sec_4 { get; set; }

        //DLDD
        public bool DLDD_Enable { get; set; }
        public ushort DLDD_Time_LP { get; set; }
        public bool DLDD_Reset { get; set; }
        public bool DLDD_Auto_1 { get; set; }
        public bool DLDD_Man_1 { get; set; }
        public bool DLDD_Man_run_1 { get; set; }
        public bool DLDD_Man_stop_1 { get; set; }
        public bool DLDD_Auto_2 { get; set; }
        public bool DLDD_Man_2 { get; set; }
        public bool DLDD_Man_run_2 { get; set; }
        public bool DLDD_Man_stop_2 { get; set; }
        public ushort DLDD_Time_total_min { get; set; }
        public ushort DLDD_Time_total_sec { get; set; }
        public ushort DLDD_Control_1 { get; set; }
        public ushort DLDD_Status_1 { get; set; }
        public ushort DLDD_Time_min_1 { get; set; }
        public ushort DLDD_Time_sec_1 { get; set; }
        public ushort DLDD_Control_2 { get; set; }
        public ushort DLDD_Status_2 { get; set; }
        public ushort DLDD_Time_min_2 { get; set; }
        public ushort DLDD_Time_sec_2 { get; set; }

        //HLU
        public bool HLU_Enable { get; set; }
        public ushort HLU_Time_LP { get; set; }
        public bool HLU_Reset { get; set; }
        public bool HLU_Auto_1 { get; set; }
        public bool HLU_Man_1 { get; set; }
        public bool HLU_Man_run_1 { get; set; }
        public bool HLU_Man_stop_1 { get; set; }
        public bool HLU_Auto_2 { get; set; }
        public bool HLU_Man_2 { get; set; }
        public bool HLU_Man_run_2 { get; set; }
        public bool HLU_Man_stop_2 { get; set; }
        public ushort HLU_Time_total_min { get; set; }
        public ushort HLU_Time_total_sec { get; set; }
        public ushort HLU_Control_1 { get; set; }
        public ushort HLU_Status_1 { get; set; }
        public ushort HLU_Time_min_1 { get; set; }
        public ushort HLU_Time_sec_1 { get; set; }
        public ushort HLU_Control_2 { get; set; }
        public ushort HLU_Status_2 { get; set; }
        public ushort HLU_Time_min_2 { get; set; }
        public ushort HLU_Time_sec_2 { get; set; }

        //SH GATBUN
        public bool SH_GATBUN_Enable { get; set; }
        public ushort SH_GATBUN_Time_chay { get; set; }
        public ushort SH_GATBUN_Time_nghi { get; set; }
        public bool SH_GATBUN_Reset { get; set; }
        public bool SH_GATBUN_Auto { get; set; }
        public bool SH_GATBUN_Man { get; set; }
        public bool SH_GATBUN_Man_run { get; set; }
        public bool SH_GATBUN_Man_stop { get; set; }
        public ushort SH_GATBUN_Time_total_min { get; set; }
        public ushort SH_GATBUN_Time_total_sec { get; set; }
        public ushort SH_GATBUN_Control { get; set; }
        public ushort SH_GATBUN_Status { get; set; }
        public ushort SH_GATBUN_Run_time_min { get; set; }
        public ushort SH_GATBUN_Run_time_sec { get; set; }
        public ushort SH_GATBUN_Stop_time_min { get; set; }
        public ushort SH_GATBUN_Stop_time_sec { get; set; }

        //SH PUMP
        public bool SH_PUMP_Enable { get; set; }
        public ushort SH_PUMP_Time_chay { get; set; }
        public ushort SH_PUMP_Time_nghi { get; set; }
        public bool SH_PUMP_Reset { get; set; }
        public bool SH_PUMP_Auto_1 { get; set; }
        public bool SH_PUMP_Man_1 { get; set; }
        public bool SH_PUMP_Man_run_1 { get; set; }
        public bool SH_PUMP_Man_stop_1 { get; set; }
        public bool SH_PUMP_Auto_2 { get; set; }
        public bool SH_PUMP_Man_2 { get; set; }
        public bool SH_PUMP_Man_run_2 { get; set; }
        public bool SH_PUMP_Man_stop_2 { get; set; }
        public ushort SH_PUMP_Time_total_min { get; set; }
        public ushort SH_PUMP_Time_total_sec { get; set; }
        public ushort SH_PUMP_Control_1 { get; set; }
        public ushort SH_PUMP_Status_1 { get; set; }
        public ushort SH_PUMP_Time_min_1 { get; set; }
        public ushort SH_PUMP_Time_sec_1 { get; set; }
        public ushort SH_PUMP_Control_2 { get; set; }
        public ushort SH_PUMP_Status_2 { get; set; }
        public ushort SH_PUMP_Time_min_2 { get; set; }
        public ushort SH_PUMP_Time_sec_2 { get; set; }

        //KT PUMP
        public bool KT_PUMP_Enable { get; set; }
        public ushort KT_PUMP_Time_LP { get; set; }
        public bool KT_PUMP_Reset { get; set; }
        public bool KT_PUMP_Auto_1 { get; set; }
        public bool KT_PUMP_Man_1 { get; set; }
        public bool KT_PUMP_Man_run_1 { get; set; }
        public bool KT_PUMP_Man_stop_1 { get; set; }
        public bool KT_PUMP_Auto_2 { get; set; }
        public bool KT_PUMP_Man_2 { get; set; }
        public bool KT_PUMP_Man_run_2 { get; set; }
        public bool KT_PUMP_Man_stop_2 { get; set; }
        public ushort KT_PUMP_Time_total_min { get; set; }
        public ushort KT_PUMP_Time_total_sec { get; set; }
        public ushort KT_PUMP_Control_1 { get; set; }
        public ushort KT_PUMP_Status_1 { get; set; }
        public ushort KT_PUMP_Time_min_1 { get; set; }
        public ushort KT_PUMP_Time_sec_1 { get; set; }
        public ushort KT_PUMP_Control_2 { get; set; }
        public ushort KT_PUMP_Status_2 { get; set; }
        public ushort KT_PUMP_Time_min_2 { get; set; }
        public ushort KT_PUMP_Time_sec_2 { get; set; }

        //BND
        public bool BND_Auto { get; set; }
        public bool BND_Man { get; set; }
        public bool BND_Man_run { get; set; }
        public bool BND_Man_stop { get; set; }
        public ushort BND_Control { get; set; }
        public ushort BND_Status { get; set; }
    }
}

