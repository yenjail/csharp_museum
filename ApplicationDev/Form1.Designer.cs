using System.Data;

namespace ApplicationDev
{
    partial class Form1
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
            this.cardField = new System.Windows.Forms.TextBox();
            this.nmField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkOutBtn = new System.Windows.Forms.Button();
            this.chkInBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardField
            // 
            this.cardField.Location = new System.Drawing.Point(96, 19);
            this.cardField.Name = "cardField";
            this.cardField.Size = new System.Drawing.Size(98, 20);
            this.cardField.TabIndex = 0;
            //
            // nmField
            // 
            this.nmField.Location = new System.Drawing.Point(96, 45);
            this.nmField.Name = "nmField";
            this.nmField.ReadOnly = true;
            this.nmField.Size = new System.Drawing.Size(98, 20);
            this.nmField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chkOutBtn);
            this.groupBox1.Controls.Add(this.chkInBtn);
            this.groupBox1.Controls.Add(this.cardField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(267, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 137);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor Entry";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkOutBtn
            // 
            this.chkOutBtn.Location = new System.Drawing.Point(119, 95);
            this.chkOutBtn.Name = "chkOutBtn";
            this.chkOutBtn.Size = new System.Drawing.Size(75, 23);
            this.chkOutBtn.TabIndex = 7;
            this.chkOutBtn.Text = "Check Out";
            this.chkOutBtn.UseVisualStyleBackColor = true;
            this.chkOutBtn.Click += new System.EventHandler(this.chkOutBtn_Click);
            this.chkOutBtn.Enabled = false;
            // 
            // chkInBtn
            // 
            this.chkInBtn.Location = new System.Drawing.Point(17, 95);
            this.chkInBtn.Name = "chkInBtn";
            this.chkInBtn.Size = new System.Drawing.Size(75, 23);
            this.chkInBtn.TabIndex = 6;
            this.chkInBtn.Text = "Check In";
            this.chkInBtn.UseVisualStyleBackColor = true;
            this.chkInBtn.Click += new System.EventHandler(this.chkInBtn_Click);
            this.chkInBtn.Enabled = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 197);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox cardField;
        private System.Windows.Forms.TextBox nmField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chkOutBtn;
        private System.Windows.Forms.Button chkInBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

