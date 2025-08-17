using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 天天記帳.Forms;

namespace 天天記帳.Components
{
    public partial class Navbar : UserControl
    {

        public Navbar()
        {
            InitializeComponent();
            var temp =  Assembly.GetExecutingAssembly().DefinedTypes;
            var formName = temp.Where(x => x.BaseType== typeof(Form)&&x.Namespace == "天天記帳.Forms").Select(x=> x.Name).ToList();
            int Value = (flowLayoutPanel1.Width / formName.Count) - 20;

            for (int i = 0; i < formName.Count; i++)
            {
                Button button = new Button();
                button.Text = formName[i];
                button.Click += ChangePage_Click;
                button.Width = Value;
                button.Height = 50;
                flowLayoutPanel1.Controls.Add(button);
            }
           


        }
        
        private void ChangePage_Click(object sender, EventArgs e)
        {
            #region
            //Button clickedButton = sender as Button;
            //string button = ((Button)sender).Text;
            //Form form = SingletonForm.GetInstance(button);
            //clickedButton.Enabled = false;
            //form.Show();
            #endregion
            Button clickedButton = sender as Button;
            string buttonText = clickedButton.Text;
            Form targetForm = SingletonForm.GetInstance(buttonText);
            FieldInfo navbarField = targetForm.GetType().GetField("navbar1", BindingFlags.NonPublic | BindingFlags.Instance);
            Navbar navbar = (Navbar)navbarField.GetValue(targetForm);
            foreach (Button button in navbar.flowLayoutPanel1.Controls)
            {
                if ( button.Text == buttonText)
                {
                    button.Enabled = false; // 禁用按鈕
                    break;
                }
            }
            targetForm.Show();

            // Student std = new Student();
            // CSV.WriteLine($"{std.Id},{std.Name},{std.Address},{std.Phone},{std.Score}");

            // string[] datas;
            // std.Id = datas[0];
            // std.Name = datas[1];
            // std.Address = datas[2];
            // std.Phnoe = datas[3];
            // std.Score = datas[4];

        }

     
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
