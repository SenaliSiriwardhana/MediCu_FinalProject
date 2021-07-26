namespace MediCU_Project.Forms
{
    partial class View_Drugs
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
            this.dgvdrug = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdrug)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdrug
            // 
            this.dgvdrug.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdrug.Location = new System.Drawing.Point(12, 97);
            this.dgvdrug.Name = "dgvdrug";
            this.dgvdrug.RowTemplate.Height = 24;
            this.dgvdrug.Size = new System.Drawing.Size(909, 377);
            this.dgvdrug.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(345, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 31);
            this.button7.TabIndex = 28;
            this.button7.Text = "View Drugs";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // View_Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 599);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dgvdrug);
            this.Name = "View_Drugs";
            this.Text = "View_Drugs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdrug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdrug;
        private System.Windows.Forms.Button button7;
    }
}