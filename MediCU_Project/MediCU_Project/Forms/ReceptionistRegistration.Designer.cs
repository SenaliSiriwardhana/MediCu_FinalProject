namespace MediCU_Project.Forms
{
    partial class ReceptionistRegistration
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
            this.rdob = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.rqua = new System.Windows.Forms.TextBox();
            this.rex = new System.Windows.Forms.TextBox();
            this.rstate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rcpw = new System.Windows.Forms.TextBox();
            this.rpw = new System.Windows.Forms.TextBox();
            this.rmail = new System.Windows.Forms.TextBox();
            this.rmobile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rad = new System.Windows.Forms.TextBox();
            this.rfname = new System.Windows.Forms.TextBox();
            this.rnic = new System.Windows.Forms.TextBox();
            this.Rrecid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdob
            // 
            this.rdob.CustomFormat = "yyyy-MM-dd";
            this.rdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rdob.Location = new System.Drawing.Point(165, 222);
            this.rdob.Name = "rdob";
            this.rdob.Size = new System.Drawing.Size(251, 22);
            this.rdob.TabIndex = 183;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(361, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 29);
            this.label13.TabIndex = 182;
            this.label13.Text = "New Receptionist";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(799, 333);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 34);
            this.button7.TabIndex = 181;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(586, 334);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 33);
            this.button8.TabIndex = 180;
            this.button8.Text = "Register";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // rqua
            // 
            this.rqua.Location = new System.Drawing.Point(646, 224);
            this.rqua.Name = "rqua";
            this.rqua.Size = new System.Drawing.Size(251, 22);
            this.rqua.TabIndex = 179;
            // 
            // rex
            // 
            this.rex.Location = new System.Drawing.Point(646, 160);
            this.rex.Name = "rex";
            this.rex.Size = new System.Drawing.Size(251, 22);
            this.rex.TabIndex = 178;
            // 
            // rstate
            // 
            this.rstate.Location = new System.Drawing.Point(646, 89);
            this.rstate.Name = "rstate";
            this.rstate.Size = new System.Drawing.Size(251, 22);
            this.rstate.TabIndex = 177;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(496, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 175;
            this.label11.Text = "Experience";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(496, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 174;
            this.label10.Text = "Registration State";
            // 
            // rcpw
            // 
            this.rcpw.Location = new System.Drawing.Point(165, 527);
            this.rcpw.Name = "rcpw";
            this.rcpw.Size = new System.Drawing.Size(251, 22);
            this.rcpw.TabIndex = 173;
            this.rcpw.UseSystemPasswordChar = true;
            // 
            // rpw
            // 
            this.rpw.Location = new System.Drawing.Point(165, 479);
            this.rpw.Name = "rpw";
            this.rpw.Size = new System.Drawing.Size(251, 22);
            this.rpw.TabIndex = 172;
            this.rpw.UseSystemPasswordChar = true;
            // 
            // rmail
            // 
            this.rmail.Location = new System.Drawing.Point(165, 435);
            this.rmail.Name = "rmail";
            this.rmail.Size = new System.Drawing.Size(251, 22);
            this.rmail.TabIndex = 171;
            // 
            // rmobile
            // 
            this.rmobile.Location = new System.Drawing.Point(165, 383);
            this.rmobile.Name = "rmobile";
            this.rmobile.Size = new System.Drawing.Size(251, 22);
            this.rmobile.TabIndex = 170;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 169;
            this.label9.Text = "Confirmed Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 168;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 167;
            this.label7.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 166;
            this.label6.Text = "Mobile";
            // 
            // rad
            // 
            this.rad.Location = new System.Drawing.Point(165, 266);
            this.rad.Multiline = true;
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(251, 88);
            this.rad.TabIndex = 165;
            // 
            // rfname
            // 
            this.rfname.Location = new System.Drawing.Point(165, 175);
            this.rfname.Name = "rfname";
            this.rfname.Size = new System.Drawing.Size(251, 22);
            this.rfname.TabIndex = 164;
            // 
            // rnic
            // 
            this.rnic.Location = new System.Drawing.Point(165, 132);
            this.rnic.Name = "rnic";
            this.rnic.Size = new System.Drawing.Size(251, 22);
            this.rnic.TabIndex = 163;
            // 
            // Rrecid
            // 
            this.Rrecid.Location = new System.Drawing.Point(165, 90);
            this.Rrecid.Name = "Rrecid";
            this.Rrecid.Size = new System.Drawing.Size(251, 22);
            this.Rrecid.TabIndex = 162;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 161;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 160;
            this.label4.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 159;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 158;
            this.label2.Text = "NIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 157;
            this.label1.Text = "Receptionist Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(496, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 184;
            this.label12.Text = "Other Qualifications";
            // 
            // ReceptionistRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 599);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rdob);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.rqua);
            this.Controls.Add(this.rex);
            this.Controls.Add(this.rstate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rcpw);
            this.Controls.Add(this.rpw);
            this.Controls.Add(this.rmail);
            this.Controls.Add(this.rmobile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rad);
            this.Controls.Add(this.rfname);
            this.Controls.Add(this.rnic);
            this.Controls.Add(this.Rrecid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReceptionistRegistration";
            this.Text = "ReceptionistRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker rdob;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox rqua;
        private System.Windows.Forms.TextBox rex;
        private System.Windows.Forms.TextBox rstate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rcpw;
        private System.Windows.Forms.TextBox rpw;
        private System.Windows.Forms.TextBox rmail;
        private System.Windows.Forms.TextBox rmobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rad;
        private System.Windows.Forms.TextBox rfname;
        private System.Windows.Forms.TextBox rnic;
        private System.Windows.Forms.TextBox Rrecid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
    }
}