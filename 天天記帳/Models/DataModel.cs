using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 天天記帳.Models
{
    public class DataModel
    {
        public static List<String> list = new List<String>()
        {
            "餐費","穿著","住宿","交通","教育","娛樂"
        };
        public static List<String> 餐費 = new List<String>()
        {
            "早餐","午餐","晚餐","下午茶","飲品","宵夜"
        };
        public static List<String> 穿著 = new List<String>()
        {
            "衣服","褲子","鞋子","手套","帽子","包包","其他配件"
        };
        public static List<String> 住宿 = new List<String>()
        {
            "飯店","民宿","Hotel","背包客棧"
        };
        public static List<String> 交通 = new List<String>()
        {
            "交通油錢","火車","高鐵","捷運","計程車或Uber費","租賃車費"
        };
        public static List<String> 教育 = new List<String>()
        {
            "課程費用","書籍費用"
        };
        public static List<String> 娛樂 = new List<String>()
        {
            "電腦遊戲","手機遊戲","KTV","電影","街機遊戲","旅遊門票","模型玩具","演唱會","其他娛樂"
        };
        public static List<String> 餐廳消費店家 = new List<String>()
        {
        "便利商店","餐廳","小吃店","拉麵店","速食店"
        };
        public static List<String> 穿著消費店家 = new List<String>()
        {
        "Uniqlo","GU","NET","網拍","其他"
        };
        public static List<String> 住宿消費店家 = new List<String>()
        {
        "XX背包客棧","OO大飯店","YY民宿","其他"
        };
        public static List<String> 交通消費店家 = new List<String>()
        {
        "統聯客運","國光客運","和欣客運","台中捷運","台北捷運","台鐵","高鐵","其他"
        };
        public static List<String> 教育消費店家 = new List<String>()
        {
        "XX出版社","YY出版社","ZZ出版社","文具店","教育訓練中心"
        };
        public static List<String> 娛樂消費店家 = new List<String>()
        {
        "XXKTV","OO網咖","ZZ電子遊藝場","KK活動中心","AA鏢店"
        };
        public static List<String> 消費對象 = new List<String>()
        {
        "自己","朋友","家人"
        };


        public static Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>()
        {
            {"餐費",餐費},{"穿著",穿著},{"住宿",住宿},{"交通",交通},{"教育",教育},{"娛樂",娛樂}

        };
        public static Dictionary<string, List<string>> keyValueStore = new Dictionary<string, List<string>>()
        {
            {"餐費",餐廳消費店家},{"穿著",穿著消費店家},{"住宿",住宿消費店家},{"交通",交通消費店家},{"教育",教育消費店家},{"娛樂",娛樂消費店家}
        };
        public static Dictionary<string, List<string>> keyValueObject = new Dictionary<string, List<string>>()
        {
            {"餐費",消費對象},{"穿著",消費對象},{"住宿",消費對象},{"交通",消費對象},{"教育",消費對象},{"娛樂",消費對象}
        };
    }
}
