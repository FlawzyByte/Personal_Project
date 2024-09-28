namespace NWRC21
{
    partial class Payement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payement));
            this.Num = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Numregwrklbl = new System.Windows.Forms.Label();
            this.MatCostlbl = new System.Windows.Forms.Label();
            this.SrvCostlbl = new System.Windows.Forms.Label();
            this.ServTimelbl = new System.Windows.Forms.Label();
            this.TotalPaylbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.Location = new System.Drawing.Point(4, 9);
            this.Num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(206, 16);
            this.Num.TabIndex = 1;
            this.Num.Text = "Number of regisetered works";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Material Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Invoiced service time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total to pay";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(37, 384);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Numregwrklbl
            // 
            this.Numregwrklbl.AutoSize = true;
            this.Numregwrklbl.Location = new System.Drawing.Point(251, 9);
            this.Numregwrklbl.Name = "Numregwrklbl";
            this.Numregwrklbl.Size = new System.Drawing.Size(14, 13);
            this.Numregwrklbl.TabIndex = 8;
            this.Numregwrklbl.Text = "0";
            // 
            // MatCostlbl
            // 
            this.MatCostlbl.AutoSize = true;
            this.MatCostlbl.Location = new System.Drawing.Point(169, 66);
            this.MatCostlbl.Name = "MatCostlbl";
            this.MatCostlbl.Size = new System.Drawing.Size(14, 13);
            this.MatCostlbl.TabIndex = 9;
            this.MatCostlbl.Text = "0";
            // 
            // SrvCostlbl
            // 
            this.SrvCostlbl.AutoSize = true;
            this.SrvCostlbl.Location = new System.Drawing.Point(169, 136);
            this.SrvCostlbl.Name = "SrvCostlbl";
            this.SrvCostlbl.Size = new System.Drawing.Size(14, 13);
            this.SrvCostlbl.TabIndex = 10;
            this.SrvCostlbl.Text = "0";
            // 
            // ServTimelbl
            // 
            this.ServTimelbl.AutoSize = true;
            this.ServTimelbl.Location = new System.Drawing.Point(227, 195);
            this.ServTimelbl.Name = "ServTimelbl";
            this.ServTimelbl.Size = new System.Drawing.Size(14, 13);
            this.ServTimelbl.TabIndex = 11;
            this.ServTimelbl.Text = "0";
            // 
            // TotalPaylbl
            // 
            this.TotalPaylbl.AutoSize = true;
            this.TotalPaylbl.Location = new System.Drawing.Point(139, 255);
            this.TotalPaylbl.Name = "TotalPaylbl";
            this.TotalPaylbl.Size = new System.Drawing.Size(14, 13);
            this.TotalPaylbl.TabIndex = 12;
            this.TotalPaylbl.Text = "0";
            // 
            // Payement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.TotalPaylbl);
            this.Controls.Add(this.ServTimelbl);
            this.Controls.Add(this.SrvCostlbl);
            this.Controls.Add(this.MatCostlbl);
            this.Controls.Add(this.Numregwrklbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Num);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Payement";
            this.Text = "Payement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Numregwrklbl;
        private System.Windows.Forms.Label MatCostlbl;
        private System.Windows.Forms.Label SrvCostlbl;
        private System.Windows.Forms.Label ServTimelbl;
        private System.Windows.Forms.Label TotalPaylbl;
    }
}