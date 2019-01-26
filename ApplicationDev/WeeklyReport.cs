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
                this.chart1.Series["Total Visitor"].Points.AddXY(days[i], visitors.ToString());
                this.chart1.Series["Total time"].Points.AddXY(days[i], totalMin.ToString());

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

        private void WeeklyReport_Load(object sender, EventArgs e)
        {

        }

        private void sortA_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Row:  "+row);
            Console.WriteLine("Total Rows: " + dataGridView1.RowCount + ", Cell:  " + dataGridView1.ColumnCount);
            //chkD.Cells[6].Value
            string[,] datavalue = new string[dataGridView1.Rows.Count - 1, dataGridView1.Columns.Count];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (dataGridView1.Rows[row.Index].Cells[col.Index].Value != null && dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString() != "")
                    {
                        datavalue[row.Index, col.Index] = dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString();
                    }
                }

            }

            string[] temp = new string[3];
            Console.WriteLine("Lgth " + datavalue.GetLength(0) + " R: " + (dataGridView1.Rows.Count - 1));
            Console.WriteLine(" Data D: "+ datavalue[4,2]);


            for (int i = 0; i < datavalue.GetLength(0)-1; i++)
            {

                int j;
                j = 0;
                for (; j < datavalue.GetLength(0)-1; j++)
                {
                    if (Int32.Parse(datavalue[j, 1]) > Int32.Parse(datavalue[j + 1, 1])) {
                        //put array record j into temp holder
                        temp[0] = datavalue[j, 0];
                        temp[1] = datavalue[j, 1];
                        temp[2] = datavalue[j, 2];

                        //copy j + 1 into j
                        datavalue[j, 0] = datavalue[j + 1, 0];
                        datavalue[j, 1] = datavalue[j + 1, 1];
                        datavalue[j, 2] = datavalue[j + 1, 2];

                        //copy temp into j + 1
                        datavalue[j + 1, 0] = temp[0];
                        datavalue[j + 1, 1] = temp[1];
                        datavalue[j + 1, 2] = temp[2];
                    }

                }
            }

            Console.WriteLine("Sorted array: "+datavalue[4,2]);
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            for (int i = 0; i < datavalue.GetLength(0); i++)
            {
                Console.WriteLine(datavalue[i, 0] + " , " + datavalue[i, 1] + " , " + datavalue[i, 2]);
                this.dataGridView1.Rows.Add(datavalue[i, 0], datavalue[i, 1], datavalue[i, 2]);
            }
        }

        private void sortD_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Row:  "+row);
            Console.WriteLine("Total Rows: " + dataGridView1.RowCount + ", Cell:  " + dataGridView1.ColumnCount);
            //chkD.Cells[6].Value
            string[,] datavalue = new string[dataGridView1.Rows.Count - 1, dataGridView1.Columns.Count];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (dataGridView1.Rows[row.Index].Cells[col.Index].Value != null && dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString() != "")
                    {
                        datavalue[row.Index, col.Index] = dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString();
                    }
                }

            }

            string[] temp = new string[3];
            Console.WriteLine("Lgth " + datavalue.GetLength(0) + " R: " + (dataGridView1.Rows.Count - 1));
            Console.WriteLine(" Data D: " + datavalue[4, 2]);


            for (int i = 0; i < datavalue.GetLength(0) - 1; i++)
            {

                int j;
                j = 0;
                for (; j < datavalue.GetLength(0) - 1; j++)
                {
                    if (Int32.Parse(datavalue[j, 2]) > Int32.Parse(datavalue[j + 1, 2]))
                    {
                        //put array record j into temp holder
                        temp[0] = datavalue[j, 0];
                        temp[1] = datavalue[j, 1];
                        temp[2] = datavalue[j, 2];

                        //copy j + 1 into j
                        datavalue[j, 0] = datavalue[j + 1, 0];
                        datavalue[j, 1] = datavalue[j + 1, 1];
                        datavalue[j, 2] = datavalue[j + 1, 2];

                        //copy temp into j + 1
                        datavalue[j + 1, 0] = temp[0];
                        datavalue[j + 1, 1] = temp[1];
                        datavalue[j + 1, 2] = temp[2];
                    }

                }
            }

            Console.WriteLine("Sorted array: " + datavalue[4, 2]);
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            for (int i = 0; i < datavalue.GetLength(0); i++)
            {
                Console.WriteLine(datavalue[i, 0] + " , " + datavalue[i, 1] + " , " + datavalue[i, 2]);
                this.dataGridView1.Rows.Add(datavalue[i, 0], datavalue[i, 1], datavalue[i, 2]);
            }
        }
    }
}
