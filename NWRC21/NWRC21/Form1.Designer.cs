namespace NWRC21
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worksheetRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.worksheetRegistrationToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.aBOUTToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.loadFileToolStripMenuItem.Text = "LOAD FILE";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // worksheetRegistrationToolStripMenuItem
            // 
            this.worksheetRegistrationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worksheetRegistrationToolStripMenuItem.Name = "worksheetRegistrationToolStripMenuItem";
            this.worksheetRegistrationToolStripMenuItem.Size = new System.Drawing.Size(233, 29);
            this.worksheetRegistrationToolStripMenuItem.Text = "WORKSHEET REGISTRATION";
            this.worksheetRegistrationToolStripMenuItem.Click += new System.EventHandler(this.worksheetRegistrationToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.paymentToolStripMenuItem.Text = "PAYMENT";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aBOUTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.ABOUTToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worksheetRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

