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

        List<Visitor> ls = new List<Visitor>();
        

        public Register(List<string> vstrs)
        {
            InitializeComponent();
            Console.WriteLine("Constructor data:  ");
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

        private void button1_Click(object sender, EventArgs e)
        {

            try {

                //String st = File.ReadAllText("C:\\Users\\anjil\\Desktop\\desm.csv");
                //Console.WriteLine(st);
                
                Visitor existinVisitor = ls.Where(x => x.card_number == regCardNumber.Text).FirstOrDefault();
                if (existinVisitor != null && existinVisitor.card_number == regCardNumber.Text)
                {
                    MessageBox.Show("Card Number Already taken.");
                }
                else if (regCardNumber.Text.Equals("")) {
                    MessageBox.Show("Dont leave empty fields.");

                }
                else{

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
                    string path = "C:\\Users\\anjil\\Desktop\\desm.csv";

                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                    using (StreamWriter writer = new StreamWriter(path, append: true))
                    {
                       
                            //Console.WriteLine(i.card_number + i.first_name);
                            writer.WriteLine(regCardNumber.Text + "," + firstNameTxt.Text + "," +last_nameTxt.Text + "," + addressText.Text + "," + contactTxt.Text + "," + genderTxt.Text + "," + emailTxt.Text + "," + occupationTxt.Text);

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
            catch (Exception e1) {
                Console.WriteLine(e1.Message);
            }


        }

       
    }
}
