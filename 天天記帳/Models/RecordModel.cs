using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 天天記帳.Attributes;

namespace 天天記帳.Models
{
    internal class RecordModel
    {
        [DisplayName("記帳日期")]
        public string Date { get; set; }

        [DisplayName("金額")]
        public string Number { get; set; }

        [DisplayName("消費類型")]
        [ComboBoxColumn]
        public string Type { get; set; }

        [DisplayName("消費目的")]
        [ComboBoxColumn]
        public string Purpose { get; set; }

        [DisplayName("消費對象")]
        [ComboBoxColumn]
        public string Object { get; set; }

        [DisplayName("消費店家")]
        [ComboBoxColumn]
        public string Store { get; set; }

        [DisplayName("備註")]
        public string Remark { get; set; }

        [DisplayName("收據圖片１")]
        [ImageColumn]
        public string Imagepath1 {  get; set; }

        [DisplayName("收據圖片２")]
        [ImageColumn]
        public string Imagepath2 { get; set; }


        public RecordModel(string date,string number, string type, string purpose, string object1,string store,string imagepath1,string imagepath2,string remark) 
        {
            Date = date;
            Number = number;
            Type = type;
            Purpose = purpose;
            Object = object1;
            Store = store;
            Remark = remark;
            Imagepath1 = imagepath1;
            Imagepath2 = imagepath2;
        }

        public RecordModel()
        {

        }
    }
}
