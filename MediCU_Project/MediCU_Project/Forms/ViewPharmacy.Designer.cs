namespace MediCU_Project.Forms
{
    partial class ViewPharmacy
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
            this.dgvph = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvph)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvph
            // 
            this.dgvph.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvph.Location = new System.Drawing.Point(12, 74);
            this.dgvph.Name = "dgvph";
            this.dgvph.RowTemplate.Height = 24;
            this.dgvph.Size = new System.Drawing.Size(894, 385);
            this.dgvph.TabIndex = 4;
            this.dgvph.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvph_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(328, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Registered Pharmacies";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewPharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvph);
            this.Name = "ViewPharmacy";
            this.Text = "ViewPharmacy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvph;
        private System.Windows.Forms.Button button1;
    }
}