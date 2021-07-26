namespace MediCU_Project.Forms
{
    partial class DoctorRegistration
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
            this.ddob = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dsp = new System.Windows.Forms.TextBox();
            this.dex = new System.Windows.Forms.TextBox();
            this.drstate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dcpw = new System.Windows.Forms.TextBox();
            this.dpw = new System.Windows.Forms.TextBox();
            this.dmail = new System.Windows.Forms.TextBox();
            this.dmobile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dadd = new System.Windows.Forms.TextBox();
            this.dfn = new System.Windows.Forms.TextBox();
            this.dnic = new System.Windows.Forms.TextBox();
            this.RegNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dadates = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddob
            // 
            this.ddob.CustomFormat = "yyyy-MM-dd";
            this.ddob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ddob.Location = new System.Drawing.Point(170, 222);
            this.ddob.Name = "ddob";
            this.ddob.Size = new System.Drawing.Size(251, 22);
            this.ddob.TabIndex = 149;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(410, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 29);
            this.label13.TabIndex = 148;
            this.label13.Text = "New Doctor";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(785, 451);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 34);
            this.button7.TabIndex = 147;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(587, 451);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 33);
            this.button8.TabIndex = 146;
            this.button8.Text = "Register";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dsp
            // 
            this.dsp.Location = new System.Drawing.Point(651, 224);
            this.dsp.Name = "dsp";
            this.dsp.Size = new System.Drawing.Size(251, 22);
            this.dsp.TabIndex = 145;
            // 
            // dex
            // 
            this.dex.Location = new System.Drawing.Point(651, 160);
            this.dex.Name = "dex";
            this.dex.Size = new System.Drawing.Size(251, 22);
            this.dex.TabIndex = 144;
            // 
            // drstate
            // 
            this.drstate.Location = new System.Drawing.Point(651, 89);
            this.drstate.Name = "drstate";
            this.drstate.Size = new System.Drawing.Size(251, 22);
            this.drstate.TabIndex = 143;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(501, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 51);
            this.label12.TabIndex = 142;
            this.label12.Text = "Specialization\r\n(Seperate by comma, \r\nif more than one)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(501, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 141;
            this.label11.Text = "Experience";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(501, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 140;
            this.label10.Text = "Registration State";
            // 
            // dcpw
            // 
            this.dcpw.Location = new System.Drawing.Point(170, 511);
            this.dcpw.Name = "dcpw";
            this.dcpw.Size = new System.Drawing.Size(251, 22);
            this.dcpw.TabIndex = 139;
            this.dcpw.UseSystemPasswordChar = true;
            // 
            // dpw
            // 
            this.dpw.Location = new System.Drawing.Point(170, 463);
            this.dpw.Name = "dpw";
            this.dpw.Size = new System.Drawing.Size(251, 22);
            this.dpw.TabIndex = 138;
            this.dpw.UseSystemPasswordChar = true;
            // 
            // dmail
            // 
            this.dmail.Location = new System.Drawing.Point(170, 419);
            this.dmail.Name = "dmail";
            this.dmail.Size = new System.Drawing.Size(251, 22);
            this.dmail.TabIndex = 137;
            // 
            // dmobile
            // 
            this.dmobile.Location = new System.Drawing.Point(170, 367);
            this.dmobile.Name = "dmobile";
            this.dmobile.Size = new System.Drawing.Size(251, 22);
            this.dmobile.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 135;
            this.label9.Text = "Confirmed Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 134;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 133;
            this.label7.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 132;
            this.label6.Text = "Mobile";
            // 
            // dadd
            // 
            this.dadd.Location = new System.Drawing.Point(170, 266);
            this.dadd.Multiline = true;
            this.dadd.Name = "dadd";
            this.dadd.Size = new System.Drawing.Size(251, 75);
            this.dadd.TabIndex = 131;
            // 
            // dfn
            // 
            this.dfn.Location = new System.Drawing.Point(170, 175);
            this.dfn.Name = "dfn";
            this.dfn.Size = new System.Drawing.Size(251, 22);
            this.dfn.TabIndex = 130;
            // 
            // dnic
            // 
            this.dnic.Location = new System.Drawing.Point(170, 132);
            this.dnic.Name = "dnic";
            this.dnic.Size = new System.Drawing.Size(251, 22);
            this.dnic.TabIndex = 129;
            // 
            // RegNo
            // 
            this.RegNo.Location = new System.Drawing.Point(170, 90);
            this.RegNo.Name = "RegNo";
            this.RegNo.Size = new System.Drawing.Size(251, 22);
            this.RegNo.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 127;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 126;
            this.label4.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 125;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 124;
            this.label2.Text = "NIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 123;
            this.label1.Text = "Doctor Id";
            // 
            // dadates
            // 
            this.dadates.Location = new System.Drawing.Point(651, 371);
            this.dadates.Name = "dadates";
            this.dadates.Size = new System.Drawing.Size(251, 22);
            this.dadates.TabIndex = 150;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(502, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 152;
            this.label14.Text = "Available Dates";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(502, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 17);
            this.label15.TabIndex = 153;
            this.label15.Text = "Arrival Time";
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "hh:mm:tt";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1.Location = new System.Drawing.Point(634, 305);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShowUpDown = true;
            this.dtp1.Size = new System.Drawing.Size(119, 22);
            this.dtp1.TabIndex = 154;
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "hh:mm:tt";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp2.Location = new System.Drawing.Point(794, 305);
            this.dtp2.Name = "dtp2";
            this.dtp2.ShowUpDown = true;
            this.dtp2.Size = new System.Drawing.Size(119, 22);
            this.dtp2.TabIndex = 155;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(761, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 17);
            this.label16.TabIndex = 156;
            this.label16.Text = "To";
            // 
            // DoctorRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 599);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dadates);
            this.Controls.Add(this.ddob);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dsp);
            this.Controls.Add(this.dex);
            this.Controls.Add(this.drstate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dcpw);
            this.Controls.Add(this.dpw);
            this.Controls.Add(this.dmail);
            this.Controls.Add(this.dmobile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dadd);
            this.Controls.Add(this.dfn);
            this.Controls.Add(this.dnic);
            this.Controls.Add(this.RegNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoctorRegistration";
            this.Text = "DoctorRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ddob;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox dsp;
        private System.Windows.Forms.TextBox dex;
        private System.Windows.Forms.TextBox drstate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dcpw;
        private System.Windows.Forms.TextBox dpw;
        private System.Windows.Forms.TextBox dmail;
        private System.Windows.Forms.TextBox dmobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dadd;
        private System.Windows.Forms.TextBox dfn;
        private System.Windows.Forms.TextBox dnic;
        private System.Windows.Forms.TextBox RegNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dadates;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label16;
    }
}