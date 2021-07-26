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
    public partial class View_Drugs : Form
    {
        public View_Drugs()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string constring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;";
            string getquery = "Select * from Pharmacydrugstore";
            MySqlDataAdapter ad = new MySqlDataAdapter(getquery, constring);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Pharmacydrugstore");
            dgvdrug.DataSource = ds.Tables["Pharmacydrugstore"];
        }
    }
}
