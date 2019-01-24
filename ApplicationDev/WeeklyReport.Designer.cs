namespace ApplicationDev
{
    partial class WeeklyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.daysWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVisitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMinWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sortA = new System.Windows.Forms.Button();
            this.sortD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.daysWeek,
            this.totalVisitor,
            this.totalMinWeek});
            this.dataGridView1.Location = new System.Drawing.Point(101, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(380, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // daysWeek
            // 
            this.daysWeek.HeaderText = "Day";
            this.daysWeek.Name = "daysWeek";
            this.daysWeek.ReadOnly = true;
            // 
            // totalVisitor
            // 
            this.totalVisitor.HeaderText = "Total Visitors";
            this.totalVisitor.Name = "totalVisitor";
            this.totalVisitor.ReadOnly = true;
            // 
            // totalMinWeek
            // 
            this.totalMinWeek.HeaderText = "Total Minutes Spend";
            this.totalMinWeek.Name = "totalMinWeek";
            this.totalMinWeek.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(128, 340);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(520, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // sortA
            // 
            this.sortA.Location = new System.Drawing.Point(101, 17);
            this.sortA.Name = "sortA";
            this.sortA.Size = new System.Drawing.Size(114, 23);
            this.sortA.TabIndex = 2;
            this.sortA.Text = "Sort Ascending";
            this.sortA.UseVisualStyleBackColor = true;
            // 
            // sortD
            // 
            this.sortD.Location = new System.Drawing.Point(221, 17);
            this.sortD.Name = "sortD";
            this.sortD.Size = new System.Drawing.Size(114, 23);
            this.sortD.TabIndex = 3;
            this.sortD.Text = "Sort Descending";
            this.sortD.UseVisualStyleBackColor = true;
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 678);
            this.Controls.Add(this.sortD);
            this.Controls.Add(this.sortA);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            this.Load += new System.EventHandler(this.WeeklyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMinWeek;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button sortA;
        private System.Windows.Forms.Button sortD;
    }
}