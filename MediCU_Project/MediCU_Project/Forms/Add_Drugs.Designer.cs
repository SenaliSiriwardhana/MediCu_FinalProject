namespace MediCU_Project.Forms
{
    partial class Add_Drugs
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
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dprice = new System.Windows.Forms.TextBox();
            this.dq = new System.Windows.Forms.TextBox();
            this.dname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.uprice = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(127, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 33);
            this.button1.TabIndex = 154;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(122, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 29);
            this.label13.TabIndex = 153;
            this.label13.Text = "Add New Drug";
            // 
            // dprice
            // 
            this.dprice.Location = new System.Drawing.Point(162, 211);
            this.dprice.Name = "dprice";
            this.dprice.Size = new System.Drawing.Size(251, 22);
            this.dprice.TabIndex = 152;
            // 
            // dq
            // 
            this.dq.Location = new System.Drawing.Point(162, 168);
            this.dq.Name = "dq";
            this.dq.Size = new System.Drawing.Size(251, 22);
            this.dq.TabIndex = 151;
            // 
            // dname
            // 
            this.dname.Location = new System.Drawing.Point(162, 126);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(251, 22);
            this.dname.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 149;
            this.label3.Text = "Price per item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 148;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 147;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.ForeColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(441, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 551);
            this.panel2.TabIndex = 233;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(651, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 33);
            this.button2.TabIndex = 229;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(609, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 29);
            this.label10.TabIndex = 228;
            this.label10.Text = "Update New Drug";
            // 
            // uprice
            // 
            this.uprice.Location = new System.Drawing.Point(629, 263);
            this.uprice.Name = "uprice";
            this.uprice.Size = new System.Drawing.Size(251, 22);
            this.uprice.TabIndex = 225;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(629, 216);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(251, 22);
            this.quantity.TabIndex = 223;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(479, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 222;
            this.label7.Text = "Price per item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(479, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 220;
            this.label9.Text = "Quantity";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(629, 169);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(251, 22);
            this.name.TabIndex = 219;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(629, 127);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(251, 22);
            this.id.TabIndex = 218;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(479, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 216;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(479, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 215;
            this.label6.Text = "Enter Drug Id";
            // 
            // Add_Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.uprice);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dprice);
            this.Controls.Add(this.dq);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Drugs";
            this.Text = "Add_Drugs";
            this.Load += new System.EventHandler(this.Add_Drugs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox dprice;
        private System.Windows.Forms.TextBox dq;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uprice;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}