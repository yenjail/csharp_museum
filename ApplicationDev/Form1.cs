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
        DataTable dt = new DataTable();
        string[] lines;


        public Form1(List<string> vstrs)
        {
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


           



        }


        private void BndDataCSV(string filePath) {
         //   try
           // {

               
                lines = System.IO.File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {

                    string firstLine = lines[0];

                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                        //Console.WriteLine("Headers: " + headerWord );
                    }

                   // string[] body = lines[1].Split(',');

                   // Console.WriteLine("Body : " + body.Length);





                    //for data
                    
                    for (int r = 1; r <= lines.Length-1; r++)
                    {
                        string[] dataWords = lines[r].Split(',');
                        Console.WriteLine("Datawords length:  " + dataWords.Length);
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headerLabels)
                        {
                            Console.WriteLine("Datas:  " + headerWord);
                            dr[headerWord] = dataWords[columnIndex++];

                        }
                        dt.Rows.Add(dr);
                    

                    }

                  
                }

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
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
        }

        int rowVal;


        private void chkInBtn_Click(object sender, EventArgs e)
        {
            if (cardField.Text != "" && nmField.Text != "")
            {

                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(',');
                List<string> chkData = new List<string>();
                DateTime day = new DateTime();

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



                    foreach (string headerWord in headerLabels)
                    {
                        //Console.WriteLine("Datas:  " + headerWord);
                        dr[headerWord] = chkData[columnIndex++];


                    }
                    dt.Rows.Add(dr);

                }
                CheckIn checkin = new CheckIn();
                checkin.card_number = chkData[0];
                checkin.name = chkData[1];
                checkin.day = chkData[2];
                checkin.date = DateTime.Parse(chkData[3]);
                checkin.checkIn_time = chkData[4];
                checkin.checkOut_time = chkData[5];

                ch.Add(checkin);

                foreach (CheckIn chk in ch) {
                    Console.WriteLine("Objects:  "+chk.card_number);
                }
                string path = "C:\\Users\\anjil\\Desktop\\checkins.csv";

                if (!File.Exists(path))
                {
                    File.Create(path);

                }

                using (StreamWriter writer = new StreamWriter(path, append: true))
                {
                    
                        //  Console.WriteLine(i.card_number + i.first_name);
                writer.WriteLine(cardField.Text + "," + nmField.Text + "," + day.DayOfWeek.ToString() + "," + day.Date + "," + day.ToLongDateString() + "," + "" + "," + "");




                    
                }
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

        }

        private void chkOutBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            DataGridViewRow chkD = dataGridView1.Rows[rowVal];

            chkD.Cells[4].Value = DateTime.Now.ToLongTimeString();
            rowVal = 0;
            /*int i = dataGridView1.CurrentRow.Index;
            if (i != 0 || i != null)
            {
                row.Cells[i].Value = DateTime.Now.Date;
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visitor existinVisitor = ls.Where(x => x.card_number == cardField.Text).FirstOrDefault();
            if (existinVisitor != null && existinVisitor.card_number == cardField.Text)
            {
                nmField.Text = existinVisitor.first_name;
                chkInBtn.Enabled = true;
                chkOutBtn.Enabled = true;

            }
            else {

                MessageBox.Show("Not found.Register First.");
                nmField.Text = "";
                cardField.Text = "";
                chkInBtn.Enabled = false;
                chkOutBtn.Enabled = false;

            }

        }

      
    }
}
