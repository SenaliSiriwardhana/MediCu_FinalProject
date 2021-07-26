namespace MediCU_Project.Forms
{
    partial class DoctorTabs
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
            this.Reg_Panel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Docpanel = new System.Windows.Forms.Panel();
            this.Reg_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reg_Panel
            // 
            this.Reg_Panel.BackColor = System.Drawing.Color.Black;
            this.Reg_Panel.Controls.Add(this.button5);
            this.Reg_Panel.Controls.Add(this.button3);
            this.Reg_Panel.Controls.Add(this.button4);
            this.Reg_Panel.Location = new System.Drawing.Point(-1, 0);
            this.Reg_Panel.Name = "Reg_Panel";
            this.Reg_Panel.Size = new System.Drawing.Size(957, 36);
            this.Reg_Panel.TabIndex = 69;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(260, -4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 52);
            this.button5.TabIndex = 42;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, -4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 52);
            this.button3.TabIndex = 40;
            this.button3.Text = "Register";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(129, -4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 52);
            this.button4.TabIndex = 41;
            this.button4.Text = "View Doctors";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(933, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 646);
            this.panel1.TabIndex = 70;
            // 
            // Docpanel
            // 
            this.Docpanel.Location = new System.Drawing.Point(-1, 34);
            this.Docpanel.Name = "Docpanel";
            this.Docpanel.Size = new System.Drawing.Size(936, 646);
            this.Docpanel.TabIndex = 71;
            this.Docpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Docpanel_Paint);
            // 
            // DoctorTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 681);
            this.Controls.Add(this.Docpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Reg_Panel);
            this.Name = "DoctorTabs";
            this.Text = "DoctorTabs";
            this.Reg_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Reg_Panel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Docpanel;
    }
}