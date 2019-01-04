namespace ApplicationDev
{
    partial class LoginPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLgn = new System.Windows.Forms.Button();
            this.txtUsrLgn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwdLgn = new System.Windows.Forms.TextBox();
            this.lblwlcm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLgn
            // 
            this.btnLgn.Location = new System.Drawing.Point(247, 190);
            this.btnLgn.Name = "btnLgn";
            this.btnLgn.Size = new System.Drawing.Size(75, 23);
            this.btnLgn.TabIndex = 0;
            this.btnLgn.Text = "Login";
            this.btnLgn.UseVisualStyleBackColor = true;
            this.btnLgn.Click += new System.EventHandler(this.btnLgn_Click);
            // 
            // txtUsrLgn
            // 
            this.txtUsrLgn.Location = new System.Drawing.Point(289, 84);
            this.txtUsrLgn.Name = "txtUsrLgn";
            this.txtUsrLgn.Size = new System.Drawing.Size(100, 20);
            this.txtUsrLgn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtPwdLgn
            // 
            this.txtPwdLgn.Location = new System.Drawing.Point(289, 128);
            this.txtPwdLgn.Name = "txtPwdLgn";
            this.txtPwdLgn.Size = new System.Drawing.Size(100, 20);
            this.txtPwdLgn.TabIndex = 3;
            // 
            // lblwlcm
            // 
            this.lblwlcm.AutoSize = true;
            this.lblwlcm.Location = new System.Drawing.Point(212, 252);
            this.lblwlcm.Name = "lblwlcm";
            this.lblwlcm.Size = new System.Drawing.Size(37, 13);
            this.lblwlcm.TabIndex = 5;
            this.lblwlcm.Text = "Status";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblwlcm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPwdLgn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsrLgn);
            this.Controls.Add(this.btnLgn);
            this.Name = "LoginPanel";
            this.Text = "LoginPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLgn;
        private System.Windows.Forms.TextBox txtUsrLgn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwdLgn;
        private System.Windows.Forms.Label lblwlcm;
    }
}