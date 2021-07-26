namespace MediCU_Project.Forms
{
    partial class vlab
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
            this.viewlabreport = new System.Windows.Forms.DataGridView();
            this.patientid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewlabreport)).BeginInit();
            this.SuspendLayout();
            // 
            // viewlabreport
            // 
            this.viewlabreport.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewlabreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewlabreport.Location = new System.Drawing.Point(12, 97);
            this.viewlabreport.Name = "viewlabreport";
            this.viewlabreport.RowTemplate.Height = 24;
            this.viewlabreport.Size = new System.Drawing.Size(851, 395);
            this.viewlabreport.TabIndex = 1;
            // 
            // patientid
            // 
            this.patientid.Location = new System.Drawing.Point(368, 40);
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(100, 22);
            this.patientid.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(527, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient ID";
            // 
            // vlab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 563);
            this.Controls.Add(this.patientid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewlabreport);
            this.Name = "vlab";
            this.Text = "vlab";
            ((System.ComponentModel.ISupportInitialize)(this.viewlabreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewlabreport;
        private System.Windows.Forms.TextBox patientid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}