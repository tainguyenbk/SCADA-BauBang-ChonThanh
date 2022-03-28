using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class TASK
    {
        //Lấy SCADA làm Parent của TASK
        public SCADA Parent;
        public string Name;
        //Tạo List chứa các TAG được tạo ra
        public List<TAG> TAGS = new List<TAG>();
        int Period;
        //Tạo Timer để cập nhật tag value và tag timestamp
        public System.Timers.Timer UpdateTimer = null;
        //Khai tạo mới TASK thì khai báo task name và thời gian cập nhật tag trong task đó.
        public TASK(string name, int period)
        {
            Name = name;
            Period = period;
        }

        //Hàm dùng để thêm 1 tag vào list tag, gán Parent của tag vừa mới tạo ra bằng TASK
        //
        public void AddTag(TAG tag)
        {
            tag.Parent = this;
            TAGS.Add(tag);
        }
        //Hàm dùng để tìm kiếm tag trong list theo tag name
        public TAG FindTag(string name)
        {
            TAG tag = null;
            for (int i = 0; i < TAGS.Count; i++)
            {
                tag = TAGS[i];
                if (tag.Name == name)
                {
                    return tag;
                }
            }
            return null;
        }

        //Hàm dùng để cập nhật tag value va tag timestamp
        public void Engine()
        {
            UpdateTimer = new System.Timers.Timer(Period);
            UpdateTimer.AutoReset = true;
            UpdateTimer.Elapsed += UpdateTimer_Elapsed;
            UpdateTimer.Start();
        }

        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TAG tag;
            for (int i = 0; i < TAGS.Count; i++)
            {
                tag = TAGS[i];
                string[] temp = tag.Address.Split('.');
                string obj = temp[0];
                string signal = temp[1];
                switch (obj)
                {
                    case "DB_DATA":
                        switch (signal)
                        {
                            case "HG_PUMP_Status_1":
                                tag.Value = Parent.S7500.Data.HG_PUMP_Status_1;
                                break;
                            case "HG_PUMP_Status_2":
                                tag.Value = Parent.S7500.Data.HG_PUMP_Status_2;
                                break;

                            case "DH_PUMP_Status_1":
                                tag.Value = Parent.S7500.Data.DH_PUMP_Status_1;
                                break;
                            case "DH_PUMP_Status_2":
                                tag.Value = Parent.S7500.Data.DH_PUMP_Status_2;
                                break;

                            case "DH_MTK_Status_1":
                                tag.Value = Parent.S7500.Data.DH_MTK_Status_1;
                                break;
                            case "DH_MTK_Status_2":
                                tag.Value = Parent.S7500.Data.DH_MTK_Status_2;
                                break;

                            case "PAC_KHUAY_Status":
                                tag.Value = Parent.S7500.Data.PAC_KHUAY_Status;
                                break;

                            case "PAC_KHUAY_BC_Status":
                                tag.Value = Parent.S7500.Data.PAC_KHUAY_BC_Status;
                                break;

                            case "PAC_PUMP_Status_1":
                                tag.Value = Parent.S7500.Data.PAC_PUMP_Status_1;
                                break;
                            case "PAC_PUMP_Status_2":
                                tag.Value = Parent.S7500.Data.PAC_PUMP_Status_2;
                                break;

                            case "PO_KHUAY_Status":
                                tag.Value = Parent.S7500.Data.PO_KHUAY_Status;
                                break;
                            case "PO_KHUAY_BC_Status":
                                tag.Value = Parent.S7500.Data.PO_KHUAY_BC_Status;
                                break;

                            case "PO_PUMP_Status_1":
                                tag.Value = Parent.S7500.Data.PO_PUMP_Status_1;
                                break;
                            case "PO_PUMP_Status_2":
                                tag.Value = Parent.S7500.Data.PO_PUMP_Status_2;
                                break;

                            case "HL_GATBUN_Status":
                                tag.Value = Parent.S7500.Data.HL_GATBUN_Status;
                                break;

                            case "HL_PUMP_Status_1":
                                tag.Value = Parent.S7500.Data.HL_PUMP_Status_1;
                                break;
                            case "HL_PUMP_Status_2":
                                tag.Value = Parent.S7500.Data.HL_PUMP_Status_2;
                                break;

                            case "ANO_Status_1":
                                tag.Value = Parent.S7500.Data.ANO_Status_1;
                                break;
                            case "ANO_Status_2":
                                tag.Value = Parent.S7500.Data.ANO_Status_2;
                                break;

                            case "ANO_Status_3":
                                tag.Value = Parent.S7500.Data.ANO_Status_3;
                                break;
                            case "ANO_Status_4":
                                tag.Value = Parent.S7500.Data.ANO_Status_4;
                                break;

                            case "HK_MTK_Status_1":
                                tag.Value = Parent.S7500.Data.HK_MTK_Status_1;
                                break;
                            case "HK_MTK_Status_2":
                                tag.Value = Parent.S7500.Data.HK_MTK_Status_2;
                                break;

                            case "HK_MTK_Status_3":
                                tag.Value = Parent.S7500.Data.HK_MTK_Status_3;
                                break;
                            case "HK_MTK_Status_4":
                                tag.Value = Parent.S7500.Data.HK_MTK_Status_4;
                                break;

                            case "DLDD_Status_1":
                                tag.Value = Parent.S7500.Data.DLDD_Status_1;
                                break;
                            case "DLDD_Status_2":
                                tag.Value = Parent.S7500.Data.DLDD_Status_2;
                                break;

                            case "HLU_Status_1":
                                tag.Value = Parent.S7500.Data.HLU_Status_1;
                                break;
                            case "HLU_Status_2":
                                tag.Value = Parent.S7500.Data.HLU_Status_2;
                                break;

                            case "SH_GATBUN_Status":
                                tag.Value = Parent.S7500.Data.SH_GATBUN_Status;
                                break;

                            case "SH_PUMP_Status_1":
                                tag.Value = Parent.S7500.Data.SH_PUMP_Status_1;
                                break;
                            case "SH_PUMP_Status_2":
                                tag.Value = Parent.S7500.Data.SH_PUMP_Status_2;
                                break;

                            case "KT_PUMP_Status_1":
                                tag.Value = Parent.S7500.Data.KT_PUMP_Status_1;
                                break;
                            case "KT_PUMP_Status_2":
                                tag.Value = Parent.S7500.Data.KT_PUMP_Status_2;
                                break;

                            case "BND_Status":
                                tag.Value = Parent.S7500.Data.BND_Status;
                                break;
                        }
                        break;
                }
            }
        }
    }
}
