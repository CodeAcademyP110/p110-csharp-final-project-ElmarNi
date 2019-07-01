namespace FitnessHole
{
    partial class UpdateService
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
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numLimitlessprice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numPriceperhour = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgwServices = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitlessprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceperhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwServices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateService.Enabled = false;
            this.btnUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateService.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateService.ForeColor = System.Drawing.Color.White;
            this.btnUpdateService.Location = new System.Drawing.Point(18, 185);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(784, 86);
            this.btnUpdateService.TabIndex = 14;
            this.btnUpdateService.Text = "Update service";
            this.btnUpdateService.UseVisualStyleBackColor = false;
            this.btnUpdateService.Click += new System.EventHandler(this.BtnUpdateService_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(819, 64);
            this.label4.TabIndex = 16;
            this.label4.Text = "Update service";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLimitlessprice
            // 
            this.numLimitlessprice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLimitlessprice.Location = new System.Drawing.Point(493, 127);
            this.numLimitlessprice.Name = "numLimitlessprice";
            this.numLimitlessprice.Size = new System.Drawing.Size(196, 36);
            this.numLimitlessprice.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(487, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Limitless price";
            // 
            // numPriceperhour
            // 
            this.numPriceperhour.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceperhour.Location = new System.Drawing.Point(254, 127);
            this.numPriceperhour.Name = "numPriceperhour";
            this.numPriceperhour.Size = new System.Drawing.Size(198, 36);
            this.numPriceperhour.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(248, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price per hour";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(18, 126);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(197, 36);
            this.txtServiceName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Service name";
            // 
            // dtgwServices
            // 
            this.dtgwServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgwServices.BackgroundColor = System.Drawing.Color.White;
            this.dtgwServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwServices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgwServices.Location = new System.Drawing.Point(0, 316);
            this.dtgwServices.Name = "dtgwServices";
            this.dtgwServices.RowHeadersWidth = 51;
            this.dtgwServices.RowTemplate.Height = 24;
            this.dtgwServices.Size = new System.Drawing.Size(819, 238);
            this.dtgwServices.TabIndex = 8;
            this.dtgwServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgwServices_CellClick);
            // 
            // cbStatus
            // 
            this.cbStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbStatus.Location = new System.Drawing.Point(712, 126);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(90, 36);
            this.cbStatus.TabIndex = 28;
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(706, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 34);
            this.label7.TabIndex = 27;
            this.label7.Text = "Status";
            // 
            // UpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 554);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numLimitlessprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPriceperhour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgwServices);
            this.Name = "UpdateService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateService";
            this.Load += new System.EventHandler(this.UpdateService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLimitlessprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceperhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLimitlessprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPriceperhour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgwServices;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label label7;
    }
}