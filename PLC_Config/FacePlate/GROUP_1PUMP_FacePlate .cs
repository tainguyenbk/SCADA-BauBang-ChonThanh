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
    public partial class GROUP_1PUMP_FacePlate : Form
    {
        Timer UpdateTimer = new Timer();
        GROUP_1PUMP Parent;
        public GROUP_1PUMP_FacePlate(GROUP_1PUMP parent)
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
            if (Parent.Status == 0)
            {
                sb_Status.DiscreteValue1 = false;
                sb_Status.DiscreteValue2 = false;
            }
            else if (Parent.Status == 1)
            {
                sb_Status.DiscreteValue1 = true;
                sb_Status.DiscreteValue2 = false;
            }
            else
            {
                sb_Status.DiscreteValue1 = false;
                sb_Status.DiscreteValue2 = true;
            }
            lb_Time_Total_Minute.Text = Parent.Time_Total_Minute.ToString();
            lb_Time_Total_Second.Text = Parent.Time_Total_Second.ToString();
            lb_Time_1_Minute.Text = Parent.Time_1_Minute.ToString();
            lb_Time_1_Second.Text = Parent.Time_1_Second.ToString();
            lb_Time_2_Minute.Text = Parent.Time_2_Minute.ToString();
            lb_Time_2_Second.Text = Parent.Time_2_Second.ToString();
        }

        private void lb_Time_Total_Minute_Click(object sender, EventArgs e)
        {

        }
    }
}
