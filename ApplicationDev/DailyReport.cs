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
    public partial class DailyReport : Form
    {
        

        public DailyReport()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            List<string> ls = checkin();
            int visitorsCount = 0;
            int totalMin = 0;

            var visit = from date in ls

                        where date.Contains(dateTimePicker1.Value.ToShortDateString())
                         select date;


            List<string> cards = new List<string>();
            foreach (string s in visit)
            {
                Console.WriteLine("Uniques: "+s);

                string vals = s.ToString();
                string[] n = vals.Split(',');
                this.dataGridViewAllVisitor.Rows.Add(n[0], n[1], n[2], DateTime.Parse(n[3]).ToShortDateString(), n[4], n[5], n[6]);

                cards.Add(n[0]);
            }

            var uniq = cards.Distinct();
            foreach (var u in uniq)
            {
                visitorsCount = visitorsCount + 1;

            }


            foreach (string i in ls)
            {

                //Console.WriteLine(i);
                var values = i.Split(',').ToList();
                var qTotalVisitor= from date in values
                            where date.Contains(DateTime.Now.Date.ToShortDateString())
                            select date;

                // Query execution

                foreach (var name in qTotalVisitor)
                {
                    
                }

                var qTotalTime = from date in values
                                 where date.Contains(DateTime.Now.Date.ToShortDateString())
                                 select values[6];

                

                foreach (var name in qTotalTime)
                {
                    Console.WriteLine("Time:  " + name);
                    if (name!=null && name!="") { 
                    totalMin = Int32.Parse(name)+totalMin;
                    }


                }
                







               




            }

            this.dataGridView1.Rows.Add(visitorsCount.ToString(), totalMin.ToString());

    

            
        }

        public List<string> checkin() {
            List<string> ls = new List<string>();

            using (StreamReader sr = new StreamReader("../../../checkins.csv"))
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

        private void DailyReport_Load(object sender, EventArgs e)
        {

            List<string> values = checkin();

            var toPLot = from date in values
                         where date.Contains(DateTime.Now.Date.ToShortDateString())
                         select date;

            

            foreach (string s in toPLot) {

                string vals = s.ToString();
                string[] n = vals.Split(',');

                
                Console.WriteLine("Valuesss: "+n[2]);
                //this.chart1.Series["Total Visitors"].Points.AddXY(n[4],  DateTime.Parse(n[5]).Minute-DateTime.Parse(n[4]).Minute);


            }

            //this.chart1.Series["Total Visitors"].Points.AddXY("11 AM", 100);
            //this.chart1.Series["Total Visitors"].Points.AddXY("11 AM", 20);



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Hola: "+ dateTimePicker1.Value.ToShortDateString());
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            this.dataGridViewAllVisitor.Rows.Clear();
            this.dataGridViewAllVisitor.Refresh();

            List<string> ls = checkin();
            int visitorsCount = 0;
            int totalMin = 0;

            var visit = from date in ls

                        where date.Contains(dateTimePicker1.Value.ToShortDateString())
                        select date;


            List<string> cards = new List<string>();
            foreach (string s in visit)
            {
                Console.WriteLine("Uniques: " + s);

                string vals = s.ToString();
                string[] n = vals.Split(',');
                this.dataGridViewAllVisitor.Rows.Add(n[0],n[1], n[2], DateTime.Parse(n[3]).ToShortDateString(), n[4], n[5],n[6]);
                cards.Add(n[0]);
            }

            var uniq = cards.Distinct();
            foreach (var u in uniq)
            {
                visitorsCount = visitorsCount + 1;

            }


            foreach (string i in ls)
            {

                //Console.WriteLine(i);
                var values = i.Split(',').ToList();
                var qTotalVisitor = from date in values
                                    where date.Contains(DateTime.Now.Date.ToShortDateString())
                                    select date;

                // Query execution

                foreach (var name in qTotalVisitor)
                {

                }

                var qTotalTime = from date in values
                                 where date.Contains(dateTimePicker1.Value.ToShortDateString())
                                 select values[6];



                foreach (var name in qTotalTime)
                {
                    Console.WriteLine("Time:  " + name);
                    if (name != null && name != "")
                    {
                        totalMin = Int32.Parse(name) + totalMin;
                    }


                }








                //  dt.Rows.Add(chkData[0], chkData[1], chkData[2], chkData[3], chkData[4], chkData[5], chkData[6]);
                // this.dataGridView1.DataSource = dt;




            }

            Console.WriteLine("Total Visitor: " + visitorsCount);
            Console.WriteLine("Total Min: " + totalMin);
            this.dataGridView1.Rows.Add(visitorsCount.ToString(), totalMin.ToString());
        }

       
    }
}
