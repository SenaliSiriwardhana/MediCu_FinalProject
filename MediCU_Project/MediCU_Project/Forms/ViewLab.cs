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
    public partial class ViewLab : Form
    {
        public ViewLab()
        {
            InitializeComponent();
        }

        private void ViewLab_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True";
            string getquery = "Select * from lab";
            MySqlDataAdapter ad = new MySqlDataAdapter(getquery, constring);
            DataSet ds = new DataSet();
            ad.Fill(ds, "lab");
            dgvlab.DataSource = ds.Tables["lab"];
        }

        
    }
}
