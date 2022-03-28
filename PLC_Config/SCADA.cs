using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class SCADA
    {
        //Tạo list chứa các task được tạo ra
        List<TASK> TASKS = new List<TASK>();
        //Tạo mới PLC để
        public PLC S7500;
        //Tạo list các class để đọc ghi facePlates
        List<GROUP_2PUMP> GROUP_2PUMPS = new List<GROUP_2PUMP>();
        List<GROUP_1PUMP> GROUP_1PUMPS = new List<GROUP_1PUMP>();
        List<GROUP_4PUMP> GROUP_4PUMPS = new List<GROUP_4PUMP>();
        List<GROUP_4MTK> GROUP_4MTKS = new List<GROUP_4MTK>();
        List<PUMP> PUMPS = new List<PUMP>();
        //Tạo list các form là các faceplates
        public List<GROUP_2PUMP_FacePlate> GROUP_2PUMP_FacePlates = new List<GROUP_2PUMP_FacePlate>();
        public List<GROUP_1PUMP_FacePlate> GROUP_1PUMP_FacePlates = new List<GROUP_1PUMP_FacePlate>();
        public List<GROUP_4PUMP_FacePlate> GROUP_4PUMP_FacePlates = new List<GROUP_4PUMP_FacePlate>();
        public List<GROUP_4MTK_FacePlate> GROUP_4MTK_FacePlates = new List<GROUP_4MTK_FacePlate>();
        public List<PUMP_FacePlateBB> PUMP_FacePlates = new List<PUMP_FacePlateBB>();

        //Các hàm dùng để add các class để đọc ghi facePlates vào list
        public void AddG4P(GROUP_4PUMP pump)
        {
            pump.Parent = this;
            GROUP_4PUMPS.Add(pump);
        }

        public void AddG4MTK(GROUP_4MTK mtk)
        {
            mtk.Parent = this;
            GROUP_4MTKS.Add(mtk);
        }

        public void AddG2P(GROUP_2PUMP pump)
        {
            pump.Parent = this;
            GROUP_2PUMPS.Add(pump);
        }

        public void AddG1P(GROUP_1PUMP pump)
        {
            pump.Parent = this;
            GROUP_1PUMPS.Add(pump);
        }

        public void AddP(PUMP pump)
        {
            pump.Parent = this;
            PUMPS.Add(pump);
        }

        //Các hàm dùng để add các form là các facePlates vào list
        public void AddG4P_FacePlate(GROUP_4PUMP_FacePlate faceplate)
        {
            GROUP_4PUMP_FacePlates.Add(faceplate);
        }

        public void AddG4MTK_FacePlate(GROUP_4MTK_FacePlate faceplate)
        {
            GROUP_4MTK_FacePlates.Add(faceplate);
        }

        public void AddG2P_FacePlate(GROUP_2PUMP_FacePlate faceplate)
        {

            GROUP_2PUMP_FacePlates.Add(faceplate);
        }

        public void AddG1P_FacePlate(GROUP_1PUMP_FacePlate faceplate)
        {
            GROUP_1PUMP_FacePlates.Add(faceplate);
        }
   
        public void AddP_FacePlate(PUMP_FacePlateBB faceplate)
        {
            PUMP_FacePlates.Add(faceplate);
        }

        //Các hàm dùng để chạy Timer cập nhật dữ liệu từ PLC lên tag
        public void RunG4P(string name)
        {
            GROUP_4PUMP pump = null;
            for (int i = 0; i < GROUP_4PUMPS.Count; i++)
            {
                pump = GROUP_4PUMPS[i];
                if (pump.Name == name)
                {
                    pump.Engine();
                }
            }
        }

        public void RunG4MTK(string name)
        {
            GROUP_4MTK pump = null;
            for (int i = 0; i < GROUP_4MTKS.Count; i++)
            {
                pump = GROUP_4MTKS[i];
                if (pump.Name == name)
                {
                    pump.Engine();
                }
            }
        }

        public void RunG2PUMP(string name)
        {
            GROUP_2PUMP pump = null;
            for (int i = 0; i < GROUP_2PUMPS.Count; i++)
            {
                pump = GROUP_2PUMPS[i];
                if (pump.Name == name)
                {
                    pump.Engine();
                }
            }
        }

        public void RunG1PUMP(string name)
        {
            GROUP_1PUMP pump = null;
            for (int i = 0; i < GROUP_1PUMPS.Count; i++)
            {
                pump = GROUP_1PUMPS[i];
                if (pump.Name == name)
                {
                    pump.Engine();
                }
            }
        }

        public void RunP(string name)
        {
            PUMP pump = null;
            for (int i = 0; i < PUMPS.Count; i++)
            {
                pump = PUMPS[i];
                if (pump.Name == name)
                {
                    pump.Engine();
                }
            }
        }

        //Các hàm dùng để tìm kiếm FacePlate trong list
        public PUMP_FacePlateBB FindP_FacePlate(string name)
        {
            PUMP_FacePlateBB facePlate = null;
            for (int i = 0; i < PUMP_FacePlates.Count; i++)
            {
                facePlate = PUMP_FacePlates[i];
                if (facePlate.Name == name)
                {
                    return facePlate;
                }
            }
            return null;
        }

         public GROUP_1PUMP_FacePlate FindG1P_FacePlate(string name)
         {
            GROUP_1PUMP_FacePlate facePlate = null;
            for (int i = 0; i < GROUP_1PUMP_FacePlates.Count; i++)
            {
                facePlate = GROUP_1PUMP_FacePlates[i];
                if (facePlate.Name == name)
                {
                    return facePlate;
                }
            }
            return null;
        }

        public GROUP_2PUMP_FacePlate FindG2P_FacePlate(string name)
        {
            GROUP_2PUMP_FacePlate facePlate = null;
            for (int i = 0; i < GROUP_2PUMP_FacePlates.Count; i++)
            {
                facePlate = GROUP_2PUMP_FacePlates[i];
                if (facePlate.Name == name)
                {
                    return facePlate;
                }
            }
            return null;
        }

        public GROUP_4PUMP_FacePlate FindG4P_FacePlate(string name)
        {
            GROUP_4PUMP_FacePlate facePlate = null;
            for (int i = 0; i < GROUP_4PUMP_FacePlates.Count; i++)
            {
                facePlate = GROUP_4PUMP_FacePlates[i];
                if (facePlate.Name == name)
                {
                    return facePlate;
                }
            }
            return null;
        }

        //Hàm dùng để add Task vào list
        public void AddTask(TASK task)
        {
            task.Parent = this;
            TASKS.Add(task);
        }
        //Hàm dùng để tìm kiếm Task trong list
        public TASK FindTask(string name)
        {
            TASK task = null;
            for (int i = 0; i < TASKS.Count; i++)
            {
                task = TASKS[i];
                if (task.Name == name)
                {
                    return task;
                }
            }
            return null;
        }

        //hàm dùng để chạy timer trong Task để cập nhật value vào tag
        public void RunTask(string name)
        {
            TASK task = null;
            for (int i = 0; i < TASKS.Count; i++)
            {
                task = TASKS[i];
                if (task.Name == name)
                {
                    task.Engine();
                }
            }
        }

        //Hàm dùng để thêm PLC trong đó gán Parent của PLC là SCADA
        public void AddPLC(PLC plc)
        {
            plc.Parent = this;
            S7500 = plc;
        }

    }
}
