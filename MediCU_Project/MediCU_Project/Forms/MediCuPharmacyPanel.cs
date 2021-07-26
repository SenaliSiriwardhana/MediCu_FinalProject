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
    public partial class MediCuPharmacyPanel : Form
    {
        private int id;
        private Form activeForm;

        public MediCuPharmacyPanel()
        {
            InitializeComponent();
        }
        public MediCuPharmacyPanel(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ChildFormPanelPharmacy_Paint(object sender, PaintEventArgs e)
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
            this.ChildFormPanelPharmacy.Controls.Add(childForm);
            this.ChildFormPanelPharmacy.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Acc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Pharmacy_Patient_Details(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DrugsTabs(), sender);
        }

        private void AccSetDoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AccSettingpharmacy(id), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ret = new Form1();
            ret.Show();
            this.Hide();
        }
    }
}
