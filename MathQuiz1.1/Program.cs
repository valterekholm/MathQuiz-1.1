using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz1._1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// Mono's support for System.Windows.Forms as of .NET 2.0 is announced as complete;[15] also System.Windows.Forms 2.0 works natively on Mac OS X
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
