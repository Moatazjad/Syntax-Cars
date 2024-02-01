namespace Syntax_Cars
{
    partial class Form3
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.modellbl = new System.Windows.Forms.Label();
            this.brandlbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.enginelbl = new System.Windows.Forms.Label();
            this.toplbl = new System.Windows.Forms.Label();
            this.mphlbl = new System.Windows.Forms.Label();
            this.charginglbl = new System.Windows.Forms.Label();
            this.batterylbl = new System.Windows.Forms.Label();
            this.trunklbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ALL ",
            "SEDAN",
            "Hybrid",
            "SPORTS"});
            this.comboBox2.Location = new System.Drawing.Point(135, 125);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(283, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(135, 184);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 244);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 468);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 529);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 579);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 645);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price:";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(173, 475);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(19, 20);
            this.idlbl.TabIndex = 19;
            this.idlbl.Text = "--";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(173, 654);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(19, 20);
            this.pricelbl.TabIndex = 22;
            this.pricelbl.Text = "--";
            // 
            // modellbl
            // 
            this.modellbl.AutoSize = true;
            this.modellbl.Location = new System.Drawing.Point(173, 588);
            this.modellbl.Name = "modellbl";
            this.modellbl.Size = new System.Drawing.Size(19, 20);
            this.modellbl.TabIndex = 23;
            this.modellbl.Text = "--";
            // 
            // brandlbl
            // 
            this.brandlbl.AutoSize = true;
            this.brandlbl.Location = new System.Drawing.Point(173, 536);
            this.brandlbl.Name = "brandlbl";
            this.brandlbl.Size = new System.Drawing.Size(19, 20);
            this.brandlbl.TabIndex = 24;
            this.brandlbl.Text = "--";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(462, 373);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 55);
            this.button2.TabIndex = 25;
            this.button2.Text = "MAIN MENU";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 466);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "TrunkCapacity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 579);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Charging Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 736);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Engine Spece:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 632);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "0 - 60 (MPH):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(350, 527);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Battery Range:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(350, 686);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "Top Speed:";
            // 
            // enginelbl
            // 
            this.enginelbl.AutoSize = true;
            this.enginelbl.Location = new System.Drawing.Point(611, 743);
            this.enginelbl.Name = "enginelbl";
            this.enginelbl.Size = new System.Drawing.Size(19, 20);
            this.enginelbl.TabIndex = 32;
            this.enginelbl.Text = "--";
            // 
            // toplbl
            // 
            this.toplbl.AutoSize = true;
            this.toplbl.Location = new System.Drawing.Point(611, 695);
            this.toplbl.Name = "toplbl";
            this.toplbl.Size = new System.Drawing.Size(19, 20);
            this.toplbl.TabIndex = 33;
            this.toplbl.Text = "--";
            // 
            // mphlbl
            // 
            this.mphlbl.AutoSize = true;
            this.mphlbl.Location = new System.Drawing.Point(611, 639);
            this.mphlbl.Name = "mphlbl";
            this.mphlbl.Size = new System.Drawing.Size(19, 20);
            this.mphlbl.TabIndex = 34;
            this.mphlbl.Text = "--";
            // 
            // charginglbl
            // 
            this.charginglbl.AutoSize = true;
            this.charginglbl.Location = new System.Drawing.Point(611, 586);
            this.charginglbl.Name = "charginglbl";
            this.charginglbl.Size = new System.Drawing.Size(19, 20);
            this.charginglbl.TabIndex = 35;
            this.charginglbl.Text = "--";
            // 
            // batterylbl
            // 
            this.batterylbl.AutoSize = true;
            this.batterylbl.Location = new System.Drawing.Point(611, 536);
            this.batterylbl.Name = "batterylbl";
            this.batterylbl.Size = new System.Drawing.Size(19, 20);
            this.batterylbl.TabIndex = 36;
            this.batterylbl.Text = "--";
            // 
            // trunklbl
            // 
            this.trunklbl.AutoSize = true;
            this.trunklbl.Location = new System.Drawing.Point(611, 475);
            this.trunklbl.Name = "trunklbl";
            this.trunklbl.Size = new System.Drawing.Size(19, 20);
            this.trunklbl.TabIndex = 37;
            this.trunklbl.Text = "--";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 771);
            this.Controls.Add(this.trunklbl);
            this.Controls.Add(this.batterylbl);
            this.Controls.Add(this.charginglbl);
            this.Controls.Add(this.mphlbl);
            this.Controls.Add(this.toplbl);
            this.Controls.Add(this.enginelbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.brandlbl);
            this.Controls.Add(this.modellbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label modellbl;
        private System.Windows.Forms.Label brandlbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label enginelbl;
        private System.Windows.Forms.Label toplbl;
        private System.Windows.Forms.Label mphlbl;
        private System.Windows.Forms.Label charginglbl;
        private System.Windows.Forms.Label batterylbl;
        private System.Windows.Forms.Label trunklbl;
    }
}