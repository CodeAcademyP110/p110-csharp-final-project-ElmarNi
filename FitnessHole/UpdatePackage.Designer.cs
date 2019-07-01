namespace FitnessHole
{
    partial class UpdatePackage
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbOdddays = new System.Windows.Forms.CheckBox();
            this.cbEvendays = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAllday = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.txtPackName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddservice = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlServices = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.dtgwPacks = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwPacks)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(0, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1149, 64);
            this.label10.TabIndex = 42;
            this.label10.Text = "Services";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(880, 36);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(256, 162);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update pack";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cbOdddays
            // 
            this.cbOdddays.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbOdddays.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOdddays.Location = new System.Drawing.Point(497, 174);
            this.cbOdddays.Name = "cbOdddays";
            this.cbOdddays.Size = new System.Drawing.Size(236, 24);
            this.cbOdddays.TabIndex = 7;
            this.cbOdddays.UseVisualStyleBackColor = true;
            this.cbOdddays.CheckedChanged += new System.EventHandler(this.CbOdddays_CheckedChanged);
            // 
            // cbEvendays
            // 
            this.cbEvendays.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbEvendays.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvendays.Location = new System.Drawing.Point(235, 174);
            this.cbEvendays.Name = "cbEvendays";
            this.cbEvendays.Size = new System.Drawing.Size(250, 24);
            this.cbEvendays.TabIndex = 6;
            this.cbEvendays.UseVisualStyleBackColor = true;
            this.cbEvendays.CheckedChanged += new System.EventHandler(this.CbEvendays_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbOdddays);
            this.panel1.Controls.Add(this.cbEvendays);
            this.panel1.Controls.Add(this.cbAllday);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtEndTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numPrice);
            this.panel1.Controls.Add(this.txtPackName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtStartTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 220);
            this.panel1.TabIndex = 41;
            // 
            // cbAllday
            // 
            this.cbAllday.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAllday.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllday.Location = new System.Drawing.Point(23, 174);
            this.cbAllday.Name = "cbAllday";
            this.cbAllday.Size = new System.Drawing.Size(200, 24);
            this.cbAllday.TabIndex = 5;
            this.cbAllday.UseVisualStyleBackColor = true;
            this.cbAllday.CheckedChanged += new System.EventHandler(this.CbAllday_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(17, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 34);
            this.label8.TabIndex = 43;
            this.label8.Text = "Active all day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(229, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 34);
            this.label7.TabIndex = 42;
            this.label7.Text = "Active even days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(491, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 34);
            this.label6.TabIndex = 41;
            this.label6.Text = "Active odd days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(718, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 34);
            this.label5.TabIndex = 40;
            this.label5.Text = "End time";
            // 
            // dtEndTime
            // 
            this.dtEndTime.CalendarFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndTime.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(724, 73);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(139, 36);
            this.dtEndTime.TabIndex = 4;
            this.dtEndTime.Value = new System.DateTime(2019, 6, 29, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(536, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 34);
            this.label3.TabIndex = 39;
            this.label3.Text = "Start time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(284, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 34);
            this.label2.TabIndex = 38;
            this.label2.Text = "Package price";
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(290, 73);
            this.numPrice.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(211, 36);
            this.numPrice.TabIndex = 2;
            // 
            // txtPackName
            // 
            this.txtPackName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackName.Location = new System.Drawing.Point(23, 73);
            this.txtPackName.Name = "txtPackName";
            this.txtPackName.Size = new System.Drawing.Size(224, 36);
            this.txtPackName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 34);
            this.label1.TabIndex = 37;
            this.label1.Text = "Package name";
            // 
            // dtStartTime
            // 
            this.dtStartTime.CalendarFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartTime.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(542, 73);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(139, 36);
            this.dtStartTime.TabIndex = 3;
            this.dtStartTime.Value = new System.DateTime(2019, 6, 29, 0, 0, 0, 0);
            // 
            // btnAddservice
            // 
            this.btnAddservice.BackColor = System.Drawing.Color.Teal;
            this.btnAddservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddservice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddservice.ForeColor = System.Drawing.Color.White;
            this.btnAddservice.Location = new System.Drawing.Point(18, 458);
            this.btnAddservice.Name = "btnAddservice";
            this.btnAddservice.Size = new System.Drawing.Size(224, 56);
            this.btnAddservice.TabIndex = 36;
            this.btnAddservice.Text = "Add service";
            this.btnAddservice.UseVisualStyleBackColor = false;
            this.btnAddservice.Click += new System.EventHandler(this.BtnAddservice_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(12, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 34);
            this.label9.TabIndex = 40;
            this.label9.Text = "Services";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1149, 64);
            this.label4.TabIndex = 37;
            this.label4.Text = "Update package";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlServices);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(285, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 150);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Added services";
            // 
            // pnlServices
            // 
            this.pnlServices.Location = new System.Drawing.Point(6, 21);
            this.pnlServices.Name = "pnlServices";
            this.pnlServices.Size = new System.Drawing.Size(834, 123);
            this.pnlServices.TabIndex = 30;
            // 
            // cmbServices
            // 
            this.cmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServices.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(18, 401);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(224, 35);
            this.cmbServices.TabIndex = 35;
            // 
            // dtgwPacks
            // 
            this.dtgwPacks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgwPacks.BackgroundColor = System.Drawing.Color.White;
            this.dtgwPacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwPacks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgwPacks.Location = new System.Drawing.Point(0, 541);
            this.dtgwPacks.Name = "dtgwPacks";
            this.dtgwPacks.RowHeadersWidth = 51;
            this.dtgwPacks.RowTemplate.Height = 24;
            this.dtgwPacks.Size = new System.Drawing.Size(1149, 218);
            this.dtgwPacks.TabIndex = 38;
            this.dtgwPacks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgwPacks_CellClick);
            // 
            // cbStatus
            // 
            this.cbStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbStatus.Location = new System.Drawing.Point(763, 174);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(90, 36);
            this.cbStatus.TabIndex = 45;
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(757, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 34);
            this.label11.TabIndex = 44;
            this.label11.Text = "Status";
            // 
            // UpdatePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 759);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddservice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbServices);
            this.Controls.Add(this.dtgwPacks);
            this.Name = "UpdatePackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePackage";
            this.Load += new System.EventHandler(this.UpdatePackage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwPacks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cbOdddays;
        private System.Windows.Forms.CheckBox cbEvendays;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbAllday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.TextBox txtPackName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.Button btnAddservice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlServices;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.DataGridView dtgwPacks;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label label11;
    }
}