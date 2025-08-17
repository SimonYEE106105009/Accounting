using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace 天天記帳.Forms
{
    public partial class 其他 : Form
    {
        int count = 0;

        private void button9_Click(object sender, EventArgs e)
        {
            //宣告timer要做什麼事.要做什麼事呢?要做_do的事
            //1.function 2.開關  3.等多久再開始  4.隔多久反覆執行

            //HW: 將DebounceTime 改寫成 擴充方法，擴充到Form 身上
            //this.DebounceTime((data) => {
            //    count++;
            //    this.Invoke(new Action(() => label1.Text = count.ToString()));
            //}, 400);


            this.DebounceTime((data) => {
                count++;
                label1.Text = count.ToString();
            }, 400);


        }

        private void _do(object state)
        {
            count++;
            //子執行緒沒有權限可以存取UI畫面
            //只有UI Thread 也就是 主執行緒 可以控制畫面，其他的執行緒都不能控制
            //this.Invoke(new Action(() => label1.Text = DateTime.Now.ToString("hh:mm:ss")));
            this.Invoke(new Action(() => label1.Text = count.ToString()));
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            
            //label1.Text=DateTime.Now.ToString("hh:mm:ss");
        }



        public 其他()
        {
            InitializeComponent();
        }

        private void navbar1_Load(object sender, EventArgs e)
        {

        }
    }
}
