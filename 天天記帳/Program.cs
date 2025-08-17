using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using 天天記帳.Components;
using 天天記帳.Forms;

namespace 天天記帳
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form = SingletonForm.GetInstance("記帳本");
            Application.Run(form);
        }
    }
}
