namespace FitnessHole
{
    partial class CreateService
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
            this.dtgwServices = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPriceperhour = new System.Windows.Forms.NumericUpDown();
            this.numLimitlessprice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceperhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitlessprice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgwServices
            // 
            this.dtgwServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgwServices.BackgroundColor = System.Drawing.Color.White;
            this.dtgwServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwServices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgwServices.Location = new System.Drawing.Point(0, 312);
            this.dtgwServices.Name = "dtgwServices";
            this.dtgwServices.RowHeadersWidth = 51;
            this.dtgwServices.RowTemplate.Height = 24;
            this.dtgwServices.Size = new System.Drawing.Size(707, 238);
            this.dtgwServices.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service name";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(18, 126);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(197, 36);
            this.txtServiceName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(248, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price per hour";
            // 
            // numPriceperhour
            // 
            this.numPriceperhour.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceperhour.Location = new System.Drawing.Point(254, 127);
            this.numPriceperhour.Name = "numPriceperhour";
            this.numPriceperhour.Size = new System.Drawing.Size(198, 36);
            this.numPriceperhour.TabIndex = 2;
            // 
            // numLimitlessprice
            // 
            this.numLimitlessprice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLimitlessprice.Location = new System.Drawing.Point(493, 127);
            this.numLimitlessprice.Name = "numLimitlessprice";
            this.numLimitlessprice.Size = new System.Drawing.Size(196, 36);
            this.numLimitlessprice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(487, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Limitless price";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(707, 64);
            this.label4.TabIndex = 7;
            this.label4.Text = "Create service";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateService
            // 
            this.btnCreateService.BackColor = System.Drawing.Color.Teal;
            this.btnCreateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateService.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateService.ForeColor = System.Drawing.Color.White;
            this.btnCreateService.Location = new System.Drawing.Point(18, 185);
            this.btnCreateService.Name = "btnCreateService";
            this.btnCreateService.Size = new System.Drawing.Size(671, 86);
            this.btnCreateService.TabIndex = 4;
            this.btnCreateService.Text = "Create service";
            this.btnCreateService.UseVisualStyleBackColor = false;
            this.btnCreateService.Click += new System.EventHandler(this.BtnCreateService_Click);
            // 
            // CreateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 550);
            this.Controls.Add(this.btnCreateService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numLimitlessprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPriceperhour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgwServices);
            this.Name = "CreateService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateService";
            this.Load += new System.EventHandler(this.CreateService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceperhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitlessprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgwServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPriceperhour;
        private System.Windows.Forms.NumericUpDown numLimitlessprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateService;
    }
}