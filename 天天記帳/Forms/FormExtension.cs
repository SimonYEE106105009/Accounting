using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 天天記帳.Forms
{
    internal static class FormExtension 
    {
        static System.Threading.Timer timer = null;
        static Form form1;
        static Action<object> action1;
        
        public static void DebounceTime(this Form form,Action<object> action, int duration)
        {
            if (timer != null)
            {
                timer.Change(duration, -1);
            }
            else
            {
                form1 = form;
                action1 = action;
                timer = new System.Threading.Timer(CallBack, null, duration, -1);
            }
        }

        private static void CallBack(object state)
        {
            form1.Invoke(new Action(() => action1.Invoke("Hello")));
        }
    }
}
