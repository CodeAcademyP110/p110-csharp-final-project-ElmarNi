namespace FitnessHole
{
    partial class ConfirmPassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 77);
            this.label4.TabIndex = 14;
            this.label4.Text = "Please change password for first time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentpass
            // 
            this.txtCurrentpass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentpass.Location = new System.Drawing.Point(12, 149);
            this.txtCurrentpass.Name = "txtCurrentpass";
            this.txtCurrentpass.Size = new System.Drawing.Size(445, 36);
            this.txtCurrentpass.TabIndex = 38;
            this.txtCurrentpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 34);
            this.label1.TabIndex = 39;
            this.label1.Text = "Current password";
            // 
            // txtNewpass
            // 
            this.txtNewpass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewpass.Location = new System.Drawing.Point(12, 259);
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.Size = new System.Drawing.Size(445, 36);
            this.txtNewpass.TabIndex = 40;
            this.txtNewpass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(6, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 34);
            this.label2.TabIndex = 41;
            this.label2.Text = "New password";
            // 
            // txtConfirmpass
            // 
            this.txtConfirmpass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmpass.Location = new System.Drawing.Point(12, 368);
            this.txtConfirmpass.Name = "txtConfirmpass";
            this.txtConfirmpass.Size = new System.Drawing.Size(445, 36);
            this.txtConfirmpass.TabIndex = 42;
            this.txtConfirmpass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(6, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 34);
            this.label3.TabIndex = 43;
            this.label3.Text = "Confirm password";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Teal;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(12, 437);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(445, 72);
            this.btnConfirm.TabIndex = 44;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // ConfirmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 531);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtConfirmpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "ConfirmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirm;
    }
}