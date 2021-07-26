namespace MediCU_Project.Forms
{
    partial class NewLabR
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
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lstatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ltest = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lpage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lpname = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lpid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(329, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 29);
            this.label10.TabIndex = 92;
            this.label10.Text = "New Lab Report";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(553, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 88;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstatus
            // 
            this.lstatus.BackColor = System.Drawing.SystemColors.Info;
            this.lstatus.Location = new System.Drawing.Point(358, 270);
            this.lstatus.Multiline = true;
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(291, 122);
            this.lstatus.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Select Test";
            // 
            // ltest
            // 
            this.ltest.BackColor = System.Drawing.SystemColors.Info;
            this.ltest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltest.FormattingEnabled = true;
            this.ltest.Items.AddRange(new object[] {
            "Creatinine(with e GFR)",
            "CRP",
            "Electrolytes",
            "ESR",
            "Fasting Blood Sugar",
            "Full Blood Count",
            "HBA1C",
            "Lipid Profile",
            "Microalbumin",
            "TSH",
            "Urea",
            "Urea & Electrolytes",
            "Urine FR",
            "Dengue Antigen",
            "PCR",
            "Rapid Antigen"});
            this.ltest.Location = new System.Drawing.Point(358, 217);
            this.ltest.Name = "ltest";
            this.ltest.Size = new System.Drawing.Size(291, 24);
            this.ltest.TabIndex = 87;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lpage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lpname);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lpid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 80);
            this.panel1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patient Age";
            // 
            // lpage
            // 
            this.lpage.BackColor = System.Drawing.Color.White;
            this.lpage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lpage.Location = new System.Drawing.Point(768, 46);
            this.lpage.Name = "lpage";
            this.lpage.Size = new System.Drawing.Size(100, 15);
            this.lpage.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patient Name";
            // 
            // lpname
            // 
            this.lpname.BackColor = System.Drawing.Color.White;
            this.lpname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lpname.Location = new System.Drawing.Point(458, 47);
            this.lpname.Name = "lpname";
            this.lpname.Size = new System.Drawing.Size(195, 15);
            this.lpname.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(768, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 1);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(458, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 1);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient ID";
            // 
            // lpid
            // 
            this.lpid.BackColor = System.Drawing.Color.White;
            this.lpid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lpid.Location = new System.Drawing.Point(22, 47);
            this.lpid.Name = "lpid";
            this.lpid.Size = new System.Drawing.Size(201, 15);
            this.lpid.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(22, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 1);
            this.panel2.TabIndex = 1;
            // 
            // NewLabR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 563);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ltest);
            this.Controls.Add(this.panel1);
            this.Name = "NewLabR";
            this.Text = "NewLabR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ltest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lpname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lpid;
        private System.Windows.Forms.Panel panel2;
    }
}