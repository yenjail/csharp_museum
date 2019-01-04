using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;


namespace ApplicationDev
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try {

                //String st = File.ReadAllText("C:\\Users\\anjil\\Desktop\\desm.csv");
                //Console.WriteLine(st);
                List<string> ls = new List<string>();
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
            }
            catch (Exception e1) {
                Console.WriteLine(e1.Message);
            }


        }

       
    }
}
