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
    public partial class Form1 : Form
    {
        List<CheckIn> ch = new List<CheckIn>();
        List<Visitor> ls = new List<Visitor>();
        List<string> chkData;
        DataTable dt = new DataTable();
        string[] lines;
        string[] columnNames = { "Card Number", "Name", "Day", "Date", "In time", "Out time", "Total Duration(Min)"};

        public static List<string> readVisitors()
        {
            List<string> ls = new List<string>();
            using (StreamReader sr = new StreamReader("C:\\Users\\anjil\\Desktop\\desm.csv"))
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

        public static List<string> readCheckIns()
        {
            List<string> ls = new List<string>();
            using (StreamReader sr = new StreamReader("C:\\Users\\anjil\\Desktop\\checkins.csv"))
            {
                string line;


               


                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    ls.Add(line);

                   // Console.WriteLine(ls);



                }
            }

            return ls;

        }

        public Form1()
        {
            List<string> vstrs = readVisitors();
            InitializeComponent();
           // Console.WriteLine("Constructor data:  ");
           

            foreach (string i in vstrs)
            {

                //Console.WriteLine(i);
                var values = i.Split(',').ToList();
                //Console.WriteLine(values.Count);
                Visitor visitor = new Visitor();
                //  writer.WriteLine(i.card_number+","+i.name+","+i.address+","+i.contact+","+i.gender);
                visitor.card_number = values[0];
                //Console.WriteLine(values[1]);

                visitor.first_name = values[1];
                visitor.last_name = values[2];
                visitor.address = values[3];
                visitor.contact = values[4];
                visitor.gender = values[5];
                visitor.email = values[6];
                visitor.occupation = values[7];
                ls.Add(visitor);

            }


            List<string> checkins1 = readCheckIns();
            Console.WriteLine("Counted: "+ checkins1.Count);

            if (checkins1.Count>1)
            {
                foreach (string i in checkins1)
                {

                    //Console.WriteLine(i);
                    string[] values = i.Split(',');
                    
                  
                    Console.WriteLine("Values COunt:  "+values.Count());
                    CheckIn checkIn = new CheckIn();
                    //  writer.WriteLine(i.card_number+","+i.name+","+i.address+","+i.contact+","+i.gender);

                    if (values.Count() ==7) 
                    {
                        checkIn.card_number = values[0];
                        //Console.WriteLine(values[1]);

                        checkIn.name = values[1];
                        checkIn.day = values[2];
                        checkIn.date = DateTime.Parse(values[3]);
                        checkIn.checkIn_time = values[4];
                        checkIn.checkOut_time = values[5];
                        if (values[5] != "")
                        {
                            checkIn.total_time = (DateTime.Parse(values[5]).Minute - DateTime.Parse(values[4]).Minute).ToString();
                        }
                        else
                        {
                            checkIn.total_time = "";
                        }

                        ch.Add(checkIn);
                    }

                }
            }
            








        }





        private void BndDataCSV(string filePath) {
         //   try
           // {

               
                lines = System.IO.File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {

                    string firstLine = lines[0];

                    string[] headerLabels = firstLine.Split(',');
                


                /*
                    foreach (string headerWord in columnNames)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                        //Console.WriteLine("Headers: " + headerWord );
                    }

                   // string[] body = lines[1].Split(',');

                   // Console.WriteLine("Body : " + body.Length);





                    //for data
                    /*
                    for (int r = 1; r <= lines.Length; r++)
                    {
                        string[] dataWords = lines[r].Split(',');
                        Console.WriteLine("Datawords length:  " + dataWords.Length);
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in columnNames)
                        {
                            Console.WriteLine("Datas:  " + headerWord);
                            dr[headerWord] = dataWords[columnIndex++];

                        }
                        dt.Rows.Add(dr);
              
                    }
                */




            }

              /*  if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                 dataGridView1.DataSource = dt;

            */
            //}
            /*
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            */

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           BndDataCSV("C:\\Users\\anjil\\Desktop\\checkins.csv");
            
            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("Card Number",typeof(string)),
                new DataColumn("Name",typeof(string)),
                new DataColumn("Day",typeof(string)),
                new DataColumn("Date",typeof(string)),
                new DataColumn("In Time",typeof(string)),
                new DataColumn("Out Time",typeof(string)),
                new DataColumn("Total Duration(Min)",typeof(string)),
                new DataColumn("Check Out"),



            });




        }

        int rowVal;


        private void chkInBtn_Click(object sender, EventArgs e)
        {

            if (cardField.Text != "" && nmField.Text != "")
            {

                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                chkData = new List<string>();
                DateTime day = new DateTime();
                DataRow dr = dt.NewRow();
                int columnIndex = 0;
                day = DateTime.Now;
                chkData.Add(cardField.Text);
                chkData.Add(nmField.Text);
                chkData.Add(day.DayOfWeek.ToString());
                chkData.Add(day.Date.ToShortDateString());
                chkData.Add(day.ToLongTimeString());
                chkData.Add("");
                chkData.Add("");
                dt.Rows.Add(chkData[0], chkData[1], chkData[2], chkData[3], chkData[4], chkData[5], chkData[6]);

                /*foreach (string headerWord in columnNames)
                {
                    //Console.WriteLine("Datas:  " + headerWord);
                    dr[headerWord] = chkData[columnIndex++];



                }
                */
                this.dataGridView1.DataSource = dt;
                /*
                for (int r = 1; r <= lines.Length - 1; r++)
                {

                    //Console.WriteLine("Datawords length:  ");
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    day = DateTime.Now;
                    string date = DateTime.Now.Date.ToString();
                    //string[] chkData = { cardField.Text, nmField.Text, day.DayOfWeek.ToString(), day.Date.ToShortDateString(), day.ToLongTimeString(), "", "" };
                    chkData.Add(cardField.Text);
                    chkData.Add(nmField.Text);
                    chkData.Add(day.DayOfWeek.ToString());
                    chkData.Add(day.Date.ToShortDateString());
                    chkData.Add(day.ToLongTimeString());
                    chkData.Add("");
                    chkData.Add("");



                    /* foreach (string headerWord in columnNames)
                     {
                         //Console.WriteLine("Datas:  " + headerWord);
                         dr[columnIndex++] = chkData[columnIndex++];


                     }
                     
                    Console.WriteLine(chkData[1]);
                    dt.Rows.Add(chkData[0], chkData[1], chkData[2], chkData[3], chkData[4], chkData[5],chkData[6]);
                    this.dataGridView1.DataSource = dt;
                    break;


                }*/

                CheckIn checkin = new CheckIn();
                checkin.card_number = chkData[0];
                checkin.name = chkData[1];
                checkin.day = chkData[2];
                checkin.date = DateTime.Parse(chkData[3]);
                checkin.checkIn_time = chkData[4];
                checkin.checkOut_time = chkData[5];
                checkin.total_time = chkData[6];

                ch.Add(checkin);

                foreach (CheckIn chk in ch) {
                    Console.WriteLine("Objects:  "+chk.card_number);
                    Console.WriteLine("-----------");
                }
                string path = "C:\\Users\\anjil\\Desktop\\checkins.csv";

                if (!File.Exists(path))
                {
                    File.Create(path);

                }

                using (StreamWriter writer = new StreamWriter(path, append: false))
                {

                    //  Console.WriteLine(i.card_number + i.first_name);

                    //writer.WriteLine(cardField.Text + "," + nmField.Text + "," + day.DayOfWeek.ToString() + "," + day.Date.ToShortDateString() + "," + day.ToLongTimeString() + "," + "" + "," + "");
                    foreach (CheckIn c in ch) {
                        writer.WriteLine(c.card_number+","+c.name + "," + c.day + "," + c.date + "," + c.checkIn_time + "," + c.checkOut_time+","+c.total_time);
                    }



                }

                nmField.Text = "";
                cardField.Text = "";
                chkInBtn.Enabled = false;
              
                //Console.WriteLine("List size: " + ch.Count);


                /*
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = DateTime.Now.DayOfWeek;
                row.Cells[1].Value = cardField.Text;
                row.Cells[2].Value = nmField.Text;
                row.Cells[3].Value = DateTime.Now.Date;
                */





                /*
                  if (rowVal!=0 || rowVal!=null) {
                      row.Cells[rowVal].Value = DateTime.Now.Date;
                  }
                  */

                //dataGridView1.Rows.Add(row);
            }
            else
            {

                MessageBox.Show("Fill all fields.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowVal = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowVal];
            cardField.Text = row.Cells[0].Value.ToString();
            Console.WriteLine("Row value: "+rowVal);

            

        }

        /*
        private void chkOutBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            DataGridViewRow chkD = dataGridView1.Rows[rowVal];

            chkD.Cells[4].Value = DateTime.Now.ToLongTimeString();
            
            /*int i = dataGridView1.CurrentRow.Index;
            if (i != 0 || i != null)
            {
                row.Cells[i].Value = DateTime.Now.Date;
            }
            
        }
    */

        private void button1_Click(object sender, EventArgs e)
        {
            Visitor existinVisitor = ls.Where(x => x.card_number == cardField.Text).FirstOrDefault();
            if (existinVisitor != null && existinVisitor.card_number == cardField.Text)
            {
                nmField.Text = existinVisitor.first_name;
                chkInBtn.Enabled = true;
                
                

            }
            else {

                MessageBox.Show("Not found.Register First.");
                nmField.Text = "";
                cardField.Text = "";
                chkInBtn.Enabled = false;
                


            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rowVal = e.RowIndex;
           // DataGridViewRow row = dataGridView1.Rows[rowVal];
            
            Console.WriteLine("Row value: " + rowVal);

            //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            //cardField.Text = row.ToString();
            DataGridViewRow chkD = dataGridView1.Rows[rowVal];

            chkD.Cells[6].Value = DateTime.Now.ToLongTimeString();
            chkData[5] = chkD.Cells[6].Value.ToString();
            chkD.Cells[7].Value = DateTime.Parse(chkData[5]).Minute - DateTime.Parse(chkD.Cells[5].Value.ToString()).Minute;
            chkData[6] = chkD.Cells[7].Value.ToString();
            Console.WriteLine("Cell Value of date: "+DateTime.Parse(chkD.Cells[5].Value.ToString()));

            foreach (CheckIn c1 in ch) {
                if (c1.checkIn_time == chkD.Cells[5].Value.ToString() && c1.card_number == chkD.Cells[1].Value.ToString())
                {
                    Console.WriteLine("Found: " + c1.checkIn_time + " " + c1.card_number);
                    c1.checkOut_time = chkD.Cells[6].Value.ToString();
                    c1.total_time = chkD.Cells[7].Value.ToString();
                    string path = "C:\\Users\\anjil\\Desktop\\checkins.csv";

                    if (!File.Exists(path))
                    {
                        File.Create(path);

                    }

                    using (StreamWriter writer = new StreamWriter(path, append: false))
                    {

                       
                        foreach (CheckIn c in ch)
                        {
                            writer.WriteLine(c.card_number + "," + c.name + "," + c.day + "," + c.date + "," + c.checkIn_time + "," + c.checkOut_time+","+c.total_time);
                        }



                    }
                    //C

                    break;
                }
                else {
                    Console.WriteLine("Not Found: ");
                }
            }




            foreach (string s in chkData) {
                Console.WriteLine("LList data: "+s);
            }
        }

        private void sortCard_Click(object sender, EventArgs e)
        {

            //Console.WriteLine("Row:  "+row);
            Console.WriteLine("Total Rows: " + dataGridView1.RowCount + ", Cell:  " + dataGridView1.ColumnCount);
            //chkD.Cells[6].Value
            string[,] datavalue = new string[dataGridView1.Rows.Count - 1, dataGridView1.Columns.Count];
            foreach (DataGridViewRow row in dataGridView1.Rows) {

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (dataGridView1.Rows[row.Index].Cells[col.Index].Value != null && dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString() != "") {
                        datavalue[row.Index, col.Index] = dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString();
                    }
                }

            }

            string[] temp = new string[dataGridView1.Rows.Count - 1];
            Console.WriteLine("Lgth " + datavalue.GetLength(0)+" R: "+ (dataGridView1.Rows.Count-1));


            for (int i =0;i<datavalue.GetLength(0);i++) {

                int j;
                j = 0;
                for (; j < datavalue.GetLength(0); j++)
                {
                    
                }
            }


            for (int i = 0; i < datavalue.GetLength(0); i++)
            {
                Console.WriteLine("Array value: " +datavalue[i, 1]);
            }

        }

        private void checkChkIn_Click(object sender, EventArgs e)
        {

            try {
                string cn = checkCheckInTxt.Text;



                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        // if (dataGridView1.Rows[row.Index].Cells[col.Index].Value != null && dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString() != "")
                        //{
                        //Console.WriteLine("New: " + dataGridView1.Rows[row.Index].Cells[1].Value.ToString()+"   "+cn);
                        if (row != null && col != null) {
                            if (dataGridView1.Rows[row.Index].Cells[1].Value.ToString() == cn && dataGridView1.Rows[row.Index].Cells[6].Value.ToString() == "" && dataGridView1.Rows[row.Index].Cells[col.Index].Value != null && dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString() != "")
                            {
                                Console.WriteLine("New: " + dataGridView1.Rows[row.Index].Cells[0].Value.ToString());
                                dataGridView1.Rows[row.Index].Cells[6].Value = DateTime.Now.ToLongTimeString();
                                cn = "";
                                checkCheckInTxt.Text="";
                                chkData[5] = dataGridView1.Rows[row.Index].Cells[6].Value.ToString();
                                // dataGridView1.Rows[row.Index].Cells[7].Value = DateTime.Parse(chkData[5]).Minute - DateTime.Parse(dataGridView1.Rows[row.Index].Cells[5].Value.ToString()).Minute;
                                dataGridView1.Rows[row.Index].Cells[7].Value = DateTime.Parse(chkData[5]).Subtract(DateTime.Parse(dataGridView1.Rows[row.Index].Cells[5].Value.ToString())).TotalMinutes;
                                //b.Subtract(a).TotalMinutes
                                chkData[6] = dataGridView1.Rows[row.Index].Cells[7].Value.ToString();

                                //write csv
                                foreach (CheckIn c1 in ch)
                                {
                                    if (c1.checkIn_time == dataGridView1.Rows[row.Index].Cells[5].Value.ToString() && c1.card_number == dataGridView1.Rows[row.Index].Cells[1].Value.ToString())
                                    {
                                        Console.WriteLine("Found: " + c1.checkIn_time + " " + c1.card_number);
                                        c1.checkOut_time = dataGridView1.Rows[row.Index].Cells[6].Value.ToString();
                                        c1.total_time = dataGridView1.Rows[row.Index].Cells[7].Value.ToString();
                                        string path = "C:\\Users\\anjil\\Desktop\\checkins.csv";

                                        if (!File.Exists(path))
                                        {
                                            File.Create(path);

                                        }

                                        using (StreamWriter writer = new StreamWriter(path, append: false))
                                        {


                                            foreach (CheckIn c in ch)
                                            {
                                                writer.WriteLine(c.card_number + "," + c.name + "," + c.day + "," + c.date + "," + c.checkIn_time + "," + c.checkOut_time+","+c.total_time);
                                            }
                                        }
                                        break;
                                    }
                            }
                                break;
                            
                        }

                        //}

                    }

                }

            }}

            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        private void dailyMEnu_Click(object sender, EventArgs e)
        {

           DailyReport dr = new DailyReport();
            dr.Show();
        }

        private void weeklyMenu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
