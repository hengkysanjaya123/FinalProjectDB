﻿namespace FinalProjectDB
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerEmployeeFamilyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionReportFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fieToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.masterDataToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.importDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewEmployeeToolStripMenuItem,
            this.registerEmployeeFamilyDataToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // registerNewEmployeeToolStripMenuItem
            // 
            this.registerNewEmployeeToolStripMenuItem.Name = "registerNewEmployeeToolStripMenuItem";
            this.registerNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.registerNewEmployeeToolStripMenuItem.Text = "Register new Employee";
            this.registerNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.registerNewEmployeeToolStripMenuItem_Click);
            // 
            // registerEmployeeFamilyDataToolStripMenuItem
            // 
            this.registerEmployeeFamilyDataToolStripMenuItem.Name = "registerEmployeeFamilyDataToolStripMenuItem";
            this.registerEmployeeFamilyDataToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.registerEmployeeFamilyDataToolStripMenuItem.Text = "Entry Employee Family Data";
            this.registerEmployeeFamilyDataToolStripMenuItem.Click += new System.EventHandler(this.registerEmployeeFamilyDataToolStripMenuItem_Click);
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankToolStripMenuItem,
            this.branchToolStripMenuItem,
            this.contractTypeToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.posToolStripMenuItem,
            this.transactionTypeToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bankToolStripMenuItem.Text = "Bank";
            this.bankToolStripMenuItem.Click += new System.EventHandler(this.bankToolStripMenuItem_Click);
            // 
            // branchToolStripMenuItem
            // 
            this.branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            this.branchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.branchToolStripMenuItem.Text = "Branch";
            this.branchToolStripMenuItem.Click += new System.EventHandler(this.branchToolStripMenuItem_Click);
            // 
            // contractTypeToolStripMenuItem
            // 
            this.contractTypeToolStripMenuItem.Name = "contractTypeToolStripMenuItem";
            this.contractTypeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.contractTypeToolStripMenuItem.Text = "Contract Type";
            this.contractTypeToolStripMenuItem.Click += new System.EventHandler(this.contractTypeToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.levelToolStripMenuItem.Text = "Level";
            this.levelToolStripMenuItem.Click += new System.EventHandler(this.levelToolStripMenuItem_Click);
            // 
            // posToolStripMenuItem
            // 
            this.posToolStripMenuItem.Name = "posToolStripMenuItem";
            this.posToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.posToolStripMenuItem.Text = "Position";
            this.posToolStripMenuItem.Click += new System.EventHandler(this.posToolStripMenuItem_Click);
            // 
            // transactionTypeToolStripMenuItem
            // 
            this.transactionTypeToolStripMenuItem.Name = "transactionTypeToolStripMenuItem";
            this.transactionTypeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.transactionTypeToolStripMenuItem.Text = "Transaction Type";
            this.transactionTypeToolStripMenuItem.Click += new System.EventHandler(this.transactionTypeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeDetailToolStripMenuItem,
            this.transactionReportFormToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // employeeDetailToolStripMenuItem
            // 
            this.employeeDetailToolStripMenuItem.Name = "employeeDetailToolStripMenuItem";
            this.employeeDetailToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.employeeDetailToolStripMenuItem.Text = "Employee";
            this.employeeDetailToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailToolStripMenuItem_Click);
            // 
            // transactionReportFormToolStripMenuItem
            // 
            this.transactionReportFormToolStripMenuItem.Name = "transactionReportFormToolStripMenuItem";
            this.transactionReportFormToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.transactionReportFormToolStripMenuItem.Text = "Transaction Report Form";
            this.transactionReportFormToolStripMenuItem.Click += new System.EventHandler(this.transactionReportFormToolStripMenuItem_Click);
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importPositionToolStripMenuItem});
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.importDataToolStripMenuItem.Text = "Import Data";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // importPositionToolStripMenuItem
            // 
            this.importPositionToolStripMenuItem.Name = "importPositionToolStripMenuItem";
            this.importPositionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.importPositionToolStripMenuItem.Text = "Import Position";
            this.importPositionToolStripMenuItem.Click += new System.EventHandler(this.importPositionToolStripMenuItem_Click);
            // 
            // fieToolStripMenuItem
            // 
            this.fieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fieToolStripMenuItem.Name = "fieToolStripMenuItem";
            this.fieToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fieToolStripMenuItem.Text = "Main Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerEmployeeFamilyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionReportFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}