namespace NWRC21
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.lbl04 = new System.Windows.Forms.Label();
            this.chkBx01 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(3, 16);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(110, 18);
            this.lbl01.TabIndex = 0;
            this.lbl01.Text = "Service name";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.Location = new System.Drawing.Point(163, 18);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(85, 15);
            this.lbl02.TabIndex = 1;
            this.lbl02.Text = "Material Costs";
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl03.Location = new System.Drawing.Point(322, 16);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(41, 18);
            this.lbl03.TabIndex = 2;
            this.lbl03.Text = "Time";
            // 
            // lbl04
            // 
            this.lbl04.AutoSize = true;
            this.lbl04.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl04.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl04.Location = new System.Drawing.Point(503, 16);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(0, 18);
            this.lbl04.TabIndex = 3;
            // 
            // chkBx01
            // 
            this.chkBx01.AutoSize = true;
            this.chkBx01.Location = new System.Drawing.Point(434, 20);
            this.chkBx01.Name = "chkBx01";
            this.chkBx01.Size = new System.Drawing.Size(15, 14);
            this.chkBx01.TabIndex = 4;
            this.chkBx01.UseVisualStyleBackColor = false;
            this.chkBx01.CheckedChanged += new System.EventHandler(this.chkBx01_CheckedChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBx01);
            this.Controls.Add(this.lbl04);
            this.Controls.Add(this.lbl03);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl01);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(627, 52);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.Label lbl04;
        private System.Windows.Forms.CheckBox chkBx01;
    }
}
