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
    public partial class PUMP_FacePlateBB : Form
    {
        PUMP Parent;

        Timer UpdateTimer = new Timer();
        public PUMP_FacePlateBB(PUMP parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lb_TimeHD.Text = Parent.Time_Reamin_Minute.ToString();
            

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
            if (Parent.Man)
            {
                bt_Manual.BackColor = Color.Yellow;
                bt_Auto.BackColor = Color.FromArgb(220, 220, 220);
            }
            else if (Parent.Auto)
            {
                bt_Auto.BackColor = Color.FromArgb(88, 235, 52);
                bt_Manual.BackColor = Color.FromArgb(220, 220, 220);
            }

        }

        private void bt_Start_MouseDown(object sender, MouseEventArgs e)
        {
            if (Parent.Man)
            {
                Parent.Write_Device("Manu_Run", true);
            }
        }

        private void bt_Start_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void bt_Stop_MouseDown(object sender, MouseEventArgs e)
        {
            if (Parent.Man)
            {
                Parent.Write_Device("Manu_Stop", true);
                Parent.Write_Device("Manu_Run", false);
            }
        }

        private void bt_Stop_MouseUp(object sender, MouseEventArgs e)
        {
            if (Parent.Man)
            {
                Parent.Write_Device("Manu_Stop", false);
            }
        }

        private void bt_Auto_Click(object sender, EventArgs e)
        {
            Parent.Write_Device("Auto", true);
            Parent.Write_Device("Manu", false);
        }

        private void bt_Manual_Click(object sender, EventArgs e)
        {
            Parent.Write_Device("Auto", false);
            Parent.Write_Device("Manu", true);
        }

        private void groupBox_Device_Enter(object sender, EventArgs e)
        {

        }
    }
}
