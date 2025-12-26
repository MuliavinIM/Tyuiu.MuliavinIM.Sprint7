using System;
using System.Windows.Forms;

namespace Tyuiu.MuliavinIM.Sprint7.Project.V14
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain_MIM());
        }
    }
}
