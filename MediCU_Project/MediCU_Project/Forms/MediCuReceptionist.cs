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
    public partial class MediCuReceptionist : Form
    {
        private int id;
        private Form activeForm;

        public MediCuReceptionist()
        {
            InitializeComponent();
        }
        public MediCuReceptionist(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ChildFormPanelReceptionist_Paint(object sender, PaintEventArgs e)
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
            this.ChildFormPanelReceptionist.Controls.Add(childForm);
            this.ChildFormPanelReceptionist.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void npi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Receptionist_Patient(), sender);
        }

        private void nlr_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RecDoctor(), sender);
        }

        private void AccSetDoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RecepAccSettings(id), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ret = new Form1();
            ret.Show();
            this.Hide();
        }
    }
}
