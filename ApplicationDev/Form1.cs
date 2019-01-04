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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int rowVal;


        private void chkInBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = DateTime.Now.DayOfWeek;
            row.Cells[1].Value = cardField.Text;
            row.Cells[2].Value = nmField.Text;
            row.Cells[3].Value = DateTime.Now.Date;

            

          /*
            if (rowVal!=0 || rowVal!=null) {
                row.Cells[rowVal].Value = DateTime.Now.Date;
            }
            */

            dataGridView1.Rows.Add(row);
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

            /*int i = dataGridView1.CurrentRow.Index;
            if (i != 0 || i != null)
            {
                row.Cells[i].Value = DateTime.Now.Date;
            }
            */
        }
    }
}
