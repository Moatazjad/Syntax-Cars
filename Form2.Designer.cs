namespace Syntax_Cars
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Proceed = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.brandtxt = new System.Windows.Forms.TextBox();
            this.modelttxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSedan = new System.Windows.Forms.GroupBox();
            this.sedanbtn = new System.Windows.Forms.Button();
            this.dieselbtn = new System.Windows.Forms.CheckBox();
            this.Petrolbtn = new System.Windows.Forms.CheckBox();
            this.trunktxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxHybrid = new System.Windows.Forms.GroupBox();
            this.roofbtn = new System.Windows.Forms.CheckBox();
            this.hybridbtn = new System.Windows.Forms.Button();
            this.chargingtxt = new System.Windows.Forms.TextBox();
            this.batterytxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxSport = new System.Windows.Forms.GroupBox();
            this.sportbtn = new System.Windows.Forms.Button();
            this.topspeedtxt = new System.Windows.Forms.TextBox();
            this.enginetxt = new System.Windows.Forms.TextBox();
            this.accelerationtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxSedan.SuspendLayout();
            this.groupBoxHybrid.SuspendLayout();
            this.groupBoxSport.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.Proceed);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pricetxt);
            this.groupBox1.Controls.Add(this.brandtxt);
            this.groupBox1.Controls.Add(this.modelttxt);
            this.groupBox1.Controls.Add(this.idtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(142, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 304);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // Proceed
            // 
            this.Proceed.Location = new System.Drawing.Point(38, 258);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(994, 40);
            this.Proceed.TabIndex = 11;
            this.Proceed.Text = "Proceed";
            this.Proceed.UseVisualStyleBackColor = true;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sedan",
            "Hybrid",
            "Sport"});
            this.comboBox1.Location = new System.Drawing.Point(166, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 30);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(732, 193);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(248, 28);
            this.pricetxt.TabIndex = 9;
            // 
            // brandtxt
            // 
            this.brandtxt.Location = new System.Drawing.Point(732, 122);
            this.brandtxt.Name = "brandtxt";
            this.brandtxt.Size = new System.Drawing.Size(248, 28);
            this.brandtxt.TabIndex = 8;
            // 
            // modelttxt
            // 
            this.modelttxt.Location = new System.Drawing.Point(135, 196);
            this.modelttxt.Name = "modelttxt";
            this.modelttxt.Size = new System.Drawing.Size(319, 28);
            this.modelttxt.TabIndex = 7;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(120, 117);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(334, 28);
            this.idtxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // groupBoxSedan
            // 
            this.groupBoxSedan.BackColor = System.Drawing.Color.IndianRed;
            this.groupBoxSedan.Controls.Add(this.sedanbtn);
            this.groupBoxSedan.Controls.Add(this.dieselbtn);
            this.groupBoxSedan.Controls.Add(this.Petrolbtn);
            this.groupBoxSedan.Controls.Add(this.trunktxt);
            this.groupBoxSedan.Controls.Add(this.label11);
            this.groupBoxSedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSedan.Location = new System.Drawing.Point(142, 408);
            this.groupBoxSedan.Name = "groupBoxSedan";
            this.groupBoxSedan.Size = new System.Drawing.Size(328, 219);
            this.groupBoxSedan.TabIndex = 2;
            this.groupBoxSedan.TabStop = false;
            this.groupBoxSedan.Text = "Sedan";
            this.groupBoxSedan.Enter += new System.EventHandler(this.groupBoxSedan_Enter);
            // 
            // sedanbtn
            // 
            this.sedanbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sedanbtn.Location = new System.Drawing.Point(92, 184);
            this.sedanbtn.Name = "sedanbtn";
            this.sedanbtn.Size = new System.Drawing.Size(101, 27);
            this.sedanbtn.TabIndex = 13;
            this.sedanbtn.Text = "Add Sedan";
            this.sedanbtn.UseVisualStyleBackColor = true;
            this.sedanbtn.Click += new System.EventHandler(this.sedanbtn_Click);
            // 
            // dieselbtn
            // 
            this.dieselbtn.AutoSize = true;
            this.dieselbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieselbtn.Location = new System.Drawing.Point(202, 144);
            this.dieselbtn.Name = "dieselbtn";
            this.dieselbtn.Size = new System.Drawing.Size(85, 24);
            this.dieselbtn.TabIndex = 12;
            this.dieselbtn.Text = "Diesel";
            this.dieselbtn.UseVisualStyleBackColor = true;
            // 
            // Petrolbtn
            // 
            this.Petrolbtn.AutoSize = true;
            this.Petrolbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Petrolbtn.Location = new System.Drawing.Point(6, 144);
            this.Petrolbtn.Name = "Petrolbtn";
            this.Petrolbtn.Size = new System.Drawing.Size(82, 24);
            this.Petrolbtn.TabIndex = 11;
            this.Petrolbtn.Text = "Petrol";
            this.Petrolbtn.UseVisualStyleBackColor = true;
            this.Petrolbtn.CheckedChanged += new System.EventHandler(this.Petrolbtn_CheckedChanged);
            // 
            // trunktxt
            // 
            this.trunktxt.Location = new System.Drawing.Point(11, 85);
            this.trunktxt.Name = "trunktxt";
            this.trunktxt.Size = new System.Drawing.Size(414, 28);
            this.trunktxt.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Trunk Capacity ";
            // 
            // groupBoxHybrid
            // 
            this.groupBoxHybrid.BackColor = System.Drawing.Color.IndianRed;
            this.groupBoxHybrid.Controls.Add(this.roofbtn);
            this.groupBoxHybrid.Controls.Add(this.hybridbtn);
            this.groupBoxHybrid.Controls.Add(this.chargingtxt);
            this.groupBoxHybrid.Controls.Add(this.batterytxt);
            this.groupBoxHybrid.Controls.Add(this.label10);
            this.groupBoxHybrid.Controls.Add(this.label9);
            this.groupBoxHybrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHybrid.Location = new System.Drawing.Point(510, 408);
            this.groupBoxHybrid.Name = "groupBoxHybrid";
            this.groupBoxHybrid.Size = new System.Drawing.Size(336, 219);
            this.groupBoxHybrid.TabIndex = 4;
            this.groupBoxHybrid.TabStop = false;
            this.groupBoxHybrid.Text = "Hybrid";
            // 
            // roofbtn
            // 
            this.roofbtn.AutoSize = true;
            this.roofbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roofbtn.Location = new System.Drawing.Point(110, 144);
            this.roofbtn.Name = "roofbtn";
            this.roofbtn.Size = new System.Drawing.Size(141, 24);
            this.roofbtn.TabIndex = 15;
            this.roofbtn.Text = "Roof Window";
            this.roofbtn.UseVisualStyleBackColor = true;
            // 
            // hybridbtn
            // 
            this.hybridbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hybridbtn.Location = new System.Drawing.Point(129, 184);
            this.hybridbtn.Name = "hybridbtn";
            this.hybridbtn.Size = new System.Drawing.Size(101, 27);
            this.hybridbtn.TabIndex = 14;
            this.hybridbtn.Text = "Add Hybrid";
            this.hybridbtn.UseVisualStyleBackColor = true;
            this.hybridbtn.Click += new System.EventHandler(this.hybridbtn_Click_1);
            // 
            // chargingtxt
            // 
            this.chargingtxt.Location = new System.Drawing.Point(171, 78);
            this.chargingtxt.Name = "chargingtxt";
            this.chargingtxt.Size = new System.Drawing.Size(225, 28);
            this.chargingtxt.TabIndex = 11;
            // 
            // batterytxt
            // 
            this.batterytxt.Location = new System.Drawing.Point(171, 35);
            this.batterytxt.Name = "batterytxt";
            this.batterytxt.Size = new System.Drawing.Size(225, 28);
            this.batterytxt.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Charging Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Battery Range:";
            // 
            // groupBoxSport
            // 
            this.groupBoxSport.BackColor = System.Drawing.Color.IndianRed;
            this.groupBoxSport.Controls.Add(this.sportbtn);
            this.groupBoxSport.Controls.Add(this.topspeedtxt);
            this.groupBoxSport.Controls.Add(this.enginetxt);
            this.groupBoxSport.Controls.Add(this.accelerationtxt);
            this.groupBoxSport.Controls.Add(this.label6);
            this.groupBoxSport.Controls.Add(this.label8);
            this.groupBoxSport.Controls.Add(this.label7);
            this.groupBoxSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSport.Location = new System.Drawing.Point(884, 408);
            this.groupBoxSport.Name = "groupBoxSport";
            this.groupBoxSport.Size = new System.Drawing.Size(310, 219);
            this.groupBoxSport.TabIndex = 5;
            this.groupBoxSport.TabStop = false;
            this.groupBoxSport.Text = "Sport";
            // 
            // sportbtn
            // 
            this.sportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportbtn.Location = new System.Drawing.Point(103, 184);
            this.sportbtn.Name = "sportbtn";
            this.sportbtn.Size = new System.Drawing.Size(101, 27);
            this.sportbtn.TabIndex = 14;
            this.sportbtn.Text = "Add Sport";
            this.sportbtn.UseVisualStyleBackColor = true;
            this.sportbtn.Click += new System.EventHandler(this.sportbtn_Click_1);
            // 
            // topspeedtxt
            // 
            this.topspeedtxt.Location = new System.Drawing.Point(209, 86);
            this.topspeedtxt.Name = "topspeedtxt";
            this.topspeedtxt.Size = new System.Drawing.Size(135, 28);
            this.topspeedtxt.TabIndex = 11;
            // 
            // enginetxt
            // 
            this.enginetxt.Location = new System.Drawing.Point(173, 135);
            this.enginetxt.Name = "enginetxt";
            this.enginetxt.Size = new System.Drawing.Size(189, 28);
            this.enginetxt.TabIndex = 11;
            // 
            // accelerationtxt
            // 
            this.accelerationtxt.Location = new System.Drawing.Point(173, 36);
            this.accelerationtxt.Name = "accelerationtxt";
            this.accelerationtxt.Size = new System.Drawing.Size(189, 28);
            this.accelerationtxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "0-60 mph  (sec):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Engine Specs:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Top Speed (mph):";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Cornsilk;
            this.Menu.Location = new System.Drawing.Point(142, 675);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1052, 52);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "Back TO Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 786);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.groupBoxSport);
            this.Controls.Add(this.groupBoxHybrid);
            this.Controls.Add(this.groupBoxSedan);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSedan.ResumeLayout(false);
            this.groupBoxSedan.PerformLayout();
            this.groupBoxHybrid.ResumeLayout(false);
            this.groupBoxHybrid.PerformLayout();
            this.groupBoxSport.ResumeLayout(false);
            this.groupBoxSport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox brandtxt;
        private System.Windows.Forms.TextBox modelttxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSedan;
        private System.Windows.Forms.Button sedanbtn;
        private System.Windows.Forms.CheckBox dieselbtn;
        private System.Windows.Forms.CheckBox Petrolbtn;
        private System.Windows.Forms.TextBox trunktxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxHybrid;
        private System.Windows.Forms.CheckBox roofbtn;
        private System.Windows.Forms.Button hybridbtn;
        private System.Windows.Forms.TextBox chargingtxt;
        private System.Windows.Forms.TextBox batterytxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxSport;
        private System.Windows.Forms.Button sportbtn;
        private System.Windows.Forms.TextBox topspeedtxt;
        private System.Windows.Forms.TextBox enginetxt;
        private System.Windows.Forms.TextBox accelerationtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Menu;
    }
}