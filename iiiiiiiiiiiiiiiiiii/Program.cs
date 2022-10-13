using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Threading;
using System.Drawing;

namespace iiiiiiiiiiiiiiiiiii
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
            {
                SystemInfo.LogicalProcessors += int.Parse(item["NumberOfLogicalProcessors"].ToString());
                Console.WriteLine("Number Of Logical Processors: {0}", item["NumberOfLogicalProcessors"]);
            }
        


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            
         
        }
    }
}
