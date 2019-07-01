namespace FitnessHole
{
    partial class CreateCustomer
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
            this.dtgwCustomers = new System.Windows.Forms.DataGridView();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgwCustomers
            // 
            this.dtgwCustomers.AllowUserToAddRows = false;
            this.dtgwCustomers.AllowUserToDeleteRows = false;
            this.dtgwCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgwCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dtgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgwCustomers.Location = new System.Drawing.Point(0, 286);
            this.dtgwCustomers.Name = "dtgwCustomers";
            this.dtgwCustomers.ReadOnly = true;
            this.dtgwCustomers.RowHeadersWidth = 51;
            this.dtgwCustomers.RowTemplate.Height = 24;
            this.dtgwCustomers.Size = new System.Drawing.Size(621, 203);
            this.dtgwCustomers.TabIndex = 0;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(18, 114);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(267, 36);
            this.txtFname.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 39;
            this.label1.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(621, 64);
            this.label4.TabIndex = 40;
            this.label4.Text = "Create customer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(334, 114);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(267, 36);
            this.txtLname.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(328, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 34);
            this.label2.TabIndex = 42;
            this.label2.Text = "Lastname";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Teal;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(18, 170);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(583, 85);
            this.btnCreate.TabIndex = 43;
            this.btnCreate.Text = "Create customer";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 489);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgwCustomers);
            this.Name = "CreateCustomer";
            this.Text = "CreateCustomer";
            this.Load += new System.EventHandler(this.CreateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgwCustomers;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
    }
}