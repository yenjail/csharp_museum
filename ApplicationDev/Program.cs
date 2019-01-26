using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDev
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
            Application.Run(new Dashboard(readVisitors()));
        }
        public static List<string> readVisitors()
        {
            List<string> ls = new List<string>();
            using (StreamReader sr = new StreamReader("../../../desm.csv"))
            {
                string line;


                int i = 0;
                

                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    ls.Add(line);

                    Console.WriteLine(ls);
                    


                }
            }

            return ls;

        }

    
    }
}
