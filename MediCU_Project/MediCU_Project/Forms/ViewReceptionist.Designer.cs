namespace MediCU_Project.Forms
{
    partial class ViewReceptionist
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
            this.dgvR = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvR
            // 
            this.dgvR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvR.Location = new System.Drawing.Point(12, 73);
            this.dgvR.Name = "dgvR";
            this.dgvR.RowTemplate.Height = 24;
            this.dgvR.Size = new System.Drawing.Size(894, 414);
            this.dgvR.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Registered Receptionists";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvR);
            this.Name = "ViewReceptionist";
            this.Text = "ViewReceptionist";
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvR;
        private System.Windows.Forms.Button button1;
    }
}