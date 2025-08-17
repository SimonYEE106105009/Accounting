using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 記憶體回收
{
    class Student : IDisposable
    {
        Process notePad = null;
        public void OpenNotpad()
        {
            notePad = new Process();
            // FileName 是要執行的檔案
            notePad.StartInfo.FileName = "notepad.exe";
            notePad.Start();
        }
        public void Dispose()
        {
            notePad.CloseMainWindow();
        }
        //受控代表GC可以回收；非受控代表GC無法回收
    }
}
