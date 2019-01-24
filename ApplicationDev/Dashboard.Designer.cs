namespace ApplicationDev
{
    partial class Dashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generate = new System.Windows.Forms.Button();
            this.occupationTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.last_nameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.regCardNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.genderTxt = new System.Windows.Forms.ComboBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Label();
            this.recordPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gnField = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.emField = new System.Windows.Forms.Label();
            this.adField = new System.Windows.Forms.Label();
            this.ocField = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.chkInBtn = new System.Windows.Forms.Button();
            this.cardField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nmField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkChkIn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.checkCheckInTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.registerBar = new System.Windows.Forms.ProgressBar();
            this.recordBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyMEnu = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.conField = new System.Windows.Forms.Label();
            this.registerPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.recordPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(363, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(498, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Record";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.registerPanel.Controls.Add(this.groupBox1);
            this.registerPanel.Controls.Add(this.Register);
            this.registerPanel.Location = new System.Drawing.Point(12, 151);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(630, 472);
            this.registerPanel.TabIndex = 2;
            this.registerPanel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.generate);
            this.groupBox1.Controls.Add(this.occupationTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.last_nameTxt);
            this.groupBox1.Controls.Add(this.emailTxt);
            this.groupBox1.Controls.Add(this.regCardNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.contactTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addressText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.genderTxt);
            this.groupBox1.Controls.Add(this.firstNameTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(42, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(255, 36);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 19;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // occupationTxt
            // 
            this.occupationTxt.Location = new System.Drawing.Point(398, 152);
            this.occupationTxt.Name = "occupationTxt";
            this.occupationTxt.Size = new System.Drawing.Size(121, 20);
            this.occupationTxt.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Occupation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email Address";
            // 
            // last_nameTxt
            // 
            this.last_nameTxt.Location = new System.Drawing.Point(398, 72);
            this.last_nameTxt.Name = "last_nameTxt";
            this.last_nameTxt.Size = new System.Drawing.Size(121, 20);
            this.last_nameTxt.TabIndex = 14;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(398, 114);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(121, 20);
            this.emailTxt.TabIndex = 13;
            // 
            // regCardNumber
            // 
            this.regCardNumber.Enabled = false;
            this.regCardNumber.Location = new System.Drawing.Point(139, 37);
            this.regCardNumber.Name = "regCardNumber";
            this.regCardNumber.Size = new System.Drawing.Size(79, 20);
            this.regCardNumber.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Card Number";
            // 
            // contactTxt
            // 
            this.contactTxt.Location = new System.Drawing.Point(138, 114);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(121, 20);
            this.contactTxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contact";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(138, 152);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(121, 20);
            this.addressText.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Register";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // genderTxt
            // 
            this.genderTxt.FormattingEnabled = true;
            this.genderTxt.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderTxt.Location = new System.Drawing.Point(138, 191);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(121, 21);
            this.genderTxt.TabIndex = 4;
            this.genderTxt.Tag = "";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(138, 72);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(121, 20);
            this.firstNameTxt.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "First Name";
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Location = new System.Drawing.Point(266, 88);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(46, 13);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register";
            // 
            // recordPanel
            // 
            this.recordPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.recordPanel.Controls.Add(this.groupBox3);
            this.recordPanel.Controls.Add(this.label1);
            this.recordPanel.Location = new System.Drawing.Point(51, 174);
            this.recordPanel.Name = "recordPanel";
            this.recordPanel.Size = new System.Drawing.Size(906, 597);
            this.recordPanel.TabIndex = 3;
            this.recordPanel.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(27, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 443);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.conField);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.gnField);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.emField);
            this.groupBox2.Controls.Add(this.adField);
            this.groupBox2.Controls.Add(this.ocField);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.chkInBtn);
            this.groupBox2.Controls.Add(this.cardField);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nmField);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(20, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 182);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitor Entry";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(215, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Gender:";
            // 
            // gnField
            // 
            this.gnField.AutoSize = true;
            this.gnField.Location = new System.Drawing.Point(91, 154);
            this.gnField.Name = "gnField";
            this.gnField.Size = new System.Drawing.Size(0, 13);
            this.gnField.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Gender:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 20;
            // 
            // emField
            // 
            this.emField.AutoSize = true;
            this.emField.Location = new System.Drawing.Point(93, 120);
            this.emField.Name = "emField";
            this.emField.Size = new System.Drawing.Size(0, 13);
            this.emField.TabIndex = 19;
            // 
            // adField
            // 
            this.adField.AutoSize = true;
            this.adField.Location = new System.Drawing.Point(283, 86);
            this.adField.Name = "adField";
            this.adField.Size = new System.Drawing.Size(0, 13);
            this.adField.TabIndex = 18;
            // 
            // ocField
            // 
            this.ocField.AutoSize = true;
            this.ocField.Location = new System.Drawing.Point(93, 82);
            this.ocField.Name = "ocField";
            this.ocField.Size = new System.Drawing.Size(0, 13);
            this.ocField.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(214, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Contact:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(216, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Occupation:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(201, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Check";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkInBtn
            // 
            this.chkInBtn.Enabled = false;
            this.chkInBtn.Location = new System.Drawing.Point(368, 149);
            this.chkInBtn.Name = "chkInBtn";
            this.chkInBtn.Size = new System.Drawing.Size(75, 23);
            this.chkInBtn.TabIndex = 6;
            this.chkInBtn.Text = "Check In";
            this.chkInBtn.UseVisualStyleBackColor = true;
            this.chkInBtn.Click += new System.EventHandler(this.chkInBtn_Click);
            // 
            // cardField
            // 
            this.cardField.Location = new System.Drawing.Point(96, 19);
            this.cardField.Name = "cardField";
            this.cardField.Size = new System.Drawing.Size(98, 20);
            this.cardField.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Name";
            // 
            // nmField
            // 
            this.nmField.Location = new System.Drawing.Point(96, 45);
            this.nmField.Name = "nmField";
            this.nmField.ReadOnly = true;
            this.nmField.Size = new System.Drawing.Size(177, 20);
            this.nmField.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Card Number:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox4.Controls.Add(this.checkChkIn);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.checkCheckInTxt);
            this.groupBox4.Location = new System.Drawing.Point(522, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 147);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Check Out";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Card Number:";
            // 
            // checkCheckInTxt
            // 
            this.checkCheckInTxt.Location = new System.Drawing.Point(25, 52);
            this.checkCheckInTxt.Name = "checkCheckInTxt";
            this.checkCheckInTxt.Size = new System.Drawing.Size(100, 20);
            this.checkCheckInTxt.TabIndex = 10;
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record";
            // 
            // registerBar
            // 
            this.registerBar.Location = new System.Drawing.Point(363, 106);
            this.registerBar.Name = "registerBar";
            this.registerBar.Size = new System.Drawing.Size(74, 10);
            this.registerBar.TabIndex = 4;
            this.registerBar.Visible = false;
            // 
            // recordBar
            // 
            this.recordBar.Location = new System.Drawing.Point(500, 106);
            this.recordBar.Name = "recordBar";
            this.recordBar.Size = new System.Drawing.Size(73, 10);
            this.recordBar.TabIndex = 5;
            this.recordBar.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 12;
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
            // 
            // conField
            // 
            this.conField.AutoSize = true;
            this.conField.Location = new System.Drawing.Point(275, 117);
            this.conField.Name = "conField";
            this.conField.Size = new System.Drawing.Size(0, 13);
            this.conField.TabIndex = 24;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(966, 749);
            this.Controls.Add(this.recordPanel);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.recordBar);
            this.Controls.Add(this.registerBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.recordPanel.ResumeLayout(false);
            this.recordPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Panel recordPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.ProgressBar registerBar;
        private System.Windows.Forms.ProgressBar recordBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox occupationTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox last_nameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox regCardNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox genderTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button chkInBtn;
        private System.Windows.Forms.TextBox cardField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nmField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button checkChkIn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox checkCheckInTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn inTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn outTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTime;
        private System.Windows.Forms.DataGridViewButtonColumn checkOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyMEnu;
        private System.Windows.Forms.ToolStripMenuItem weeklyMenu;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label gnField;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label emField;
        private System.Windows.Forms.Label adField;
        private System.Windows.Forms.Label ocField;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label conField;
    }
}