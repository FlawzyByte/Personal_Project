using System.Windows.Forms;

namespace NWRC21
{
    partial class Worksheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Worksheet));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Register = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.Label();
            this.timeCostlbl = new System.Windows.Forms.Label();
            this.matCostLbl = new System.Windows.Forms.Label();
            this.Text6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel.Location = new System.Drawing.Point(-1, 51);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(636, 327);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Maroon;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.Yellow;
            this.Register.Location = new System.Drawing.Point(641, 39);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(160, 72);
            this.Register.TabIndex = 1;
            this.Register.Text = "REGISTER";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.Location = new System.Drawing.Point(15, 18);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(206, 23);
            this.Text2.TabIndex = 2;
            this.Text2.Text = "Material Costs";
            this.Text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Text2.Click += new System.EventHandler(this.Text2_Click);
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(317, 18);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(234, 23);
            this.Text1.TabIndex = 3;
            this.Text1.Text = "Total Time Costs";
            // 
            // Text5
            // 
            this.Text5.AutoSize = true;
            this.Text5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text5.Location = new System.Drawing.Point(163, 27);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(124, 20);
            this.Text5.TabIndex = 5;
            this.Text5.Text = "Material Costs";
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text4.Location = new System.Drawing.Point(349, 28);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(47, 20);
            this.Text4.TabIndex = 6;
            this.Text4.Text = "Time";
            this.Text4.Click += new System.EventHandler(this.Text4_Click);
            // 
            // timeCostlbl
            // 
            this.timeCostlbl.AutoSize = true;
            this.timeCostlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCostlbl.ForeColor = System.Drawing.Color.Red;
            this.timeCostlbl.Location = new System.Drawing.Point(557, 21);
            this.timeCostlbl.Name = "timeCostlbl";
            this.timeCostlbl.Size = new System.Drawing.Size(19, 20);
            this.timeCostlbl.TabIndex = 7;
            this.timeCostlbl.Text = "0";
            // 
            // matCostLbl
            // 
            this.matCostLbl.AutoSize = true;
            this.matCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matCostLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.matCostLbl.Location = new System.Drawing.Point(227, 21);
            this.matCostLbl.Name = "matCostLbl";
            this.matCostLbl.Size = new System.Drawing.Size(19, 20);
            this.matCostLbl.TabIndex = 8;
            this.matCostLbl.Text = "0";
            // 
            // Text6
            // 
            this.Text6.AutoSize = true;
            this.Text6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text6.Location = new System.Drawing.Point(3, 28);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(125, 18);
            this.Text6.TabIndex = 9;
            this.Text6.Text = "Type of Service";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Text2);
            this.panel1.Controls.Add(this.timeCostlbl);
            this.panel1.Controls.Add(this.matCostLbl);
            this.panel1.Controls.Add(this.Text1);
            this.panel1.Location = new System.Drawing.Point(6, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 54);
            this.panel1.TabIndex = 10;
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.Maroon;
            this.Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.ForeColor = System.Drawing.Color.Yellow;
            this.Pay.Location = new System.Drawing.Point(641, 130);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(160, 72);
            this.Pay.TabIndex = 11;
            this.Pay.Text = "PAY";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // Worksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "Worksheet";
            this.Text = "Worksheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Worksheet_FormClosing);
            this.Load += new System.EventHandler(this.Worksheet_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text5;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.Label timeCostlbl;
        private System.Windows.Forms.Label matCostLbl;
        private System.Windows.Forms.Label Text6;
        public Panel panel1;
        private Button Pay;
    }
}