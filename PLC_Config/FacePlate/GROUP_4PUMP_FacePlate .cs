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
    public partial class GROUP_4PUMP_FacePlate : Form
    {
        Timer UpdateTimer = new Timer();
        GROUP_4PUMP Parent;
        public GROUP_4PUMP_FacePlate(GROUP_4PUMP parent)
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
                sb_Status_2.DiscreteValue1 = false;
                sb_Status_2.DiscreteValue2 = false;
            }
            else if (Parent.Status_2 == 1)
            {
                sb_Status_2.DiscreteValue1 = true;
                sb_Status_2.DiscreteValue2 = false;
            }
            else
            {
                sb_Status_2.DiscreteValue1 = false;
                sb_Status_2.DiscreteValue2 = true;
            }

            if (Parent.Status_3 == 0)
            {
                sb_Status_3.DiscreteValue1 = false;
                sb_Status_3.DiscreteValue2 = false;
            }
            else if (Parent.Status_3 == 1)
            {
                sb_Status_3.DiscreteValue1 = true;
                sb_Status_3.DiscreteValue2 = false;
            }
            else
            {
                sb_Status_3.DiscreteValue1 = false;
                sb_Status_3.DiscreteValue2 = true;
            }


            if (Parent.Status_4 == 0)
            {
                sb_Status_4.DiscreteValue1 = false;
                sb_Status_4.DiscreteValue2 = false;
            }
            else if (Parent.Status_4 == 1)
            {
                sb_Status_4.DiscreteValue1 = true;
                sb_Status_4.DiscreteValue2 = false;
            }
            else
            {
                sb_Status_4.DiscreteValue1 = false;
                sb_Status_4.DiscreteValue2 = true;
            }

            lb_Time_total_min.Text = Parent.Time_total_min.ToString();
            lb_Time_total_sec.Text = Parent.Time_total_sec.ToString();
            lb_Time_min_1.Text = Parent.Time_min_13.ToString();
            lb_Time_sec_1.Text = Parent.Time_sec_13.ToString();
            lb_Time_min_3.Text = Parent.Time_min_13.ToString();
            lb_Time_sec_3.Text = Parent.Time_sec_13.ToString();
            lb_Time_min_2.Text = Parent.Time_min_24.ToString();
            lb_Time_sec_2.Text = Parent.Time_sec_24.ToString();
            lb_Time_min_4.Text = Parent.Time_min_24.ToString();
            lb_Time_sec_4.Text = Parent.Time_sec_24.ToString();
            lb_CurrentVal.Text = Parent.TimeLP.ToString();
        }

        private void bt_SetTime_Click(object sender, EventArgs e)
        {
            Parent.Write_Device("SET_TIME_LP", (object)txt_TimeLP.Text);
        }

        private void bt_Reset_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("RESET", false);
        }

        private void bt_Reset_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("RESET", true);
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}
