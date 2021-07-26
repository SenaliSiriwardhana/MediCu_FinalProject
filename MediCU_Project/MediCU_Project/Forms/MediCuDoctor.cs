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
    public partial class MediCuDoctor : Form
    {
        private int docid;
        private Form activeForm;
        

        public MediCuDoctor()
        {
            InitializeComponent();
        }
        public MediCuDoctor(int docid)
        {
            InitializeComponent();
            this.docid = docid;
        }
        

        private void LeftMainPanel_Paint(object sender, PaintEventArgs e)
        {

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
            this.ChildFormPanelDoctor.Controls.Add(childForm);
            this.ChildFormPanelDoctor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void npi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.NewPhInv(), sender);
        }

        private void nlr_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.NewLabR(), sender);
        }

        private void vpi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Vpha(), sender);
        }

        private void vlr_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.vlab(), sender);
        }

        private void AccSetDoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DocAccSettings(docid), sender);
        }

        private void MediCuDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
