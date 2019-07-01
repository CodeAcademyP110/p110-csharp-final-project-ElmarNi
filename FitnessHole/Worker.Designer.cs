namespace FitnessHole
{
    partial class Worker
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
            this.lblMain = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCostumerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.Orange;
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(1205, 540);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "label1";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCostumerToolStripMenuItem,
            this.buyServiceToolStripMenuItem,
            this.buyPackageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1205, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCostumerToolStripMenuItem
            // 
            this.addCostumerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripMenuItem});
            this.addCostumerToolStripMenuItem.Name = "addCostumerToolStripMenuItem";
            this.addCostumerToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.addCostumerToolStripMenuItem.Text = "Customer";
            // 
            // createCustomerToolStripMenuItem
            // 
            this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.createCustomerToolStripMenuItem.Text = "Create customer";
            this.createCustomerToolStripMenuItem.Click += new System.EventHandler(this.CreateCustomerToolStripMenuItem_Click);
            // 
            // buyServiceToolStripMenuItem
            // 
            this.buyServiceToolStripMenuItem.Name = "buyServiceToolStripMenuItem";
            this.buyServiceToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.buyServiceToolStripMenuItem.Text = "Buy Service";
            this.buyServiceToolStripMenuItem.Click += new System.EventHandler(this.BuyServiceToolStripMenuItem_Click);
            // 
            // buyPackageToolStripMenuItem
            // 
            this.buyPackageToolStripMenuItem.Name = "buyPackageToolStripMenuItem";
            this.buyPackageToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.buyPackageToolStripMenuItem.Text = "Buy Package";
            this.buyPackageToolStripMenuItem.Click += new System.EventHandler(this.BuyPackageToolStripMenuItem_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 540);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblMain);
            this.Name = "Worker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Worker_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCostumerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerToolStripMenuItem;
    }
}