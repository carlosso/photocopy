using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace fotocopy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            String vychoziAdresar;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                vychoziAdresar = args[0];
            }
            else
            {
                vychoziAdresar = "";
            }
            Application.Run(new Form1(vychoziAdresar));
        }
    }
}
