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
            this.chkOutBtn = new System.Windows.Forms.Button();
            this.chkInBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkInColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkOutColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            // chkOutBtn
            // 
            this.chkOutBtn.Location = new System.Drawing.Point(119, 95);
            this.chkOutBtn.Name = "chkOutBtn";
            this.chkOutBtn.Size = new System.Drawing.Size(75, 23);
            this.chkOutBtn.TabIndex = 7;
            this.chkOutBtn.Text = "Check Out";
            this.chkOutBtn.UseVisualStyleBackColor = true;
            this.chkOutBtn.Click += new System.EventHandler(this.chkOutBtn_Click);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayColumn,
            this.cardColumn,
            this.nameColumn,
            this.chkInColumn,
            this.chkOutColumn,
            this.totalTimeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(65, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 10;
            this.dataGridView1.Size = new System.Drawing.Size(685, 163);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dayColumn
            // 
            this.dayColumn.HeaderText = "Day";
            this.dayColumn.Name = "dayColumn";
            this.dayColumn.ReadOnly = true;
            // 
            // cardColumn
            // 
            this.cardColumn.HeaderText = "Card Number";
            this.cardColumn.Name = "cardColumn";
            this.cardColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // chkInColumn
            // 
            this.chkInColumn.HeaderText = "Check In";
            this.chkInColumn.Name = "chkInColumn";
            this.chkInColumn.ReadOnly = true;
            // 
            // chkOutColumn
            // 
            this.chkOutColumn.HeaderText = "Check Out";
            this.chkOutColumn.Name = "chkOutColumn";
            this.chkOutColumn.ReadOnly = true;
            // 
            // totalTimeColumn
            // 
            this.totalTimeColumn.HeaderText = "Total Time";
            this.totalTimeColumn.Name = "totalTimeColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkInColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkOutColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeColumn;
        private System.Windows.Forms.Button button1;
    }
}

