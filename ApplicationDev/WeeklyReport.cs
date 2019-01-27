using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDev
{
    public partial class WeeklyReport : Form
    {

      
        static int WeeksInMonth(DateTime thisMonth)
        {
            int mondays = 0;
            int month = thisMonth.Month;
            int year = thisMonth.Year;
            int daysThisMonth = DateTime.DaysInMonth(year, month);
            DateTime beginingOfThisMonth = new DateTime(year, month, 1);
            for (int i = 0; i < daysThisMonth; i++)
                if (beginingOfThisMonth.AddDays(i).DayOfWeek == DayOfWeek.Monday)
                    mondays++;
            return mondays;
        }

        static int GetWeekNumberOfMonth(DateTime date)
        {
            date = date.Date;
            DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
            DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            if (firstMonthMonday > date)
            {
                firstMonthDay = firstMonthDay.AddMonths(-1);
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            }
            return (date - firstMonthMonday).Days / 7 + 1;
        }

       

        public WeeklyReport()
        {
            InitializeComponent();
            //week-----------------
            // Gets the Calendar instance associated with a CultureInfo.

            //Console.WriteLine("Parsed value 1: " + GetWeekNumberOfMonth(DateTime.Parse("1/1/2019")));

            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            Console.WriteLine("Cuurent week: "+myCal.GetWeekOfYear(DateTime.Parse("1/1/2019"), myCWR, myFirstDOW));


            //CalendarWeekRule weekRule = CalendarWeekRule.FirstFourDayWeek;

            //DayOfWeek firstWeekDay = DayOfWeek.Monday;
            //Calendar calendar = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;

            //int currentWeek = calendar.GetWeekOfYear(DateTime.Now, weekRule, firstWeekDay);

            //string week = String.Format("{1:00}", dateTimePicker1.Value, currentWeek);

            int totalWeeks = GetWeekNumberOfMonth(dateTimePicker1.Value);

            //Console.WriteLine("Weeek: "+week);
            Console.WriteLine("Total Weeks: "+  totalWeeks);

            weekCombo.Text = "Select Week";
           
            //---------------------


            /*
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

               
            }
            */
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
            try
            {
                //Console.WriteLine("Row:  "+row);
                //  Console.WriteLine("Total Rows: " + dataGridView1.RowCount + ", Cell:  " + dataGridView1.ColumnCount);
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


                for (int i = 0; i < datavalue.GetLength(0) - 1; i++)
                {

                    int j;
                    j = 0;
                    for (; j < datavalue.GetLength(0) - 1; j++)
                    {
                        if (Int32.Parse(datavalue[j, 1]) > Int32.Parse(datavalue[j + 1, 1]))
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

            } catch(Exception ex1)
            {
                Console.WriteLine(ex1.Message);
            }
        }

        private void sortD_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            weekCombo.Items.Clear();
            int totalWeeks = WeeksInMonth(dateTimePicker1.Value);
            weekCombo.Text = "Select Week";
            for (int i = 1; i <= totalWeeks; i++)
            {
                Console.WriteLine(i);
                weekCombo.Items.Add(i);
            }
        }

        private void chkInBtn_Click(object sender, EventArgs e)
        {
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            // Console.WriteLine("Cuurent week: " + myCal.GetWeekOfYear(DateTime.Parse("1/1/2019"), myCWR, myFirstDOW));

            this.chart1.Series["Total Visitor"].Points.Clear();
            this.chart1.Series["Total time"].Points.Clear();

            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            if (weekCombo.Text == "1" || weekCombo.Text == "2" || weekCombo.Text == "3" || weekCombo.Text == "4" || weekCombo.Text == "5")
            {

                List<string> checkWeek = checkin();
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
                for (int i = 0; i < days.Length; i++)
                {
                    int visitors = 0;
                    int totalMin = 0;
                    var visit2 = from date in checkWeek
                                 where date.Contains(days[i])
                                 select date;

                    List<string> cards1 = new List<string>();
                    foreach (string s in visit2)
                    {


                        string vals = s.ToString();
                        string[] n = vals.Split(',');

                        //Console.WriteLine("Parsed value  "+ GetWeekNumberOfMonth(DateTime.Parse("1/1/2019")));
                        //myCal.GetWeekOfYear(DateTime.Parse("n[3]"), myCWR, myFirstDOW)
                        Console.WriteLine("Index check: " + n[3]);
                        int wno = myCal.GetWeekOfYear(DateTime.Parse(n[3]), myCWR, myFirstDOW);
                        Console.WriteLine("WNO: " + wno);
                        if (DateTime.Parse(n[3]).Month.ToString() == DateTime.Parse(dateTimePicker1.Value.ToString()).Month.ToString() && myCal.GetWeekOfYear(DateTime.Parse(n[3]), myCWR, myFirstDOW) == Convert.ToInt32(weekCombo.Text))
                        {
                            cards1.Add(n[0]);
                        }
                    }

                    var uniq1 = cards1.Distinct();
                    foreach (var u in uniq1)
                    {
                        visitors = visitors + 1;

                    }


                    //minutes
                    foreach (string t in checkWeek)
                    {

                        //Console.WriteLine(i);
                        var values = t.Split(',').ToList();
                        // Console.WriteLine("Valuess  "+dateTimePicker1.Text);
                        //myCal.GetWeekOfYear(DateTime.Parse("values[3]"), myCWR, myFirstDOW)
                        if (DateTime.Parse(values[3]).Month.ToString() == DateTime.Parse(dateTimePicker1.Value.ToString()).Month.ToString() && myCal.GetWeekOfYear(DateTime.Parse(values[3]), myCWR, myFirstDOW) == Convert.ToInt32(weekCombo.Text))
                        {


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





                    }

                    this.dataGridView1.Rows.Add(days[i], visitors.ToString(), totalMin.ToString());
                    this.chart1.Series["Total Visitor"].Points.AddXY(days[i], visitors.ToString());
                    this.chart1.Series["Total time"].Points.AddXY(days[i], totalMin.ToString());
                }

            }
            else {
                MessageBox.Show("Pick a week.","Error!");
            }
        }
    }
}
