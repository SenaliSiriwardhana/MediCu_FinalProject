namespace MediCU_Project.Forms
{
    partial class PharmacyTabs
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Reg_Panel = new System.Windows.Forms.Panel();
            this.Receppanel = new System.Windows.Forms.Panel();
            this.Docpanel = new System.Windows.Forms.Panel();
            this.PharmacyPanel = new System.Windows.Forms.Panel();
            this.Reg_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, -8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 52);
            this.button3.TabIndex = 40;
            this.button3.Text = "New/Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(129, -8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 52);
            this.button4.TabIndex = 41;
            this.button4.Text = "View Pharmacy";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Reg_Panel
            // 
            this.Reg_Panel.BackColor = System.Drawing.Color.Black;
            this.Reg_Panel.Controls.Add(this.Receppanel);
            this.Reg_Panel.Controls.Add(this.Docpanel);
            this.Reg_Panel.Controls.Add(this.button3);
            this.Reg_Panel.Controls.Add(this.button4);
            this.Reg_Panel.Location = new System.Drawing.Point(0, 2);
            this.Reg_Panel.Name = "Reg_Panel";
            this.Reg_Panel.Size = new System.Drawing.Size(957, 31);
            this.Reg_Panel.TabIndex = 73;
            // 
            // Receppanel
            // 
            this.Receppanel.Location = new System.Drawing.Point(2, 34);
            this.Receppanel.Name = "Receppanel";
            this.Receppanel.Size = new System.Drawing.Size(936, 581);
            this.Receppanel.TabIndex = 74;
            // 
            // Docpanel
            // 
            this.Docpanel.Location = new System.Drawing.Point(0, 36);
            this.Docpanel.Name = "Docpanel";
            this.Docpanel.Size = new System.Drawing.Size(936, 581);
            this.Docpanel.TabIndex = 73;
            // 
            // PharmacyPanel
            // 
            this.PharmacyPanel.Location = new System.Drawing.Point(0, 31);
            this.PharmacyPanel.Name = "PharmacyPanel";
            this.PharmacyPanel.Size = new System.Drawing.Size(951, 646);
            this.PharmacyPanel.TabIndex = 75;
            this.PharmacyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LabPanel_Paint);
            // 
            // PharmacyTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 679);
            this.Controls.Add(this.PharmacyPanel);
            this.Controls.Add(this.Reg_Panel);
            this.Name = "PharmacyTabs";
            this.Text = "PharmacyTabs";
            this.Reg_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel Reg_Panel;
        private System.Windows.Forms.Panel Receppanel;
        private System.Windows.Forms.Panel Docpanel;
        private System.Windows.Forms.Panel PharmacyPanel;
    }
}