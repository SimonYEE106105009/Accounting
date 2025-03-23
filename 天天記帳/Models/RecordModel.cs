using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 天天記帳.Models
{
    internal class RecordModel
    {
        public string Date { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public string Purpose { get; set; }
        public string Object { get; set; }
        public string Store { get; set; }
        public string Remark { get; set; }

        public RecordModel(string date,string number, string type, string purpose, string object1,string store,string remark) 
        {
            Date = date;
            Number = number;
            Type = type;
            Purpose = purpose;
            Object = object1;
            Store = store;
            Remark = remark;
        }
    }
}
