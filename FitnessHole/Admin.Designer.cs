namespace FitnessHole
{
    partial class Admin
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
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allIncomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outcomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.Orange;
            this.lblMain.Location = new System.Drawing.Point(0, 33);
            this.lblMain.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(1194, 615);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "label1";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.packagesToolStripMenuItem,
            this.incomesToolStripMenuItem,
            this.outcomesToolStripMenuItem,
            this.netIncomeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1194, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workersToolStripMenuItem});
            this.employeesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(131, 27);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewWorkerToolStripMenuItem,
            this.updateWorkerToolStripMenuItem});
            this.workersToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.workersToolStripMenuItem.Text = "Workers";
            // 
            // createNewWorkerToolStripMenuItem
            // 
            this.createNewWorkerToolStripMenuItem.Name = "createNewWorkerToolStripMenuItem";
            this.createNewWorkerToolStripMenuItem.Size = new System.Drawing.Size(284, 28);
            this.createNewWorkerToolStripMenuItem.Text = "Create new worker";
            this.createNewWorkerToolStripMenuItem.Click += new System.EventHandler(this.CreateNewWorkerToolStripMenuItem_Click);
            // 
            // updateWorkerToolStripMenuItem
            // 
            this.updateWorkerToolStripMenuItem.Name = "updateWorkerToolStripMenuItem";
            this.updateWorkerToolStripMenuItem.Size = new System.Drawing.Size(284, 28);
            this.updateWorkerToolStripMenuItem.Text = "Update worker";
            this.updateWorkerToolStripMenuItem.Click += new System.EventHandler(this.UpdateWorkerToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewServiceToolStripMenuItem,
            this.updateServiceToolStripMenuItem});
            this.servicesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // createNewServiceToolStripMenuItem
            // 
            this.createNewServiceToolStripMenuItem.Name = "createNewServiceToolStripMenuItem";
            this.createNewServiceToolStripMenuItem.Size = new System.Drawing.Size(287, 28);
            this.createNewServiceToolStripMenuItem.Text = "Create new service";
            this.createNewServiceToolStripMenuItem.Click += new System.EventHandler(this.CreateNewServiceToolStripMenuItem_Click);
            // 
            // updateServiceToolStripMenuItem
            // 
            this.updateServiceToolStripMenuItem.Name = "updateServiceToolStripMenuItem";
            this.updateServiceToolStripMenuItem.Size = new System.Drawing.Size(287, 28);
            this.updateServiceToolStripMenuItem.Text = "Update service";
            this.updateServiceToolStripMenuItem.Click += new System.EventHandler(this.UpdateServiceToolStripMenuItem_Click);
            // 
            // packagesToolStripMenuItem
            // 
            this.packagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewPackageToolStripMenuItem,
            this.updatePackageToolStripMenuItem});
            this.packagesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            this.packagesToolStripMenuItem.Size = new System.Drawing.Size(121, 27);
            this.packagesToolStripMenuItem.Text = "Packages";
            // 
            // createNewPackageToolStripMenuItem
            // 
            this.createNewPackageToolStripMenuItem.Name = "createNewPackageToolStripMenuItem";
            this.createNewPackageToolStripMenuItem.Size = new System.Drawing.Size(309, 28);
            this.createNewPackageToolStripMenuItem.Text = "Create new package";
            this.createNewPackageToolStripMenuItem.Click += new System.EventHandler(this.CreateNewPackageToolStripMenuItem_Click);
            // 
            // updatePackageToolStripMenuItem
            // 
            this.updatePackageToolStripMenuItem.Name = "updatePackageToolStripMenuItem";
            this.updatePackageToolStripMenuItem.Size = new System.Drawing.Size(309, 28);
            this.updatePackageToolStripMenuItem.Text = "Update package";
            this.updatePackageToolStripMenuItem.Click += new System.EventHandler(this.UpdatePackageToolStripMenuItem_Click);
            // 
            // incomesToolStripMenuItem
            // 
            this.incomesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allIncomesToolStripMenuItem,
            this.fromPackagesToolStripMenuItem,
            this.fromServicesToolStripMenuItem});
            this.incomesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomesToolStripMenuItem.Name = "incomesToolStripMenuItem";
            this.incomesToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.incomesToolStripMenuItem.Text = "Incomes";
            // 
            // allIncomesToolStripMenuItem
            // 
            this.allIncomesToolStripMenuItem.Name = "allIncomesToolStripMenuItem";
            this.allIncomesToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.allIncomesToolStripMenuItem.Text = "All incomes";
            this.allIncomesToolStripMenuItem.Click += new System.EventHandler(this.AllIncomesToolStripMenuItem_Click);
            // 
            // fromPackagesToolStripMenuItem
            // 
            this.fromPackagesToolStripMenuItem.Name = "fromPackagesToolStripMenuItem";
            this.fromPackagesToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.fromPackagesToolStripMenuItem.Text = "From packages";
            this.fromPackagesToolStripMenuItem.Click += new System.EventHandler(this.FromPackagesToolStripMenuItem_Click);
            // 
            // fromServicesToolStripMenuItem
            // 
            this.fromServicesToolStripMenuItem.Name = "fromServicesToolStripMenuItem";
            this.fromServicesToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.fromServicesToolStripMenuItem.Text = "From services";
            this.fromServicesToolStripMenuItem.Click += new System.EventHandler(this.FromServicesToolStripMenuItem_Click);
            // 
            // outcomesToolStripMenuItem
            // 
            this.outcomesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomesToolStripMenuItem.Name = "outcomesToolStripMenuItem";
            this.outcomesToolStripMenuItem.Size = new System.Drawing.Size(126, 27);
            this.outcomesToolStripMenuItem.Text = "Outcomes";
            this.outcomesToolStripMenuItem.Click += new System.EventHandler(this.OutcomesToolStripMenuItem_Click);
            // 
            // netIncomeToolStripMenuItem
            // 
            this.netIncomeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netIncomeToolStripMenuItem.Name = "netIncomeToolStripMenuItem";
            this.netIncomeToolStripMenuItem.Size = new System.Drawing.Size(138, 27);
            this.netIncomeToolStripMenuItem.Text = "Net income";
            this.netIncomeToolStripMenuItem.Click += new System.EventHandler(this.NetIncomeToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1194, 648);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allIncomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromPackagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outcomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netIncomeToolStripMenuItem;
    }
}