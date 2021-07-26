using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCU_Project.Forms
{
    public partial class Registration : Form
    {
        private Form activeForm;

        public Registration()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ActivateButton(object btnSender)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ChildFormPanel2.Controls.Add(childForm);
            this.ChildFormPanel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RegisterAdmin(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewAdmin(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Update_Admin(), sender);
        }
    }
}
