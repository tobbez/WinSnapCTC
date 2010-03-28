using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSnapCTC
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 2 || !args[0].Contains("{0}"))
            {
                System.Windows.Forms.MessageBox.Show("Usage: WinSnapCTC.exe [format string] %IMGPATH%\nSee documentation for more information.", "WinSnapCTC");
                return;
            }

            System.Windows.Forms.Clipboard.SetText(string.Format(args[0], System.IO.Path.GetFileName(args[1])));
        }
    }
}
