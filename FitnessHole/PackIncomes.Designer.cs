namespace FitnessHole
{
    partial class PackIncomes
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
            this.dtgwPacks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPacks = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwPacks)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgwPacks
            // 
            this.dtgwPacks.AllowUserToAddRows = false;
            this.dtgwPacks.AllowUserToDeleteRows = false;
            this.dtgwPacks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgwPacks.BackgroundColor = System.Drawing.Color.White;
            this.dtgwPacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwPacks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgwPacks.Location = new System.Drawing.Point(0, 166);
            this.dtgwPacks.Name = "dtgwPacks";
            this.dtgwPacks.ReadOnly = true;
            this.dtgwPacks.RowHeadersWidth = 51;
            this.dtgwPacks.RowTemplate.Height = 24;
            this.dtgwPacks.Size = new System.Drawing.Size(800, 284);
            this.dtgwPacks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort by Package";
            // 
            // cmbPacks
            // 
            this.cmbPacks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacks.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacks.FormattingEnabled = true;
            this.cmbPacks.Location = new System.Drawing.Point(12, 46);
            this.cmbPacks.Name = "cmbPacks";
            this.cmbPacks.Size = new System.Drawing.Size(233, 35);
            this.cmbPacks.TabIndex = 2;
            this.cmbPacks.SelectedIndexChanged += new System.EventHandler(this.CmbPacks_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(670, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Income";
            // 
            // txtIncome
            // 
            this.txtIncome.Enabled = false;
            this.txtIncome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(676, 46);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(112, 36);
            this.txtIncome.TabIndex = 4;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Teal;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(12, 88);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(776, 64);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "Show all incomes from packages";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(328, 46);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(244, 35);
            this.cmbEmployees.TabIndex = 10;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(322, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sort by Employee";
            // 
            // PackIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPacks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgwPacks);
            this.Name = "PackIncomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PackIncomes";
            this.Load += new System.EventHandler(this.PackIncomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwPacks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgwPacks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPacks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label label3;
    }
}