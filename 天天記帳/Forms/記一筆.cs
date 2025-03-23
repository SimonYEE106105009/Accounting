using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 天天記帳.Models;

namespace 天天記帳.Forms
{
    public partial class 記一筆 : Form
    {
        public 記一筆()
        {
            InitializeComponent();
        }

        private void navbar1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 記一筆_Load(object sender, EventArgs e)
        {
            Type_comboBox.DataSource = DataModel.list;
        }

        private void Type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Purpose_comboBox.DataSource  = DataModel.keyValuePairs[Type_comboBox.Text];

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter writer = new StreamWriter("data.csv",true);
            writer.WriteLine("日期,消費金額,消費類型,消費目的,消費對象,消費店家,備註");
            writer.WriteLine($"{dateTimePicker1.Value.ToString("yyyy-MM-dd")},{ Number_textBox.Text},{ Type_comboBox.Text},{ Purpose_comboBox.Text}, {Object_comboBox.Text},{ Store_comboBox.Text},{ Remark_textBox.Text}");
            //writer.WriteLine(Number_textBox.Text);
            //writer.WriteLine(Type_comboBox.Text);
            //writer.WriteLine(Purpose_comboBox.Text);
            //writer.WriteLine(Object_comboBox.Text);
            //writer.WriteLine(Store_comboBox.Text);
            //writer.WriteLine(Remark_textBox.Text);
            writer.Flush();
            writer.Close();
            dateTimePicker1.Text = "";
            Number_textBox.Text = "";
            Type_comboBox.Text = "";
            Purpose_comboBox.Text = "";
            Object_comboBox.Text = "";
            Store_comboBox.Text = "";
            Remark_textBox.Text = "";

            //Console.WriteLine(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            //Console.WriteLine(Number_textBox.Text);
            //Console.WriteLine(Type_comboBox.Text);
            //Console.WriteLine(Purpose_comboBox.Text);
            //Console.WriteLine(Object_comboBox.Text);
            //Console.WriteLine(Store_comboBox.Text);
            //Console.WriteLine(Remark_textBox.Text);
            //List<string> data = new List<string>();
            //data.Add(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            //data.Add(Number_textBox.Text);
            //data.Add(Type_comboBox.Text);
            //data.Add(Purpose_comboBox.Text);
            //data.Add(Object_comboBox.Text);
            //data.Add(Store_comboBox.Text);
            //data.Add(Remark_textBox.Text);


        }

        private void Number_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purpose_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Object_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Store_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Remark_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("data.csv");
            List<RecordModel> models = new List<RecordModel>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] data = line.Split(',');
                RecordModel model = new RecordModel(data[0], data[1], data[2], data[3], data[4], data[5], data[6]);
                models.Add(model);
            }
            foreach ( var model in models )
            {
                Console.WriteLine(model.Number);
            }
        }
    }
}
