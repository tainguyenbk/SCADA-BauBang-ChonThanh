using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLC_Config
{
    public partial class GROUP_4MTK_FacePlate : Form
    {
        Timer UpdateTimer = new Timer();
        GROUP_4MTK Parent;
        public GROUP_4MTK_FacePlate(GROUP_4MTK parent)
        {
            Parent = parent;
            InitializeComponent();
            UpdateTimer.Interval = 250;
            UpdateTimer.Tick += UpdateTimer_Tick;
            UpdateTimer.Start();
        }



        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            groupBox_Device.Text = Parent.Name;
            if (Parent.Status_1 == 0)
            {
                sb_Status_1.DiscreteValue1 = false;
                sb_Status_1.DiscreteValue2 = false;
            }
            else if (Parent.Status_1 == 1)
            {
                sb_Status_1.DiscreteValue1 = true;
                sb_Status_1.DiscreteValue2 = false;
            }
            else
            {
                sb_Status_1.DiscreteValue1 = false;
                sb_Status_1.DiscreteValue2 = true;
            }

            if (Parent.Status_2 == 0)
            {
                sb_Status_2.DiscreteValue2 = false;
                sb_Status_2.DiscreteValue2 = false;
            }
            else if (Parent.Status_2 == 2)
            {
                sb_Status_2.DiscreteValue2 = true;
                sb_Status_2.DiscreteValue2 = false;
            }
            else
            {
                sb_Status_2.DiscreteValue2 = false;
                sb_Status_2.DiscreteValue2 = true;
            }

            if (Parent.Status_3 == 0)
            {
                sb_Status_3.DiscreteValue3 = false;
                sb_Status_3.DiscreteValue3 = false;
            }
            else if (Parent.Status_3 == 3)
            {
                sb_Status_3.DiscreteValue3 = true;
                sb_Status_3.DiscreteValue3 = false;
            }
            else
            {
                sb_Status_3.DiscreteValue3 = false;
                sb_Status_3.DiscreteValue3 = true;
            }


            if (Parent.Status_4 == 0)
            {
                sb_Status_4.DiscreteValue4 = false;
                sb_Status_4.DiscreteValue4 = false;
            }
            else if (Parent.Status_4 == 4)
            {
                sb_Status_4.DiscreteValue4 = true;
                sb_Status_4.DiscreteValue4 = false;
            }
            else
            {
                sb_Status_4.DiscreteValue4 = false;
                sb_Status_4.DiscreteValue4 = true;
            }

            lb_Time_total_min_12.Text = Parent.Time_total_min_12.ToString();
            lb_Time_total_sec_12.Text = Parent.Time_total_sec_12.ToString();
            lb_Time_total_min_34.Text = Parent.Time_total_min_34.ToString();
            lb_Time_total_sec_34.Text = Parent.Time_total_sec_34.ToString();
            lb_Time_min_1.Text = Parent.Time_min_1.ToString();
            lb_Time_sec_1.Text = Parent.Time_sec_1.ToString();
            lb_Time_min_2.Text = Parent.Time_min_2.ToString();
            lb_Time_sec_2.Text = Parent.Time_sec_2.ToString();
            lb_Time_min_3.Text = Parent.Time_min_3.ToString();
            lb_Time_sec_3.Text = Parent.Time_sec_3.ToString();
            lb_Time_min_4.Text = Parent.Time_min_4.ToString();
            lb_Time_sec_4.Text = Parent.Time_sec_4.ToString();
            lb_CRV_TRUN.Text = Parent.CurrentTime_run.ToString();
            lb_CRV_TSTOP.Text = Parent.CurrentTime_stop.ToString();
            lb_CRV_TDELAY.Text = Parent.CurrentTime_delay.ToString();



        }

        private void bt_Reset_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("RESET", false);
        }

        private void bt_Reset_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("RESET", true);
        }

        private void bt_SET_TRUN_Click(object sender, EventArgs e)
        {
            Parent.Write_Device("SET_TRUN", (object)tb_TRUN.Text);
        }

        private void bt_SET_TSTOP_Click(object sender, EventArgs e)
        {
            Parent.Write_Device("SET_TSTOP", (object)tb_TSTOP.Text);
        }

        private void bt_SET_TDELAY_Click(object sender, EventArgs e)
        {
            Parent.Write_Device("SET_TDELAY", (object)tb_TDELAY.Text);
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {

        }
    }
}
