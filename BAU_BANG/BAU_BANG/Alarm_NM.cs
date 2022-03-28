using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBlock;
using PLC_Config;

namespace BAU_BANG
{
    public partial class Alarm_NM : Form
    {
        SCADA Parent;
        Timer UpdateMonitor = new Timer();
        public Alarm_NM(SCADA parent)
        {
            InitializeComponent();
            Parent = parent;
            UpdateAlarm.Interval = 2500;
            UpdateAlarm.Tick += UpdateAlarm_Tick;
            UpdateAlarm.Start();

            UpdateMonitor.Interval = 250;
            UpdateMonitor.Tick += UpdateMonitor_Tick;
            UpdateMonitor.Start();

        }

        private void UpdateMonitor_Tick(object sender, EventArgs e)
        {
            time_stamp.Text = DateTime.Now.ToString();
        }

        public void AlarmStatus(DataGridView datagridview, int tag_update, int tag_last, string alarmText1, string alarmText0)
        {
            if (tag_update != tag_last)
            {
                string[] row = null;
                if (tag_update == 0)
                {
                    row = new string[] { $"{alarmText0}", $"{ DateTime.Now }" };
                    datagridview.Rows.Add(row);
                }
                else
                {
                    row = new string[] { $"{alarmText1}", $"{ DateTime.Now }" };
                    datagridview.Rows.Add(row);
                }
            }
        }

        public void AlarmControl(DataGridView datagridview, int tag, string alarmText)
        {
            string[] row = null;
            if (tag == 1)
            {
                row = new string[] { $"{alarmText}", $"{ DateTime.Now }" };
                datagridview.Rows.Add(row);
            }
        }


        public static bool DeepEquals(object obj, object another)
        {

            if (ReferenceEquals(obj, another)) return true;
            if ((obj == null) || (another == null)) return false;
            //So sánh class của 2 object, nếu khác nhau thì trả fail
            if (obj.GetType() != another.GetType()) return false;

            var result = true;
            //Lấy toàn bộ các properties của obj
            //sau đó so sánh giá trị của từng property
            foreach (var property in obj.GetType().GetProperties())
            {
                var objValue = property.GetValue(obj);
                var anotherValue = property.GetValue(another);
                if (!objValue.Equals(anotherValue)) result = false;
            }

            return result;
        }



        private void UpdateAlarm_Tick(object sender, EventArgs e)
        {
            data_update = Parent.S7500.Alarm;
            Console.WriteLine(Parent.S7500.Alarm.HG_PUMP_Status_P1_Control);
            Console.WriteLine(data_update.HG_PUMP_Status_P1_Control);
            Console.WriteLine(data_last.HG_PUMP_Status_P1_Control);
            Console.WriteLine(DeepEquals(data_update, data_last));


            if(dataGridView1.Rows.Count > 100)
            {
                dataGridView1.Rows.RemoveAt(0);
            }

            //data_update = Parent.S7500.Alarm;



            if (DeepEquals(data_update, data_last) == false)
            {
                if (data_update.HG_PUMP_Status_P1_Control != data_last.HG_PUMP_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.HG_PUMP_Status_P1_Control, "Hố gom bơm 1 điều khiển từ xa");
                }
                if (data_update.HG_PUMP_Status_P2_Control != data_last.HG_PUMP_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.HG_PUMP_Status_P2_Control, "Hố gom bơm 2 điều khiển từ xa");
                }
                if (data_update.DH_PUMP_Status_P1_Control != data_last.DH_PUMP_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.DH_PUMP_Status_P1_Control, "Bể điều hòa bơm 1 điều khiển từ xa");
                }
                if (data_update.DH_PUMP_Status_P2_Control != data_last.DH_PUMP_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.DH_PUMP_Status_P2_Control, "Bể điều hòa bơm 2 điều khiển từ xa");
                }
                if (data_update.DH_MTK_Status_P1_Control != data_last.DH_MTK_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.DH_MTK_Status_P1_Control, "Bể điều hòa máy thổi khí 1 điều khiển từ xa");
                }
                if (data_update.DH_MTK_Status_P2_Control != data_last.DH_MTK_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.DH_MTK_Status_P2_Control, "Bể điều hòa máy thổi khí 2 điều khiển từ xa");
                }
                if (data_update.PAC_KHUAY_Status_Control != data_last.PAC_KHUAY_Status_Control)
                {
                    AlarmControl(dataGridView1, data_update.PAC_KHUAY_Status_Control, "PAC khuấy điều khiển từ xa");
                }
                if (data_update.PAC_KHUAY_BC_Status_Control != data_last.PAC_KHUAY_BC_Status_Control)
                {
                    AlarmControl(dataGridView1, data_update.PAC_KHUAY_BC_Status_Control, "PAC khuấy bồn chứa điều khiển từ xa");
                }
                if (data_update.PAC_PUMP_Status_P1_Control != data_last.PAC_PUMP_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.PAC_PUMP_Status_P1_Control, "PAC bơm định lượng bơm 1 điều khiển từ xa");
                }
                if (data_update.PAC_PUMP_Status_P2_Control != data_last.PAC_PUMP_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.PAC_PUMP_Status_P2_Control, "PAC bơm định lượng bơm 2 điều khiển từ xa");
                }
                if (data_update.PO_KHUAY_Status_Control != data_last.PO_KHUAY_Status_Control)
                {
                    AlarmControl(dataGridView1, data_update.PO_KHUAY_Status_Control, "Polimer khuấy điều khiển từ xa");
                }
                if (data_update.PO_KHUAY_BC_Status_Control != data_last.PO_KHUAY_BC_Status_Control)
                {
                    AlarmControl(dataGridView1, data_update.PO_KHUAY_BC_Status_Control, "Polimer khuấy bồn chứa điều khiển từ xa");
                }
                if (data_update.PO_PUMP_Status_P1_Control != data_last.PO_PUMP_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.PO_PUMP_Status_P1_Control, "Polimer bơm định lượng bơm 1 điều khiển từ xa");
                }
                if (data_update.PO_PUMP_Status_P2_Control != data_last.PO_PUMP_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.PO_PUMP_Status_P2_Control, "Polimer bơm định lượng bơm 2 điều khiển từ xa");
                }
                if (data_update.HL_GATBUN_Status_Control != data_last.HL_GATBUN_Status_Control)
                {
                    AlarmControl(dataGridView1, data_update.HL_GATBUN_Status_Control, "Bể hóa lý gạt bùn điều khiển từ xa");
                }
                if (data_update.HL_PUMP_Status_P1_Control != data_last.HL_PUMP_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.HL_PUMP_Status_P1_Control, "Bể hóa lý bơm bùn 1 điều khiển từ xa");
                }
                if (data_update.HL_PUMP_Status_P2_Control != data_last.HL_PUMP_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.HL_PUMP_Status_P2_Control, "Bể hóa lý bơm bùn 2 điều khiển từ xa");
                }
                if (data_update.ANO_Status_P1_Control != data_last.ANO_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.ANO_Status_P1_Control, "Bể Anoxic khuấy 1 điều khiển từ xa");
                }
                if (data_update.ANO_Status_P2_Control != data_last.ANO_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.ANO_Status_P2_Control, "Bể Anoxic khuấy 2 điều khiển từ xa");
                }
                if (data_update.ANO_Status_P3_Control != data_last.ANO_Status_P3_Control)
                {
                    AlarmControl(dataGridView1, data_update.ANO_Status_P3_Control, "Bể Anoxic khuấy 3 điều khiển từ xa");
                }
                if (data_update.ANO_Status_P4_Control != data_last.ANO_Status_P4_Control)
                {
                    AlarmControl(dataGridView1, data_update.ANO_Status_P4_Control, "Bể Anoxic khuấy 4 điều khiển từ xa");
                }
                if (data_update.HK_MTK_Status_P1_Control != data_last.HK_MTK_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.HK_MTK_Status_P1_Control, "Bể hiếu khí MTK1 điều khiển từ xa");
                }
                if (data_update.HK_MTK_Status_P2_Control != data_last.HK_MTK_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.HK_MTK_Status_P2_Control, "Bể hiếu khí MTK2 điều khiển từ xa");
                }
                if (data_update.HK_MTK_Status_P3_Control != data_last.HK_MTK_Status_P3_Control)
                {
                    AlarmControl(dataGridView1, data_update.HK_MTK_Status_P3_Control, "Bể hiếu khí MTK3 điều khiển từ xa");
                }
                if (data_update.HK_MTK_Status_P4_Control != data_last.HK_MTK_Status_P4_Control)
                {
                    AlarmControl(dataGridView1, data_update.HK_MTK_Status_P4_Control, "Bể hiếu khí MTK4 điều khiển từ xa");
                }
                if (data_update.DLDD_Status_P1_Control != data_last.DLDD_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.DLDD_Status_P1_Control, "Bể hiếu khi bơm định lượng 1 điều khiển từ xa");
                }
                if (data_update.DLDD_Status_P2_Control != data_last.DLDD_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.DLDD_Status_P2_Control, "Bể hiếu khi bơm định lượng 2 điều khiển từ xa");
                }
                if (data_update.HLU_Status_P1_Control != data_last.HLU_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.HLU_Status_P1_Control, "Bể hiếu khí bơm hồi lưu 1 điều khiển từ xa");
                }
                if (data_update.HLU_Status_P2_Control != data_last.HLU_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.HLU_Status_P2_Control, "Bể hiếu khí bơm hồi lưu 2 điều khiển từ xa");
                }
                if (data_update.SH_GATBUN_Status_Control != data_last.SH_GATBUN_Status_Control)
                {
                    AlarmControl(dataGridView1, data_update.SH_GATBUN_Status_Control, "Bể sinh học gạt bùn điều khiển từ xa");
                }
                if (data_update.SH_PUMP_Status_P1_Control != data_last.SH_PUMP_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.SH_PUMP_Status_P1_Control, "Bể sinh học bơm bùn 1 điều khiển từ xa");
                }
                if (data_update.SH_PUMP_Status_P2_Control != data_last.SH_PUMP_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.SH_PUMP_Status_P2_Control, "Bể sinh học bơm bùn 2 điều khiển từ xa");
                }
                if (data_update.KT_PUMP_Status_P1_Control != data_last.KT_PUMP_Status_P1_Control)
                {
                    AlarmControl(dataGridView1, data_update.KT_PUMP_Status_P1_Control, "Bể sinh học bơm bùn 1 điều khiển từ xa");
                }
                if (data_update.KT_PUMP_Status_P2_Control != data_last.KT_PUMP_Status_P2_Control)
                {
                    AlarmControl(dataGridView1, data_update.KT_PUMP_Status_P2_Control, "Bể sinh học bơm bùn 2 điều khiển từ xa");
                }
                if (data_update.BND_Status_Control != data_last.BND_Status_Control)
                {
                    AlarmControl(dataGridView1, data_update.BND_Status_Control, "Bơm nước dư điều khiển từ xa");
                }
                AlarmStatus(dataGridView1, data_update.HG_PUMP_Status_P1_Status, data_last.HG_PUMP_Status_P1_Status, "Hố gom bơm 1 chạy", "Hố gom bơm 1 lỗi");
                AlarmStatus(dataGridView1, data_update.HG_PUMP_Status_P2_Status, data_last.HG_PUMP_Status_P2_Status, "Hố gom bơm 2 chạy", "Hố gom bơm 2 lỗi");
                AlarmStatus(dataGridView1, data_update.DH_PUMP_Status_P1_Status, data_last.DH_PUMP_Status_P1_Status, "Bể điều hòa bơm 1 chạy", "Bể điều hòa bơm 1 lỗi");
                AlarmStatus(dataGridView1, data_update.DH_PUMP_Status_P2_Status, data_last.DH_PUMP_Status_P2_Status, "Bể điều hòa bơm 2 chạy", "Bể điều hòa bơm 2 lỗi");
                AlarmStatus(dataGridView1, data_update.DH_MTK_Status_P1_Status, data_last.DH_MTK_Status_P1_Status, "Bể điều hòa máy thổi khí 1 chạy", "Bể điều hòa máy thổi khí 1 lỗi");
                AlarmStatus(dataGridView1, data_update.PAC_KHUAY_Status_Status, data_last.PAC_KHUAY_Status_Status, "PAC khuấy chạy", "PAC khuấy lỗi");
                AlarmStatus(dataGridView1, data_update.PAC_KHUAY_BC_Status_Status, data_last.PAC_KHUAY_BC_Status_Status, "PAC khuấy bồn chứa chạy", "PAC khuấy bồn chứa lỗi");
                AlarmStatus(dataGridView1, data_update.PAC_PUMP_Status_P1_Status, data_last.PAC_PUMP_Status_P1_Status, "PAC bơm định lượng bơm 1 chạy", "PAC bơm định lượng bơm 1 lỗi");
                AlarmStatus(dataGridView1, data_update.PAC_PUMP_Status_P2_Status, data_last.PAC_PUMP_Status_P2_Status, "PAC bơm định lượng bơm 2 chạy", "PAC bơm định lượng bơm 2 lỗi");
                AlarmStatus(dataGridView1, data_update.PO_KHUAY_Status_Status, data_last.PO_KHUAY_Status_Status, "Polimer khuấy chạy", "Polimer khuấy lỗi");
                AlarmStatus(dataGridView1, data_update.PO_KHUAY_BC_Status_Status, data_last.PO_KHUAY_BC_Status_Status, "Polimer khuấy bồn chứa chạy", "Polimer khuấy bồn chứa lỗi");
                AlarmStatus(dataGridView1, data_update.PO_PUMP_Status_P1_Status, data_last.PO_PUMP_Status_P1_Status, "Polimer bơm định lượng bơm 1 chạy", "Polimer bơm định lượng bơm 1 lỗi");
                AlarmStatus(dataGridView1, data_update.PO_PUMP_Status_P2_Status, data_last.PO_PUMP_Status_P2_Status, "Polimer bơm định lượng bơm 2 chạy", "Polimer bơm định lượng bơm 2 lỗi");
                AlarmStatus(dataGridView1, data_update.HL_GATBUN_Status_Status, data_last.HL_GATBUN_Status_Status, "Bể hóa lý gạt bùn chạy", "Bể hóa lý gạt bùn lỗi");
                AlarmStatus(dataGridView1, data_update.ANO_Status_P1_Status, data_last.ANO_Status_P1_Status, "Bể Anoxic khuấy 1 chạy", "Bể Anoxic khuấy 1 lỗi");
                AlarmStatus(dataGridView1, data_update.ANO_Status_P2_Status, data_last.ANO_Status_P2_Status, "Bể Anoxic khuấy 2 chạy", "Bể Anoxic khuấy 2 lỗi");
                AlarmStatus(dataGridView1, data_update.ANO_Status_P3_Status, data_last.ANO_Status_P3_Status, "Bể Anoxic khuấy 3 chạy", "Bể Anoxic khuấy 3 lỗi");
                AlarmStatus(dataGridView1, data_update.ANO_Status_P4_Status, data_last.ANO_Status_P4_Status, "Bể Anoxic khuấy 4 chạy", "Bể Anoxic khuấy 4 lỗi");
                AlarmStatus(dataGridView1, data_update.HK_MTK_Status_P1_Status, data_last.HK_MTK_Status_P1_Status, "Bể hiếu khí MTK1 chạy", "Bể hiếu khí MTK1 lỗi");
                AlarmStatus(dataGridView1, data_update.HK_MTK_Status_P2_Status, data_last.HK_MTK_Status_P2_Status, "Bể hiếu khí MTK2 chạy", "Bể hiếu khí MTK2 lỗi");
                AlarmStatus(dataGridView1, data_update.HK_MTK_Status_P3_Status, data_last.HK_MTK_Status_P3_Status, "Bể hiếu khí MTK3 chạy", "Bể hiếu khí MTK3 lỗi");
                AlarmStatus(dataGridView1, data_update.HK_MTK_Status_P4_Status, data_last.HK_MTK_Status_P4_Status, "Bể hiếu khí MTK4 chạy", "Bể hiếu khí MTK4 lỗi");
                AlarmStatus(dataGridView1, data_update.DLDD_Status_P1_Status, data_last.DLDD_Status_P1_Status, "Bể hiếu khi bơm định lượng 1 chạy", "Bể hiếu khi bơm định lượng 1 lỗi");
                AlarmStatus(dataGridView1, data_update.DLDD_Status_P2_Status, data_last.DLDD_Status_P2_Status, "Bể hiếu khi bơm định lượng 2 chạy", "Bể hiếu khi bơm định lượng 2 lỗi");
                AlarmStatus(dataGridView1, data_update.HLU_Status_P1_Status, data_last.HLU_Status_P1_Status, "Bể hiếu khí bơm hồi lưu 1 lỗi", "Bể hiếu khí bơm hồi lưu 1 lỗi");
                AlarmStatus(dataGridView1, data_update.HLU_Status_P2_Status, data_last.HLU_Status_P2_Status, "Bể hiếu khí bơm hồi lưu 2 lỗi", "Bể hiếu khí bơm hồi lưu 2 lỗi");
                AlarmStatus(dataGridView1, data_update.SH_GATBUN_Status_Status, data_last.SH_GATBUN_Status_Status, "Bể sinh học gạt bùn chạy", "Bể sinh học gạt bùn lỗi");
                AlarmStatus(dataGridView1, data_update.SH_PUMP_Status_P1_Status, data_last.SH_PUMP_Status_P1_Status, "Bể sinh học bơm bùn 1 chạy", "Bể sinh học bơm bùn 1 lỗi");
                AlarmStatus(dataGridView1, data_update.SH_PUMP_Status_P2_Status, data_last.SH_PUMP_Status_P2_Status, "Bể sinh học bơm bùn 2 chạy", "Bể sinh học bơm bùn 2 lỗi");
                AlarmStatus(dataGridView1, data_update.KT_PUMP_Status_P1_Status, data_last.KT_PUMP_Status_P1_Status, "Bể khử trùng bơm định lượng 1 chạy", "Bể khử trùng bơm định lượng 1 lỗi");
                AlarmStatus(dataGridView1, data_update.KT_PUMP_Status_P2_Status, data_last.KT_PUMP_Status_P2_Status, "Bể khử trùng bơm định lượng 2 chạy", "Bể khử trùng bơm định lượng 2 lỗi");
                AlarmStatus(dataGridView1, data_update.BND_Status_Status, data_last.BND_Status_Status, "Bơm nước dư chạy", "Bơm nước dư lỗi");
                //DeepSetGetAdvanced(data_last, data_update);
                data_last.HG_PUMP_Status_P1_Control = data_update.HG_PUMP_Status_P1_Control;
                data_last.HG_PUMP_Status_P2_Control = data_update.HG_PUMP_Status_P2_Control;
                data_last.DH_PUMP_Status_P1_Control = data_update.DH_PUMP_Status_P1_Control;
                data_last.DH_PUMP_Status_P2_Control = data_update.DH_PUMP_Status_P2_Control;
                data_last.DH_MTK_Status_P1_Control = data_update.DH_MTK_Status_P1_Control;
                data_last.DH_MTK_Status_P2_Control = data_update.DH_MTK_Status_P2_Control;
                data_last.PAC_KHUAY_Status_Control = data_update.PAC_KHUAY_Status_Control;
                data_last.PAC_KHUAY_BC_Status_Control = data_update.PAC_KHUAY_BC_Status_Control;
                data_last.PAC_PUMP_Status_P1_Control = data_update.PAC_PUMP_Status_P1_Control;
                data_last.PAC_PUMP_Status_P2_Control = data_update.PAC_PUMP_Status_P2_Control;
                data_last.PO_KHUAY_Status_Control = data_update.PO_KHUAY_Status_Control;
                data_last.PO_KHUAY_BC_Status_Control = data_update.PO_KHUAY_BC_Status_Control;
                data_last.PO_PUMP_Status_P1_Control = data_update.PO_PUMP_Status_P1_Control;
                data_last.PO_PUMP_Status_P2_Control = data_update.PO_PUMP_Status_P2_Control;
                data_last.HL_GATBUN_Status_Control = data_update.HL_GATBUN_Status_Control;
                data_last.HL_PUMP_Status_P1_Control = data_update.HL_PUMP_Status_P1_Control;
                data_last.HL_PUMP_Status_P2_Control = data_update.HL_PUMP_Status_P2_Control;
                data_last.ANO_Status_P1_Control = data_update.ANO_Status_P1_Control;
                data_last.ANO_Status_P2_Control = data_update.ANO_Status_P2_Control;
                data_last.ANO_Status_P3_Control = data_update.ANO_Status_P3_Control;
                data_last.ANO_Status_P4_Control = data_update.ANO_Status_P4_Control;
                data_last.HK_MTK_Status_P1_Control = data_update.HK_MTK_Status_P1_Control;
                data_last.HK_MTK_Status_P2_Control = data_update.HK_MTK_Status_P2_Control;
                data_last.HK_MTK_Status_P3_Control = data_update.HK_MTK_Status_P3_Control;
                data_last.HK_MTK_Status_P4_Control = data_update.HK_MTK_Status_P4_Control;
                data_last.DLDD_Status_P1_Control = data_update.DLDD_Status_P1_Control;
                data_last.DLDD_Status_P2_Control = data_update.DLDD_Status_P2_Control;
                data_last.HLU_Status_P1_Control = data_update.HLU_Status_P1_Control;
                data_last.HLU_Status_P2_Control = data_update.HLU_Status_P2_Control;
                data_last.SH_GATBUN_Status_Control = data_update.SH_GATBUN_Status_Control;
                data_last.SH_PUMP_Status_P1_Control = data_update.SH_PUMP_Status_P1_Control;
                data_last.SH_PUMP_Status_P2_Control = data_update.SH_PUMP_Status_P2_Control;
                data_last.KT_PUMP_Status_P1_Control = data_update.KT_PUMP_Status_P1_Control;
                data_last.KT_PUMP_Status_P2_Control = data_update.KT_PUMP_Status_P2_Control;
                data_last.BND_Status_Control = data_update.BND_Status_Control;
                data_last.HG_PUMP_Status_Float = data_update.HG_PUMP_Status_Float;
                data_last.DH_PUMP_Status_Float = data_update.DH_PUMP_Status_Float;
                data_last.BND_Status_Float = data_update.BND_Status_Float;
                data_last.HG_PUMP_Status_P1_Status = data_update.HG_PUMP_Status_P1_Status;
                data_last.HG_PUMP_Status_P2_Status = data_update.HG_PUMP_Status_P2_Status;
                data_last.DH_PUMP_Status_P1_Status = data_update.DH_PUMP_Status_P1_Status;
                data_last.DH_PUMP_Status_P2_Status = data_update.DH_PUMP_Status_P2_Status;
                data_last.DH_MTK_Status_P1_Status = data_update.DH_MTK_Status_P1_Status;
                data_last.DH_MTK_Status_P2_Status = data_update.DH_MTK_Status_P2_Status;
                data_last.PAC_KHUAY_Status_Status = data_update.PAC_KHUAY_Status_Status;
                data_last.PAC_KHUAY_BC_Status_Status = data_update.PAC_KHUAY_BC_Status_Status;
                data_last.PAC_PUMP_Status_P1_Status = data_update.PAC_PUMP_Status_P1_Status;
                data_last.PAC_PUMP_Status_P2_Status = data_update.PAC_PUMP_Status_P2_Status;
                data_last.PO_KHUAY_Status_Status = data_update.PO_KHUAY_Status_Status;
                data_last.PO_KHUAY_BC_Status_Status = data_update.PO_KHUAY_BC_Status_Status;
                data_last.PO_PUMP_Status_P1_Status = data_update.PO_PUMP_Status_P1_Status;
                data_last.PO_PUMP_Status_P2_Status = data_update.PO_PUMP_Status_P2_Status;
                data_last.HL_GATBUN_Status_Status = data_update.HL_GATBUN_Status_Status;
                data_last.HL_PUMP_Status_P1_Status = data_update.HL_PUMP_Status_P1_Status;
                data_last.HL_PUMP_Status_P2_Status = data_update.HL_PUMP_Status_P2_Status;
                data_last.ANO_Status_P1_Status = data_update.ANO_Status_P1_Status;
                data_last.ANO_Status_P2_Status = data_update.ANO_Status_P2_Status;
                data_last.ANO_Status_P3_Status = data_update.ANO_Status_P3_Status;
                data_last.ANO_Status_P4_Status = data_update.ANO_Status_P4_Status;
                data_last.HK_MTK_Status_P1_Status = data_update.HK_MTK_Status_P1_Status;
                data_last.HK_MTK_Status_P2_Status = data_update.HK_MTK_Status_P2_Status;
                data_last.HK_MTK_Status_P3_Status = data_update.HK_MTK_Status_P3_Status;
                data_last.HK_MTK_Status_P4_Status = data_update.HK_MTK_Status_P4_Status;
                data_last.DLDD_Status_P1_Status = data_update.DLDD_Status_P1_Status;
                data_last.DLDD_Status_P2_Status = data_update.DLDD_Status_P2_Status;
                data_last.HLU_Status_P1_Status = data_update.HLU_Status_P1_Status;
                data_last.HLU_Status_P2_Status = data_update.HLU_Status_P2_Status;
                data_last.SH_GATBUN_Status_Status = data_update.SH_GATBUN_Status_Status;
                data_last.SH_PUMP_Status_P1_Status = data_update.SH_PUMP_Status_P1_Status;
                data_last.SH_PUMP_Status_P2_Status = data_update.SH_PUMP_Status_P2_Status;
                data_last.KT_PUMP_Status_P1_Status = data_update.KT_PUMP_Status_P1_Status;
                data_last.KT_PUMP_Status_P2_Status = data_update.KT_PUMP_Status_P2_Status;
                data_last.BND_Status_Status = data_update.BND_Status_Status;

            }

        }

        DB_Alarm data_last = new DB_Alarm();
        DB_Alarm data_update = new DB_Alarm();

        Timer UpdateAlarm = new Timer();

        private void bt_System_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_Alarm_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You are here bro");
        }
    }
}
