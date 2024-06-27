namespace Expense_Tracker
{
    partial class QueryControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnDownloadReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvQueryResults = new System.Windows.Forms.DataGridView();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(132, 20);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(295, 23);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(539, 21);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(292, 23);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(23, 28);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.Click += new System.EventHandler(this.lblStartDate_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(436, 26);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 17);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date:";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Location = new System.Drawing.Point(720, 89);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(112, 46);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // btnDownloadReport
            // 
            this.btnDownloadReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadReport.Location = new System.Drawing.Point(720, 154);
            this.btnDownloadReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDownloadReport.Name = "btnDownloadReport";
            this.btnDownloadReport.Size = new System.Drawing.Size(112, 84);
            this.btnDownloadReport.TabIndex = 5;
            this.btnDownloadReport.Text = "Download Report";
            this.btnDownloadReport.UseVisualStyleBackColor = true;
            this.btnDownloadReport.Click += new System.EventHandler(this.BtnDownloadReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(720, 256);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 46);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dgvQueryResults
            // 
            this.dgvQueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResults.Location = new System.Drawing.Point(27, 89);
            this.dgvQueryResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQueryResults.Name = "dgvQueryResults";
            this.dgvQueryResults.RowTemplate.Height = 25;
            this.dgvQueryResults.Size = new System.Drawing.Size(685, 213);
            this.dgvQueryResults.TabIndex = 7;
            // 
            // pieChart
            // 
            this.pieChart.BackColor = System.Drawing.Color.White;
            this.pieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChart.ForeColor = System.Drawing.Color.White;
            this.pieChart.Location = new System.Drawing.Point(27, 309);
            this.pieChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(685, 213);
            this.pieChart.TabIndex = 8;
            this.pieChart.Text = "pieChart";
            // 
            // QueryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.dgvQueryResults);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDownloadReport);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QueryControl";
            this.Size = new System.Drawing.Size(843, 546);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnDownloadReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvQueryResults;
        private LiveCharts.WinForms.PieChart pieChart;
    }
}
