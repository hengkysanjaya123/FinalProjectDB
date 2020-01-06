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
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.bankControlButton);
            this.container.ForeColor = System.Drawing.Color.Black;
            this.container.Size = new System.Drawing.Size(714, 440);
            // 
            // bankControlButton
            // 
            this.bankControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bankControlButton.FlatAppearance.BorderSize = 0;
            this.bankControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bankControlButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bankControlButton.Location = new System.Drawing.Point(57, 28);
            this.bankControlButton.Margin = new System.Windows.Forms.Padding(2);
            this.bankControlButton.Name = "bankControlButton";
            this.bankControlButton.Size = new System.Drawing.Size(139, 22);
            this.bankControlButton.TabIndex = 1;
            this.bankControlButton.Text = "Bank Control";
            this.bankControlButton.UseVisualStyleBackColor = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 440);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainMenu";
            this.Text = "HR Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bankControlButton;
    }
}

