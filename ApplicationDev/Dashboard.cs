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
    public partial class Dashboard : Form
    {
        List<string> vstrs;

        List<Visitor> ls = new List<Visitor>();
        Random rnd = new Random();

        List<CheckIn> ch = new List<CheckIn>();
       // List<Visitor> ls2 = new List<Visitor>();
        List<string> chkData;
        DataTable dt = new DataTable();
        string[] lines;
        string[] columnNames = { "Card Number", "Name", "Day", "Date", "In time", "Out time", "Total Duration(Min)" };


        

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

                    // Console.WriteLine(ls);



                }
            }

            return ls;

        }

        public static List<string> readCheckIns()
        {
            List<string> ls = new List<string>();
            using (StreamReader sr = new StreamReader("../../../checkins.csv"))
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



        public Dashboard(List<string> visitors)
        {
            List<string> vstrs1 = readVisitors();

            




            InitializeComponent();

            dashCurrentDay.Text = DateTime.Now.DayOfWeek.ToString();
            dashCurrentDate.Text = DateTime.Now.Date.ToShortDateString();


            //visitor count---------------
            int visitorsCount = 0;
            int onChk = 0;
           
            List<string> forCounter = readCheckIns();

            var visit = from date in forCounter

                        where date.Contains(DateTime.Now.Date.ToShortDateString())
                        select date;


            List<string> cards = new List<string>();
            foreach (string s in visit)
            {
                Console.WriteLine("Uniques: " + s);

                string vals = s.ToString();
                string[] n = vals.Split(',');
                cards.Add(n[0]);
                Console.WriteLine("n[6]:   " + n[5]);
                if (n[5] == "")
                {
                    onChk = onChk + 1;
                }


            }

            dashCheckedIN.Text = onChk.ToString();
            var uniq = cards.Distinct();
            foreach (var u in uniq)
            {
                visitorsCount = visitorsCount + 1;

            }
            visitorsCountLbl.Text = visitorsCount.ToString();



            //end---------------------------------




            List<string> checkins1 = readCheckIns();

           
            Console.WriteLine("Counted: " + checkins1.Count);

            if (checkins1.Count > 1)
            {
                foreach (string i in checkins1)
                {

                    //Console.WriteLine(i);
                    string[] values = i.Split(',');


                    Console.WriteLine("Values COunt:  " + values.Count());
                    CheckIn checkIn = new CheckIn();
                    //  writer.WriteLine(i.card_number+","+i.name+","+i.address+","+i.contact+","+i.gender);

                    if (values.Count() == 7)
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
                            checkIn.total_time = Math.Round(DateTime.Parse(values[5]).Subtract( DateTime.Parse(values[4])).TotalMinutes).ToString();
                        }
                        else
                        {
                            checkIn.total_time = "";
                        }

                        ch.Add(checkIn);
                    }

                }
            }



            Console.WriteLine("Constructor data:  ");
            foreach (string i in visitors)
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

            
        }


        private void BndDataCSV(string filePath)
        {
            //   try
            // {


            lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {

                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(',');
            }

            //pre load
            List<string> ls = readCheckIns();
            

            var visit = from date in ls

                        where date.Contains(DateTime.Now.Date.ToShortDateString())
                        select date;


            List<string> cards = new List<string>();
            foreach (string s in visit)
            {
                Console.WriteLine("Uniques: " + s);

                string vals = s.ToString();
                string[] n = vals.Split(',');
                chkData = new List<string>();
                DateTime day = new DateTime();
                DataRow dr = dt.NewRow();
                int columnIndex = 0;
                day = DateTime.Now;
                chkData.Add(n[0]);
                chkData.Add(n[1]);
                chkData.Add(n[2]);
                chkData.Add(n[3]);
                chkData.Add(n[4]);
                chkData.Add(n[5]);
                chkData.Add(n[6]);
                dt.Rows.Add(n[0], n[1], n[2], DateTime.Parse(n[3]).ToShortDateString(), n[4], n[5], n[6]);

            }
            this.dataGridView1.DataSource = dt;


        }



        
        private void button1_Click(object sender, EventArgs e)
        {
            this.registerPanel.Visible = true;
            

            this.recordPanel.Visible = false;

            this.barShow.Width = button1.Width;
            this.barShow.Location = new System.Drawing.Point(519, 125);
            this.dashboardPanel.Visible = false;
            //this.registerBar.Width = 119;
         
            //registerBar.Top = button1.Top;
            //Register rs = new Register(vstrs);
            //rs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.recordPanel.Visible = true;


            this.barShow.Location = new System.Drawing.Point(699, 125);
            this.barShow.Width = button2.Width;

            this.registerPanel.Visible = false;
            this.dashboardPanel.Visible = false;

            //Form1 frm = new Form1();

            //frm.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                //String st = File.ReadAllText("C:\\Users\\anjil\\Desktop\\desm.csv");
                //Console.WriteLine(st);

                Visitor existinVisitor = ls.Where(x => x.card_number == regCardNumber.Text).FirstOrDefault();
                if (existinVisitor != null && existinVisitor.card_number == regCardNumber.Text)
                {
                    MessageBox.Show("Card Number Already taken.");
                }
                else if (regCardNumber.Text.Equals(""))
                {
                    MessageBox.Show("Dont leave empty fields.");

                }
                else
                {

                    Visitor visitor = new Visitor();
                    visitor.card_number = regCardNumber.Text;
                    visitor.first_name = firstNameTxt.Text;
                    visitor.last_name = last_nameTxt.Text;
                    visitor.gender = genderTxt.Text;
                    visitor.address = addressText.Text;
                    visitor.contact = contactTxt.Text;
                    visitor.email = emailTxt.Text;
                    visitor.occupation = occupationTxt.Text;

                    ls.Add(visitor);
                    string path = "../../../desm.csv";

                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                    using (StreamWriter writer = new StreamWriter(path, append: true))
                    {

                        //Console.WriteLine(i.card_number + i.first_name);
                        writer.WriteLine(regCardNumber.Text + "," + firstNameTxt.Text + "," + last_nameTxt.Text + "," + addressText.Text + "," + contactTxt.Text + "," + genderTxt.Text + "," + emailTxt.Text + "," + occupationTxt.Text);

                        regCardNumber.Text = "";
                        firstNameTxt.Text = "";
                        addressText.Text = "";
                        contactTxt.Text = "";
                        last_nameTxt.Text = "";
                        emailTxt.Text = "";
                        occupationTxt.Text = "";



                    }
                }


                /** 
                 using (StreamReader sr = new StreamReader("C:\\Users\\anjil\\Desktop\\desm.csv"))
                 {
                     string line;

                   
                     int i= 0;
                     
                     while ((line = sr.ReadLine()) != null)
                     {
                         //Console.WriteLine(line);
                         ls.Add(line);

                         //Console.WriteLine(ls);
                         i = i + 1;

            
                     }
                 }
                 int y = 0;
                 foreach (string i in ls)
                 {
                     y = y + 1;
                     Console.WriteLine(i);
                     Console.WriteLine(y);
                 }



                 if (regNameText.Text.ToString() != "" && addressText.Text.ToString() != "" && contactTxt.Text.ToString() != "")
                 {
                     
                     StringBuilder csvcontent = new StringBuilder();
                     //List<int> listA = new List<int>();
                     int cardno=1000;
                     //csvcontent.AppendLine("Name,CardNo,Address,Contact,Gender");
                     string records = regNameText.Text.ToString()+","+cardno.ToString()+","+addressText.Text.ToString()+","+contactTxt.Text.ToString()+","+genderTxt.Text.ToString();
                     csvcontent.AppendLine(records);
                     string csvpath = "C:\\Users\\anjil\\Desktop\\desm.csv";
                     File.AppendAllText(csvpath, csvcontent.ToString());
                     cardno = cardno + 1;

                     MessageBox.Show("Registered Successfully!!");

                     regNameText.Text = "";
                     addressText.Text = "";
                     contactTxt.Text = "";

                     


                  

                 }
                 else {
                     MessageBox.Show("Register again Properly!!");
                 }
     **/
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }


        
    }

        private void button4_Click(object sender, EventArgs e)
        {

            Visitor existinVisitor = ls.Where(x => x.card_number == cardField.Text).FirstOrDefault();
            if (existinVisitor != null && existinVisitor.card_number == cardField.Text)
            {
                nmField.Text = existinVisitor.first_name;
                ocField.Text = existinVisitor.occupation;
                adField.Text = existinVisitor.address;
                emField.Text = existinVisitor.email;
                conField.Text = existinVisitor.contact;
                gnField.Text = existinVisitor.gender;

                


                chkInBtn.Enabled = true;



            }
            else
            {

                MessageBox.Show("Not found.Register First.");
                nmField.Text = "";
                cardField.Text = "";
                ocField.Text = "";
                adField.Text = "";
                emField.Text = "";
                conField.Text = "";
                gnField.Text = "";
                chkInBtn.Enabled = false;



            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            

            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("Card Number",typeof(string)),
                new DataColumn("Name",typeof(string)),
                new DataColumn("Day",typeof(string)),
                new DataColumn("Date",typeof(string)),
                new DataColumn("In Time",typeof(string)),
                new DataColumn("Out Time",typeof(string)),
                new DataColumn("Total Duration(Min)",typeof(string)),
                //new DataColumn("Check Out"),



            });
            BndDataCSV("../../../checkins.csv");
        }

        private void chkInBtn_Click(object sender, EventArgs e)
        {
            List<string> forCounter = readCheckIns();
            bool checkedOUt = true;

            if (cardField.Text != "" && nmField.Text != "")
            {
                //-------------------
                var checkInCheck = from date in forCounter

                            where date.Contains(cardField.Text)
                            select date;
               
                foreach (string s in checkInCheck)
                {


                    string vals = s.ToString();
                    string[] n = vals.Split(',');
                    
                    Console.WriteLine("n[6]:   " + n[5]);
                    if (n[5] == "")
                    {
                        checkedOUt = false;
                    }
                }


                //---------------
                if (checkedOUt)
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
                    //dt.ToString("dd/MM/yyyy HH:mm:ss");
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

                    foreach (CheckIn chk in ch)
                    {
                        Console.WriteLine("Objects:  " + chk.card_number);
                        Console.WriteLine("-----------");
                    }
                    string path = "../../../checkins.csv";

                    if (!File.Exists(path))
                    {
                        File.Create(path);

                    }

                    using (StreamWriter writer = new StreamWriter(path, append: false))
                    {

                        //  Console.WriteLine(i.card_number + i.first_name);

                        //writer.WriteLine(cardField.Text + "," + nmField.Text + "," + day.DayOfWeek.ToString() + "," + day.Date.ToShortDateString() + "," + day.ToLongTimeString() + "," + "" + "," + "");
                        foreach (CheckIn c in ch)
                        {
                            writer.WriteLine(c.card_number + "," + c.name + "," + c.day + "," + c.date + "," + c.checkIn_time + "," + c.checkOut_time + "," + c.total_time);
                        }



                    }

                    nmField.Text = "";
                    cardField.Text = "";
                    ocField.Text = "";
                    adField.Text = "";
                    emField.Text = "";
                    conField.Text = "";
                    gnField.Text = "";
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
                else {
                    MessageBox.Show("Already checked in. Check out first!!");
                }
            }
            else
            {

                MessageBox.Show("Fill all fields.");
            }
        }

        private void checkChkIn_Click(object sender, EventArgs e)
        {

            try
            {
                string cn = checkCheckInTxt.Text;



                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        // if (dataGridView1.Rows[row.Index].Cells[col.Index].Value != null && dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString() != "")
                        //{
                        //Console.WriteLine("New: " + dataGridView1.Rows[row.Index].Cells[1].Value.ToString()+"   "+cn);
                        if (row != null && col != null)
                        {
                            if (dataGridView1.Rows[row.Index].Cells[1].Value.ToString() == cn && dataGridView1.Rows[row.Index].Cells[6].Value.ToString() == "" && dataGridView1.Rows[row.Index].Cells[col.Index].Value != null && dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString() != "")
                            {
                                Console.WriteLine("New: " + dataGridView1.Rows[row.Index].Cells[0].Value.ToString());
                                dataGridView1.Rows[row.Index].Cells[6].Value = DateTime.Now.ToLongTimeString();
                                cn = "";
                                checkCheckInTxt.Text = "";
                                chkData[5] = dataGridView1.Rows[row.Index].Cells[6].Value.ToString();
                                //dataGridView1.Rows[row.Index].Cells[7].Value = DateTime.Parse(chkData[5]).Minute - DateTime.Parse(dataGridView1.Rows[row.Index].Cells[5].Value.ToString()).Minute;
                                dataGridView1.Rows[row.Index].Cells[7].Value = Math.Round(DateTime.Parse(chkData[5]).Subtract(DateTime.Parse(dataGridView1.Rows[row.Index].Cells[5].Value.ToString())).TotalMinutes);
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
                                        string path = "../../../checkins.csv";

                                        if (!File.Exists(path))
                                        {
                                            File.Create(path);

                                        }

                                        using (StreamWriter writer = new StreamWriter(path, append: false))
                                        {


                                            foreach (CheckIn c in ch)
                                            {
                                                writer.WriteLine(c.card_number + "," + c.name + "," + c.day + "," + c.date + "," + c.checkIn_time + "," + c.checkOut_time + "," + c.total_time);
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

                }
            }

            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
        int rowVal;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowVal = e.RowIndex;
                // DataGridViewRow row = dataGridView1.Rows[rowVal];

                Console.WriteLine("Row value: " + rowVal);

                //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                //cardField.Text = row.ToString();
                DataGridViewRow chkD = dataGridView1.Rows[rowVal];


                chkD.Cells[6].Value = DateTime.Now.ToLongTimeString();
                Console.WriteLine("Cel data: " + chkD.Cells[6].Value);
                chkData[5] = chkD.Cells[6].Value.ToString();
                //chkD.Cells[7].Value = DateTime.Parse(chkData[5]).Minute - DateTime.Parse(chkD.Cells[5].Value.ToString()).Minute;
                chkD.Cells[7].Value = Math.Round(DateTime.Parse(chkData[5]).Subtract(DateTime.Parse(chkD.Cells[5].Value.ToString())).TotalMinutes);

                chkData[6] = chkD.Cells[7].Value.ToString();
                Console.WriteLine("Cell Value of date: " + DateTime.Parse(chkD.Cells[5].Value.ToString()));

                foreach (CheckIn c1 in ch)
                {
                    if (c1.checkIn_time == chkD.Cells[5].Value.ToString() && c1.card_number == chkD.Cells[1].Value.ToString())
                    {
                        Console.WriteLine("Found: " + c1.checkIn_time + " " + c1.card_number);
                        c1.checkOut_time = chkD.Cells[6].Value.ToString();
                        c1.total_time = chkD.Cells[7].Value.ToString();
                        string path = "../../../checkins.csv";

                        if (!File.Exists(path))
                        {
                            File.Create(path);

                        }

                        using (StreamWriter writer = new StreamWriter(path, append: false))
                        {


                            foreach (CheckIn c in ch)
                            {
                                writer.WriteLine(c.card_number + "," + c.name + "," + c.day + "," + c.date + "," + c.checkIn_time + "," + c.checkOut_time + "," + c.total_time);
                            }



                        }
                        //C

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not Found: ");
                    }
                }




                foreach (string s in chkData)
                {
                    Console.WriteLine("LList data: " + s);
                }
            }
            catch (Exception e2) {
                Console.WriteLine(e2.Message);
            }
        }

        private void dailyMEnu_Click(object sender, EventArgs e)
        {
            DailyReport dr = new DailyReport();
            dr.Show();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            int cno = rnd.Next(1600000,1699999);
            regCardNumber.Text = "MUS"+cno.ToString();

        }

        private void weeklyMenu_Click(object sender, EventArgs e)
        {
            WeeklyReport wr = new WeeklyReport();
            wr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            barShow.Width = headerLabel.Width + 50;
            this.barShow.Location = new System.Drawing.Point(0,125);
            this.dashboardPanel.Visible = true;

        }

        private void label14_Click(object sender, EventArgs e)
        {
            //visitor count---------------
            int visitorsCount = 0;
            int totalMin = 0;
            int onChk = 0;
            List<string> forCounter = readCheckIns();

            var visit = from date in forCounter

                        where date.Contains(DateTime.Now.Date.ToShortDateString())
                        select date;

            

            List<string> cards = new List<string>();
            foreach (string s in visit)
            {
                

                string vals = s.ToString();
                string[] n = vals.Split(',');
                cards.Add(n[0]);
                Console.WriteLine("n[6]:   " + n[5]  );
                if (n[5]=="")
                {
                    onChk = onChk + 1;
                }
            }
            var uniq = cards.Distinct();
            foreach (var u in uniq)
            {
                visitorsCount = visitorsCount + 1;
                
            }
            visitorsCountLbl.Text = visitorsCount.ToString();
            dashCheckedIN.Text = onChk.ToString();



            



            barShow.Width = headerLabel.Width+50;
            this.barShow.Location = new System.Drawing.Point(0, 125);
            this.dashboardPanel.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLbl.Text= DateTime.Now.ToLongTimeString();
        }

        public void dashBoard_content() {
            dashCurrentDay.Text = DateTime.Now.DayOfWeek.ToString();
            dashCurrentDate.Text = DateTime.Now.Date.ToShortDateString();
             

        }
    }
}
