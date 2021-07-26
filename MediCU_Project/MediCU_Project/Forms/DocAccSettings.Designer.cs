namespace MediCU_Project.Forms
{
    partial class DocAccSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dcpw = new System.Windows.Forms.TextBox();
            this.dpw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(426, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 536);
            this.panel1.TabIndex = 235;
            // 
            // dob
            // 
            this.dob.CustomFormat = "yyyy-MM-dd";
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(612, 130);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(251, 22);
            this.dob.TabIndex = 234;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(738, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 33);
            this.button4.TabIndex = 233;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(547, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 231;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(588, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 29);
            this.label10.TabIndex = 230;
            this.label10.Text = "Change Details";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(612, 371);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(251, 22);
            this.mail.TabIndex = 229;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(462, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 228;
            this.label12.Text = "E-mail";
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(612, 321);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(251, 22);
            this.m.TabIndex = 227;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(612, 222);
            this.ad.Multiline = true;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(251, 65);
            this.ad.TabIndex = 226;
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(612, 184);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(251, 22);
            this.fn.TabIndex = 225;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(462, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 224;
            this.label7.Text = "Mobile";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(462, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 223;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(462, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 222;
            this.label9.Text = "Full Name";
            // 
            // nic
            // 
            this.nic.Location = new System.Drawing.Point(612, 89);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(251, 22);
            this.nic.TabIndex = 221;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(462, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 220;
            this.label4.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(462, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 219;
            this.label5.Text = "NIC";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(103, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 33);
            this.button1.TabIndex = 218;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(98, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 29);
            this.label13.TabIndex = 217;
            this.label13.Text = "Change Password";
            // 
            // dcpw
            // 
            this.dcpw.Location = new System.Drawing.Point(155, 133);
            this.dcpw.Name = "dcpw";
            this.dcpw.Size = new System.Drawing.Size(251, 22);
            this.dcpw.TabIndex = 216;
            this.dcpw.UseSystemPasswordChar = true;
            // 
            // dpw
            // 
            this.dpw.Location = new System.Drawing.Point(155, 90);
            this.dpw.Name = "dpw";
            this.dpw.Size = new System.Drawing.Size(251, 22);
            this.dpw.TabIndex = 215;
            this.dpw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 214;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 213;
            this.label2.Text = "New Password";
            // 
            // DocAccSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.m);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dcpw);
            this.Controls.Add(this.dpw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DocAccSettings";
            this.Text = "DocAccSettings";
            this.Load += new System.EventHandler(this.DocAccSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox dcpw;
        private System.Windows.Forms.TextBox dpw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}