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
            this.components = new System.ComponentModel.Container();
            this.cardField = new System.Windows.Forms.TextBox();
            this.nmField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkInBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sortCard = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkChkIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkCheckInTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyMEnu = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.chkInBtn);
            this.groupBox1.Controls.Add(this.cardField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 147);
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
            // chkInBtn
            // 
            this.chkInBtn.Enabled = false;
            this.chkInBtn.Location = new System.Drawing.Point(17, 95);
            this.chkInBtn.Name = "chkInBtn";
            this.chkInBtn.Size = new System.Drawing.Size(75, 23);
            this.chkInBtn.TabIndex = 6;
            this.chkInBtn.Text = "Check In";
            this.chkInBtn.UseVisualStyleBackColor = true;
            this.chkInBtn.Click += new System.EventHandler(this.chkInBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardNumber,
            this.name,
            this.day,
            this.date,
            this.inTime,
            this.outTime,
            this.totalTime,
            this.checkOut});
            this.dataGridView1.Location = new System.Drawing.Point(6, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 197);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cardNumber
            // 
            this.cardNumber.DataPropertyName = "Card Number";
            this.cardNumber.HeaderText = "Card Number";
            this.cardNumber.Name = "cardNumber";
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // day
            // 
            this.day.DataPropertyName = "Day";
            this.day.HeaderText = "Day";
            this.day.Name = "day";
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // inTime
            // 
            this.inTime.DataPropertyName = "In Time";
            this.inTime.HeaderText = "In Time";
            this.inTime.Name = "inTime";
            // 
            // outTime
            // 
            this.outTime.DataPropertyName = "Out Time";
            this.outTime.HeaderText = "Out Time";
            this.outTime.Name = "outTime";
            // 
            // totalTime
            // 
            this.totalTime.DataPropertyName = "Total Duration(Min)";
            this.totalTime.HeaderText = "Total Duration(Min)";
            this.totalTime.Name = "totalTime";
            // 
            // checkOut
            // 
            this.checkOut.HeaderText = "Check Out";
            this.checkOut.Name = "checkOut";
            this.checkOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkOut.Text = "Check Out";
            this.checkOut.UseColumnTextForButtonValue = true;
            // 
            // sortCard
            // 
            this.sortCard.Location = new System.Drawing.Point(50, 229);
            this.sortCard.Name = "sortCard";
            this.sortCard.Size = new System.Drawing.Size(113, 23);
            this.sortCard.TabIndex = 7;
            this.sortCard.Text = "Sort Card Number";
            this.sortCard.UseVisualStyleBackColor = true;
            this.sortCard.Click += new System.EventHandler(this.sortCard_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.checkChkIn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkCheckInTxt);
            this.groupBox2.Location = new System.Drawing.Point(405, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 147);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Out";
            // 
            // checkChkIn
            // 
            this.checkChkIn.Location = new System.Drawing.Point(146, 50);
            this.checkChkIn.Name = "checkChkIn";
            this.checkChkIn.Size = new System.Drawing.Size(75, 23);
            this.checkChkIn.TabIndex = 9;
            this.checkChkIn.Text = "Check";
            this.checkChkIn.UseVisualStyleBackColor = true;
            this.checkChkIn.Click += new System.EventHandler(this.checkChkIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Card Number:";
            // 
            // checkCheckInTxt
            // 
            this.checkCheckInTxt.Location = new System.Drawing.Point(25, 52);
            this.checkCheckInTxt.Name = "checkCheckInTxt";
            this.checkCheckInTxt.Size = new System.Drawing.Size(100, 20);
            this.checkCheckInTxt.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyMEnu,
            this.weeklyMenu});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // dailyMEnu
            // 
            this.dailyMEnu.Name = "dailyMEnu";
            this.dailyMEnu.Size = new System.Drawing.Size(112, 22);
            this.dailyMEnu.Text = "Daily";
            this.dailyMEnu.Click += new System.EventHandler(this.dailyMEnu_Click);
            // 
            // weeklyMenu
            // 
            this.weeklyMenu.Name = "weeklyMenu";
            this.weeklyMenu.Size = new System.Drawing.Size(112, 22);
            this.weeklyMenu.Text = "Weekly";
            this.weeklyMenu.Click += new System.EventHandler(this.weeklyMenu_Click);
            // 
            // checkInBindingSource
            // 
            this.checkInBindingSource.DataSource = typeof(ApplicationDev.CheckIn);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(50, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 534);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 666);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sortCard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardField;
        private System.Windows.Forms.TextBox nmField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chkInBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource checkInBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn inTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn outTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTime;
        private System.Windows.Forms.DataGridViewButtonColumn checkOut;
        private System.Windows.Forms.Button sortCard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox checkCheckInTxt;
        private System.Windows.Forms.Button checkChkIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyMEnu;
        private System.Windows.Forms.ToolStripMenuItem weeklyMenu;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

