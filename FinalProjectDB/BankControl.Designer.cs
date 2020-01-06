namespace FinalProjectDB
{
    partial class BankControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addBankTab = new System.Windows.Forms.TabPage();
            this.addBankButton = new System.Windows.Forms.Button();
            this.newBankText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBankTab = new System.Windows.Forms.TabPage();
            this.updateBankTab = new System.Windows.Forms.TabPage();
            this.removeBankTab = new System.Windows.Forms.TabPage();
            this.banksList = new System.Windows.Forms.DataGridView();
            this.BankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.addBankTab.SuspendLayout();
            this.viewBankTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banksList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addBankTab);
            this.tabControl1.Controls.Add(this.viewBankTab);
            this.tabControl1.Controls.Add(this.updateBankTab);
            this.tabControl1.Controls.Add(this.removeBankTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 452);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // addBankTab
            // 
            this.addBankTab.Controls.Add(this.addBankButton);
            this.addBankTab.Controls.Add(this.newBankText);
            this.addBankTab.Controls.Add(this.label1);
            this.addBankTab.Location = new System.Drawing.Point(4, 29);
            this.addBankTab.Name = "addBankTab";
            this.addBankTab.Padding = new System.Windows.Forms.Padding(3);
            this.addBankTab.Size = new System.Drawing.Size(793, 419);
            this.addBankTab.TabIndex = 0;
            this.addBankTab.Text = "Add Bank";
            this.addBankTab.UseVisualStyleBackColor = true;
            // 
            // addBankButton
            // 
            this.addBankButton.Location = new System.Drawing.Point(313, 215);
            this.addBankButton.Name = "addBankButton";
            this.addBankButton.Size = new System.Drawing.Size(143, 31);
            this.addBankButton.TabIndex = 2;
            this.addBankButton.Text = "Add Bank";
            this.addBankButton.UseVisualStyleBackColor = true;
            this.addBankButton.Click += new System.EventHandler(this.addNewBank_Click);
            // 
            // newBankText
            // 
            this.newBankText.Location = new System.Drawing.Point(208, 135);
            this.newBankText.Name = "newBankText";
            this.newBankText.Size = new System.Drawing.Size(349, 26);
            this.newBankText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Bank Name Below";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // viewBankTab
            // 
            this.viewBankTab.Controls.Add(this.banksList);
            this.viewBankTab.Location = new System.Drawing.Point(4, 29);
            this.viewBankTab.Name = "viewBankTab";
            this.viewBankTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewBankTab.Size = new System.Drawing.Size(793, 419);
            this.viewBankTab.TabIndex = 1;
            this.viewBankTab.Text = "View Banks";
            this.viewBankTab.UseVisualStyleBackColor = true;
            // 
            // updateBankTab
            // 
            this.updateBankTab.Location = new System.Drawing.Point(4, 29);
            this.updateBankTab.Name = "updateBankTab";
            this.updateBankTab.Size = new System.Drawing.Size(793, 419);
            this.updateBankTab.TabIndex = 2;
            this.updateBankTab.Text = "Update Bank";
            this.updateBankTab.UseVisualStyleBackColor = true;
            // 
            // removeBankTab
            // 
            this.removeBankTab.Location = new System.Drawing.Point(4, 29);
            this.removeBankTab.Name = "removeBankTab";
            this.removeBankTab.Size = new System.Drawing.Size(793, 419);
            this.removeBankTab.TabIndex = 3;
            this.removeBankTab.Text = "Remove Bank";
            this.removeBankTab.UseVisualStyleBackColor = true;
            // 
            // banksList
            // 
            this.banksList.AllowUserToAddRows = false;
            this.banksList.AllowUserToDeleteRows = false;
            this.banksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankID,
            this.BankName});
            this.banksList.Location = new System.Drawing.Point(66, 6);
            this.banksList.Name = "banksList";
            this.banksList.RowHeadersWidth = 80;
            this.banksList.RowTemplate.Height = 28;
            this.banksList.Size = new System.Drawing.Size(557, 387);
            this.banksList.TabIndex = 0;
            this.banksList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BanksList_CellContentClick);
            // 
            // BankID
            // 
            this.BankID.HeaderText = "Bank ID";
            this.BankID.Name = "BankID";
            this.BankID.ReadOnly = true;
            // 
            // BankName
            // 
            this.BankName.HeaderText = "Bank Name";
            this.BankName.Name = "BankName";
            this.BankName.ReadOnly = true;
            // 
            // BankControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "BankControl";
            this.Text = "Bank Control";
            this.Load += new System.EventHandler(this.BankControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.addBankTab.ResumeLayout(false);
            this.addBankTab.PerformLayout();
            this.viewBankTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.banksList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addBankTab;
        private System.Windows.Forms.TabPage viewBankTab;
        private System.Windows.Forms.TabPage updateBankTab;
        private System.Windows.Forms.TabPage removeBankTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBankButton;
        private System.Windows.Forms.TextBox newBankText;
        private System.Windows.Forms.DataGridView banksList;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
    }
}