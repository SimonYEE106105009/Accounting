using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 記憶體回收
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Student student = new Student())
            {
                student.OpenNotpad();
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine($"記事本倒數{i}秒後即將關閉");
                    Thread.Sleep(1000);
                }
            }
                

            //using (Student student = new Student())
            //{
            //  for(int i=0;i<10;i++)
            //    {

            //    }
            //}
        }
    }
}
