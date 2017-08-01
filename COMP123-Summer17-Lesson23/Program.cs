using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Summer17_Lesson23
    //Name: Alessandro da Silva Santos
    //Data: August 1, 2017
    //Description: Demo Application to showcase windows forms and UI controls 
    //Version: 0.1 - Project was created 
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DemoForm());
        }
    }
}
