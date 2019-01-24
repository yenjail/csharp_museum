using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDev
{
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
            List<string> ls = checkin();
            int visitorsCountMonday = 0;
            int totalMinMonday = 0;
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            for (int i = 0; i < days.Length ; i++)
            {
                int visitors = 0;
                int totalMin = 0;
                var visit2 = from date in ls
                             where date.Contains(days[i])
                             select date;

                List<string> cards1 = new List<string>();
                foreach (string s in visit2)
                {


                    string vals = s.ToString();
                    string[] n = vals.Split(',');
                    cards1.Add(n[0]);
                }

                var uniq1 = cards1.Distinct();
                foreach (var u in uniq1)
                {
                    visitors = visitors + 1;

                }
                //minutes
                foreach (string t in ls)
                {

                    //Console.WriteLine(i);
                    var values = t.Split(',').ToList();


                    var qTotalTime = from date in values
                                     where date.Contains(days[i])
                                     select values[6];



                    foreach (var name in qTotalTime)
                    {

                        if (name != null && name != "")
                        {
                            totalMin = Int32.Parse(name) + totalMin;
                        }


                    }





                }

                
                this.dataGridView1.Rows.Add(days[i], visitors.ToString(), totalMin.ToString());

                /*
                 * 
                 * var visit = from date in ls

                            where date.Contains("Thursday")
                            select date;

                List<string> cards = new List<string>();
                foreach (string s in visit)
                {
                    Console.WriteLine("Uniques: " + s);

                    string vals = s.ToString();
                    string[] n = vals.Split(',');
                    cards.Add(n[0]);
                }

                var uniq = cards.Distinct();
                foreach (var u in uniq)
                {
                    visitorsCountMonday = visitorsCountMonday + 1;

                }

                foreach (string t in ls)
                {

                    //Console.WriteLine(i);
                    var values = t.Split(',').ToList();


                    var qTotalTime = from date in values
                                     where date.Contains("Thursday")
                                     select values[6];



                    foreach (var name in qTotalTime)
                    {
                        Console.WriteLine("Time:  " + name);
                        if (name != null && name != "")
                        {
                            totalMinMonday = Int32.Parse(name) + totalMinMonday;
                        }


                    }

                }
                 * */
            }
        }


            public List<string> checkin()
        {
            List<string> ls = new List<string>();


            using (StreamReader sr = new StreamReader("C:\\Users\\anjil\\Desktop\\checkins.csv"))
            {
                string line;


                int i = 0;


                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    ls.Add(line);

                    // Console.WriteLine(ls);



                }
            }
            return ls;

        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {

        }
    }
}
