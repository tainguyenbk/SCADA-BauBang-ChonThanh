using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLC_Config;
using SymbolFactoryDotNet;

namespace BAU_BANG
{
    public partial class Home_NM : Form
    {
        public SCADA Parent;

        public Home_NM(SCADA parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void sb_Sigle_DH_MTK1_Click(object sender, EventArgs e)
        {
            if(Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[5];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_DH_MTK2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[6];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HG_Pump1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[11];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HG_Pump2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[12];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_DH_Pump1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[7];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_DH_Pump2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[8];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_PAC_BC_Khuay_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[24];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_PO_BC_Khuay_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[28];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_PAC_DL_Pump1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[25];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_PAC_DL_Pump2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[26];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_PO_DL_Pump1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[29];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_PO_DL_Pump2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[30];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_PAC_Khuay_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[27];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_PO_Khuay_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[31];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HL_GATBUN_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[17];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HK_MTK1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[13];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HK_MTK2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[14];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HK_MTK3_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[15];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HK_MTK4_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[16];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HL_Pump1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[18];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HL_Pump2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[19];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_KT_DL_Pump1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[22];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_KT_DL_Pump2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[23];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_SH_GATBUN_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[32];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_SH_Pump1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[33];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_SH_Pump2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[34];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_ANO_Khuay1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[0];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_ANO_Khuay2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[1];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_ANO_Khuay3_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[2];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_ANO_Khuay4_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[3];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_DLDD_Pump1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[9];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_DLDD_Pump2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[10];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HLU_Pump1_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[20];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_HLU_Pump2_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[21];
                faceplate.ShowDialog();
            }
        }

        private void sb_Sigle_BND_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                PUMP_FacePlateBB faceplate = Program.Root.PUMP_FacePlates[4];
                faceplate.ShowDialog();
            }
        }






        //GROUP 1 PUMP
        private void lb_Group_PAC_KHUAY_BC_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_1PUMP_FacePlate faceplate = Program.Root.GROUP_1PUMP_FacePlates[0];
                faceplate.ShowDialog();
            }
        }

        private void lb_Group_PO_KHUAY_BC_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_1PUMP_FacePlate faceplate = Program.Root.GROUP_1PUMP_FacePlates[1];
                faceplate.ShowDialog();
            }
        }
        private void lb_Group_HL_GATBUN_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_1PUMP_FacePlate faceplate = Program.Root.GROUP_1PUMP_FacePlates[2];
                faceplate.ShowDialog();
            }
        }
        private void lb_Group_SH_GATBUN_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_1PUMP_FacePlate faceplate = Program.Root.GROUP_1PUMP_FacePlates[3];
                faceplate.ShowDialog();
            }
        }

        //GROUP 2 PUMP
        private void lb_Group_DH_PUMP_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[0];
                faceplate.ShowDialog();
            }
        }
        private void lb_Group_HG_PUMP_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[1];
                faceplate.ShowDialog();
            }
        }
     
        private void lb_Group_DH_MTK_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[2];
                faceplate.ShowDialog();
            }
        }
        private void lb_Group_PAC_PUMP_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[3];
                faceplate.ShowDialog();
            }
        }

        private void lb_Group_PO_PUMP_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[4];
                faceplate.ShowDialog();
            }
        }
        private void lb_Group_DLDD_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[5];
                faceplate.ShowDialog();
            }
        }
        private void lb_Group_KT_PUMP_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[6];
                faceplate.ShowDialog();
            }
        }
        private void lb_Group_HLU_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[7];
                faceplate.ShowDialog();
            }
        }
        private void lb_Group_HL_PUMP_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[8];
                faceplate.ShowDialog();
            }
        }
        private void lb_Group_SH_PUMP_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_2PUMP_FacePlate faceplate = Program.Root.GROUP_2PUMP_FacePlates[9];
                faceplate.ShowDialog();
            }
        }

        //GROUP 4 MTK
        private void lb_Group_HK_MTK_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_4MTK_FacePlate faceplate = Parent.GROUP_4MTK_FacePlates[0];
                faceplate.ShowDialog();
            }
        }

        // GROUP 4 PUMP
        private void lb_Group_ANO_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                GROUP_4PUMP_FacePlate faceplate = Parent.GROUP_4PUMP_FacePlates[0];
                faceplate.ShowDialog();
            }
        }

        private void bt_System_Click(object sender, EventArgs e)
        {
                MessageBox.Show("You are here bro :D");
        }

        private void bt_Alarm_Click(object sender, EventArgs e)
        {
            if (Program.Role == 1)
            {
                Program.alarm_nm.ShowDialog();
            }
        }

        public void OnOffAlarm(StandardControl symbol, object value)
        {
            if (Convert.ToInt32(value) == 0)
            {
                symbol.DiscreteValue1 = false;
                symbol.DiscreteValue2 = false;
            }
            else if (Convert.ToInt32(value) == 1)
            {
                symbol.DiscreteValue1 = true;
                symbol.DiscreteValue2 = false;
            }
            else
            {
                symbol.DiscreteValue1 = false;
                symbol.DiscreteValue2 = true;
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if(Program.Role == 1)
            {
                bt_exit.Text = "Admin";
            }
            else
            {
                bt_exit.Text = "Guest";
            }


            time_stamp.Text = DateTime.Now.ToString();
            TASK task = Parent.FindTask("Task_1");
            if (task != null)
            {
                TAG tag = task.FindTag("DH_MTK_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_DH_MTK1, tag.Value);
                }
                tag = task.FindTag("DH_MTK_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_DH_MTK2, tag.Value);
                }
                tag = task.FindTag("HG_PUMP_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HG_Pump1, tag.Value);
                }
                tag = task.FindTag("HG_PUMP_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HG_Pump2, tag.Value);
                }
                tag = task.FindTag("DH_PUMP_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_DH_Pump1, tag.Value);
                }
                tag = task.FindTag("DH_PUMP_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_DH_Pump2, tag.Value);
                }
                tag = task.FindTag("PAC_KHUAY_Status");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_PAC_Khuay, tag.Value);
                }
                tag = task.FindTag("PAC_KHUAY_BC_Status");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_PAC_BC_Khuay, tag.Value);
                }
                tag = task.FindTag("PAC_PUMP_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_PAC_DL_Pump1, tag.Value);
                }
                tag = task.FindTag("PAC_PUMP_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_PAC_DL_Pump2, tag.Value);
                }

                tag = task.FindTag("PO_KHUAY_Status");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_PO_Khuay, tag.Value);
                }
                tag = task.FindTag("PO_KHUAY_BC_Status");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_PO_BC_Khuay, tag.Value);
                }

                tag = task.FindTag("PO_PUMP_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_PO_DL_Pump1, tag.Value);
                }
                tag = task.FindTag("PO_PUMP_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_PO_DL_Pump2, tag.Value);
                }


                tag = task.FindTag("PO_KHUAY_BC_Status");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_PO_BC_Khuay, tag.Value);
                }
                tag = task.FindTag("HL_GATBUN_Status");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HL_GATBUN, tag.Value);
                }

                tag = task.FindTag("HL_PUMP_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HL_Pump1, tag.Value);
                }
                tag = task.FindTag("HL_PUMP_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HL_Pump2, tag.Value);
                }

                tag = task.FindTag("ANO_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_ANO_Khuay1, tag.Value);
                }
                tag = task.FindTag("ANO_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_ANO_Khuay2, tag.Value);
                }
                tag = task.FindTag("ANO_Status_3");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_ANO_Khuay3, tag.Value);
                }
                tag = task.FindTag("ANO_Status_4");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_ANO_Khuay4, tag.Value);
                }
                tag = task.FindTag("HK_MTK_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HK_MTK1, tag.Value);
                }
                tag = task.FindTag("HK_MTK_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HK_MTK2, tag.Value);
                }
                tag = task.FindTag("HK_MTK_Status_3");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HK_MTK3, tag.Value);
                }
                tag = task.FindTag("HK_MTK_Status_4");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HK_MTK4, tag.Value);
                }
                tag = task.FindTag("DLDD_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_DLDD_Pump1, tag.Value);
                }
                tag = task.FindTag("DLDD_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_DLDD_Pump2, tag.Value);
                }
                tag = task.FindTag("HLU_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HLU_Pump1, tag.Value);
                }
                tag = task.FindTag("HLU_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_HLU_Pump2, tag.Value);
                }
                tag = task.FindTag("SH_GATBUN_Status");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_SH_GATBUN, tag.Value);
                }
                tag = task.FindTag("SH_PUMP_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_SH_Pump1, tag.Value);
                }
                tag = task.FindTag("SH_PUMP_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_SH_Pump2, tag.Value);
                }
                tag = task.FindTag("KT_PUMP_Status_1");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_KT_DL_Pump1, tag.Value);
                }
                tag = task.FindTag("KT_PUMP_Status_2");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_KT_DL_Pump2, tag.Value);
                }
                tag = task.FindTag("BND_Status");
                if (tag != null)
                {
                    OnOffAlarm(sb_Sigle_BND, tag.Value);
                }
            }

        }

        private void sb_Sigle_HG_Pump2_Load(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.login.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
    }
}
