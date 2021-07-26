using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCU_Project
{
    public partial class DrugsTabs : Form
    {
        private Form activeForm;


        public DrugsTabs()
        {
            InitializeComponent();
        }

        private void AddViewDrugsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ActivateButton(object btnSender)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.AddViewDrugsPanel.Controls.Add(childForm);
            this.AddViewDrugsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Add_Drugs(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.View_Drugs(), sender);
        }
    }
}
