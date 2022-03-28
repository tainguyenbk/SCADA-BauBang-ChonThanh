using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SCADA_Module
{
    public class MongoDB_Config
    {
        public class HoatDong
        {
            public object Id { get; set; }
            public DateTime TimeStamp { get; set; }
            public string P0101 { get; set; }
            public string P0102 { get; set; }
            public string P0103 { get; set; }
            public string P0201 { get; set; }
            public string P0202 { get; set; }
            public string P0301 { get; set; }
            public string P0302 { get; set; }
            public string CP2 { get; set; }
            public string CP3 { get; set; }
            public string SM01 { get; set; }
            public string SM02 { get; set; }
            public string SM03 { get; set; }
            public string SM04 { get; set; }
            public string MTK1 { get; set; }
            public string MTK2 { get; set; }
            public string MTK3 { get; set; }
            public string MTK4 { get; set; }
            public string MTK5 { get; set; }
            public string MTK6 { get; set; }
            public string MTK7 { get; set; }
            public string MC3 { get; set; }
            public string MC4A { get; set; }
            public string MC4B { get; set; }
            public string MC5A { get; set; }
            public string MC5B { get; set; }
            public string MC6 { get; set; }
            public string MS2 { get; set; }
            public string MS1 { get; set; }
            public string MI1 { get; set; }
            public string MI2 { get; set; }
            public string DP1 { get; set; }
            public string DP2 { get; set; }
            public string DP3 { get; set; }
            public string DP4 { get; set; }
            public string DP5 { get; set; }
            public string DP6 { get; set; }
            public string DP7 { get; set; }
            public string DP8 { get; set; }


        }

        public class QuanTrac
        {
            public object Id { get; set; }
            public DateTime TimeStamp { get; set; }
            public string COD { get; set; }
            public string TSS { get; set; }
            public string PH { get; set; }
            public string AMONI { get; set; }
            public string TEMP { get; set; }
            public string COLOR { get; set; }
            public string FLOW_IN { get; set; }
            public string FLOW_OUT { get; set; }
            public string FLOW_TOTAL_OUT { get; set; }
            public string FLOW_TOTAL_IN { get; set; }
        }

        //hien thi du lieu dang Bindinglist hien thi ra datagridview dataGridview.DataSource = return this.
        public BindingList<HoatDong> MongoQuery_HoatDong(string connectionstring, string database_, string collection, DateTime fromdate, DateTime todate)
        {
            try
            {
                var client = new MongoClient(connectionstring);
                var database = client.GetDatabase(database_);
                var collec = database.GetCollection<HoatDong>(collection);
                BindingList<HoatDong> doclist = new BindingList<HoatDong>();
                var min = fromdate;
                var max = todate;
                foreach (var deger in collec.Find(x => x.TimeStamp > min && x.TimeStamp < max).ToList())
                {
                    doclist.Add(deger);
                    Application.DoEvents();
                }
                return doclist;
            }
            catch
            {
                Console.WriteLine("Error when query database");
                return null;
            }

        }

        public BindingList<QuanTrac> MongoQuery_QuanTrac(string connectionstring, string database_, string collection, DateTime fromdate, DateTime todate)
        {
            try
            {
                var client = new MongoClient(connectionstring);
                var database = client.GetDatabase(database_);
                var collec = database.GetCollection<QuanTrac>(collection);
                BindingList<QuanTrac> doclist = new BindingList<QuanTrac>();
                var min = fromdate;
                var max = todate;
                foreach (var deger in collec.Find(x => x.TimeStamp > min && x.TimeStamp < max).ToList())
                {
                    doclist.Add(deger);
                    Application.DoEvents();
                }
                return doclist;
            }
            catch
            {
                Console.WriteLine("Error when query database");
                return null;
            }

        }


        //Insert du lieu sang MongoDB duoi dang Bson document.
        public void MongoInsert(string connectionstring, string database_, string collection, BsonDocument document)
        {
            try
            {
                var client = new MongoClient(connectionstring);
                var database = client.GetDatabase(database_);
                var collec = database.GetCollection<BsonDocument>(collection);
                collec.InsertOneAsync(document);
            }
            catch
            {
                Console.WriteLine("Error when insert Bson doc to MongoDB");
            }
        }

        //xoa du lieu theo ngay dươc dua vao
        public void MongoDelete(string connectionstring, string database_, string collection, DateTime fromtime, string TimeStampKey)
        {
            try
            {
                var client = new MongoClient(connectionstring);
                var database = client.GetDatabase(database_);
                var collec = database.GetCollection<BsonDocument>(collection);
                var dataQuery = new BsonDocument
            {
                {TimeStampKey,new BsonDocument {
                    {"$lt",fromtime}
                } }
            };
                var resule = collec.DeleteMany(dataQuery);
            }
            catch
            {
                Console.WriteLine("Error when remove Bson doc from MongoDB");
            }

        }
    }
}
