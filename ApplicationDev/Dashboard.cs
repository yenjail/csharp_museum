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
    public partial class Dashboard : Form
    {
        List<string> vstrs;
       

        public Dashboard(List<string> visitors)
        {
            InitializeComponent();
            vstrs = visitors;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Register rs = new Register(vstrs);
            rs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(vstrs);
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPanel ln = new LoginPanel();
            ln.Show();
        }
    }
}
