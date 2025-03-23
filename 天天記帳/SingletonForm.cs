using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 天天記帳.Components;
using 天天記帳.Forms;

namespace 天天記帳
{
    internal class SingletonForm
    {

        static Dictionary<string,Form> forms = new Dictionary<string,Form>();
        static Form form = null;

        public static Form GetInstance(string formType)
        {
            // 使用者會傳入 fromType變數來告訴你他要的是甚麼Form
            // 你需要根據他要的form給予對應的 form instance
            // 因此需要檢查dictionary 如果這個instance 不存在，則創進form instance 並且放到dictionary裡面
            // 如果存在，則從dictionary中取出並且返回form的實體

            if (form != null)
            {
                form.Hide();
            }
            if (forms.ContainsKey(formType))
            {
                form = forms[formType];
                return form;
            }

            string formName = "天天記帳.Forms." + formType;
            // 反射
            Type type = Type.GetType(formName);
            form = (Form)Activator.CreateInstance(type);
            #region
            //switch (formType)
            //{
            //    case "記一筆":
            //        form = new 記一筆();
            //        break;
            //    case "記帳本":
            //        form = new 記帳本();
            //        break;
            //    case "帳目分析":
            //        form = new 帳目分析();
            //        break;
            //    case "圖表分析":
            //        form = new 圖表分析();
            //        break;
            //}
            #endregion
            forms.Add(formType, form);
            return form;
        }

    }
}
