namespace FinalProjectDB
{
    partial class core
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
            this.container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(695, 422);
            this.container.TabIndex = 0;
            this.container.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.container_ControlAdded);
            // 
            // core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 422);
            this.Controls.Add(this.container);
            this.Name = "core";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Core";
            this.Load += new System.EventHandler(this.Core_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Core_ControlAdded);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel container;
    }
}