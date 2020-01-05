namespace FinalProjectDB
{
    partial class mainMenu
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
            this.bankControlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bankControlButton
            // 
            this.bankControlButton.Location = new System.Drawing.Point(54, 82);
            this.bankControlButton.Name = "bankControlButton";
            this.bankControlButton.Size = new System.Drawing.Size(208, 34);
            this.bankControlButton.TabIndex = 0;
            this.bankControlButton.Text = "Bank Control";
            this.bankControlButton.UseVisualStyleBackColor = true;
            this.bankControlButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.bankControlButton);
            this.Name = "mainMenu";
            this.Text = "HR Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bankControlButton;
    }
}

