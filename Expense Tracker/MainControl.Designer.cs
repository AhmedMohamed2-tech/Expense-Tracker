namespace Expense_Tracker
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnPieChart = new System.Windows.Forms.Button();
            this.btnDownloadReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(23, 21);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(141, 21);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(300, 23);
            this.dateTimePicker.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(23, 64);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(141, 64);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(300, 24);
            this.cmbCategory.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(23, 107);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 17);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(141, 107);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(300, 23);
            this.txtAmount.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(23, 149);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(141, 149);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 23);
            this.txtDescription.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(617, 196);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 54);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Expense";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(732, 193);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 57);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit Expense";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(732, 257);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 54);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Expense";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(13, 193);
            this.dgvExpenses.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowTemplate.Height = 25;
            this.dgvExpenses.Size = new System.Drawing.Size(596, 213);
            this.dgvExpenses.TabIndex = 11;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Location = new System.Drawing.Point(617, 356);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(107, 50);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // btnPieChart
            // 
            this.btnPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPieChart.Location = new System.Drawing.Point(617, 257);
            this.btnPieChart.Margin = new System.Windows.Forms.Padding(4);
            this.btnPieChart.Name = "btnPieChart";
            this.btnPieChart.Size = new System.Drawing.Size(107, 54);
            this.btnPieChart.TabIndex = 17;
            this.btnPieChart.Text = "Pie Chart";
            this.btnPieChart.UseVisualStyleBackColor = true;
            this.btnPieChart.Click += new System.EventHandler(this.BtnPieChart_Click);
            // 
            // btnDownloadReport
            // 
            this.btnDownloadReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadReport.Location = new System.Drawing.Point(617, 319);
            this.btnDownloadReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownloadReport.Name = "btnDownloadReport";
            this.btnDownloadReport.Size = new System.Drawing.Size(217, 30);
            this.btnDownloadReport.TabIndex = 18;
            this.btnDownloadReport.Text = "Download Report";
            this.btnDownloadReport.UseVisualStyleBackColor = true;
            this.btnDownloadReport.Click += new System.EventHandler(this.BtnDownloadReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(732, 356);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 50);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(470, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 151);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDownloadReport);
            this.Controls.Add(this.btnPieChart);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(852, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnPieChart;
        private System.Windows.Forms.Button btnDownloadReport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
