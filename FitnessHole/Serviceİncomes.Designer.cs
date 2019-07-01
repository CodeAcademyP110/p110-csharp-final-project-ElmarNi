namespace FitnessHole
{
    partial class Serviceİncomes
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
            this.btnAll = new System.Windows.Forms.Button();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgwServs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwServs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Teal;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(12, 83);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(776, 64);
            this.btnAll.TabIndex = 11;
            this.btnAll.Text = "Show all incomes from services";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // txtIncome
            // 
            this.txtIncome.Enabled = false;
            this.txtIncome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(676, 41);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(112, 36);
            this.txtIncome.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(670, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Income";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(12, 41);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(244, 35);
            this.cmbEmployees.TabIndex = 8;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort by Employee";
            // 
            // dtgwServs
            // 
            this.dtgwServs.AllowUserToAddRows = false;
            this.dtgwServs.AllowUserToDeleteRows = false;
            this.dtgwServs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgwServs.BackgroundColor = System.Drawing.Color.White;
            this.dtgwServs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwServs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgwServs.Location = new System.Drawing.Point(0, 161);
            this.dtgwServs.Name = "dtgwServs";
            this.dtgwServs.ReadOnly = true;
            this.dtgwServs.RowHeadersWidth = 51;
            this.dtgwServs.RowTemplate.Height = 24;
            this.dtgwServs.Size = new System.Drawing.Size(801, 284);
            this.dtgwServs.TabIndex = 6;
            // 
            // Serviceİncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 445);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgwServs);
            this.Name = "Serviceİncomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviceİncomes";
            this.Load += new System.EventHandler(this.Serviceİncomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwServs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgwServs;
    }
}