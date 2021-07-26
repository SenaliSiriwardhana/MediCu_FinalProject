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
    public partial class MediCuLaboratory : Form
    {
        private int id;
        private Form activeForm;

        public MediCuLaboratory()
        {
            InitializeComponent();
        }
        public MediCuLaboratory(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ChildFormPanelDoctor_Paint(object sender, PaintEventArgs e)
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
            this.ChildFormPanelLab.Controls.Add(childForm);
            this.ChildFormPanelLab.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void LabPatientDetals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Lab_Patient_Details(), sender);
        }

        private void AccSetLab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AccSettingLab(id), sender);
        }

        private void MediCuLaboratory_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ret = new Form1();
            ret.Show();
            this.Hide();
        }
    }
}
