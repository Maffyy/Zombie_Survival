using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Survival._1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DateTime currentUpdateTime;
            DateTime lastUpdateTime;
            TimeSpan frameTime;
            currentUpdateTime = DateTime.Now;
            lastUpdateTime = DateTime.Now;

            Form2 form = new Form2();
            
            form.Show();
            while (form.Created == true)
            {
                currentUpdateTime = DateTime.Now;
                frameTime = currentUpdateTime - lastUpdateTime;
                if (frameTime.TotalMilliseconds > 20)
                {
                    Application.DoEvents();
                    form.Refresh();
                    lastUpdateTime = DateTime.Now;
                }
            }
           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
        }

    }
}
