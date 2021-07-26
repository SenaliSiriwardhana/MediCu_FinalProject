using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediCU_Project.Forms
{
    public partial class Vpha : Form
    {
        public Vpha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(patientid.Text);
            string constring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True";
            string getquery = "Select * from pharmacyinvoices where PatientId="+id+" ";
            MySqlDataAdapter ad = new MySqlDataAdapter(getquery, constring);
            DataSet ds = new DataSet();
            ad.Fill(ds, "pharmacyinvoices");
            drugdb.DataSource = ds.Tables["pharmacyinvoices"];
        }

        private void patientid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
