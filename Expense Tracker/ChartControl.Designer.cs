namespace Expense_Tracker
{
    partial class ChartControl
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
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            this.pieChart.BackColor = System.Drawing.Color.Transparent;
            this.pieChart.ForeColor = System.Drawing.Color.White;
            this.pieChart.Location = new System.Drawing.Point(23, 21);
            this.pieChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(507, 398);
            this.pieChart.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 426);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 25);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ChartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pieChart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChartControl";
            this.Size = new System.Drawing.Size(551, 454);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart;
        private System.Windows.Forms.Button btnBack;
    }
}