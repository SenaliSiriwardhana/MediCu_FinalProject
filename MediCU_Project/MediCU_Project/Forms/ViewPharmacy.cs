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
    public partial class ViewPharmacy : Form
    {
        public ViewPharmacy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True";
            string getquery = "Select * from pharmacy";
            MySqlDataAdapter ad = new MySqlDataAdapter(getquery, constring);
            DataSet ds = new DataSet();
            ad.Fill(ds, "pharmacy");
            dgvph.DataSource = ds.Tables["pharmacy"];
        }

        private void dgvph_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
