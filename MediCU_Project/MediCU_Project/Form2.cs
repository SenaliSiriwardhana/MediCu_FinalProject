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
    public partial class Form2 : Form
    {
        private int id;
        private Form activeForm;
        
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Admin_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Registration(), sender);
            

        }
        
        private void ChildFormPanelAdmin_Paint(object sender, PaintEventArgs e)
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
            this.ChildFormPanelAdmin.Controls.Add(childForm);
            this.ChildFormPanelAdmin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DoctorTabs(), sender);
            
        }

        private void Rec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReceptionistTabs(), sender);
            
        }

        private void Lab_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LabTabs(), sender);
           
        }

        private void Phs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PharmacyTabs(), sender);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AddDrugs(), sender);
        }

        private void AccSet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AccSettingsPanel(id), sender);
        }

        private void Acc_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ret= new Form1();
            ret.Show();
            this.Hide();
        }
    }
}
