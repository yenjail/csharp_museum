using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDev
{
    public partial class Search : Form
    {
        
        public Search(List<string> infos,String number)
        {
            InitializeComponent();
            DataTable dt = new DataTable();

            var visit = from visitor in infos

                        where visitor.Contains(number)
                        select visitor;

            List<string> cards = new List<string>();
            foreach (string s in visit)
            {


                string vals = s.ToString();
                string[] n = vals.Split(',');
                cards.Add(n[0]);
                
                this.dataGridView1.Rows.Add(n[0],n[1], n[2], DateTime.Parse(n[3]).ToShortDateString(), n[4], n[5], n[6]);
            }




        }

        private void Search_Load(object sender, EventArgs e)
        {
           
        }
    }
}
