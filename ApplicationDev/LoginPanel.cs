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
    public partial class LoginPanel : Form
    {
        List<Login> lst = new List<Login>();
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void btnLgn_Click(object sender, EventArgs e)
        {
            Login existinUser = lst.Where(x => x.UserName == txtUsrLgn.Text).FirstOrDefault();
            if(existinUser != null && existinUser.Password != txtPwdLgn.Text)
            {
                lblwlcm.Text = "Welcome " + txtUsrLgn;   
            }
            else{
                lblwlcm.Text = "Welcome " + txtUsrLgn;
                Login l = new Login();
                l.UserName = txtUsrLgn.Text;
                l.Password = txtPwdLgn.Text;
                lst.Add(l);
                
            }

        }
    }
}
