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
    public partial class vlab : Form
    {
        public vlab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(patientid.Text);
            string constring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;";
            string getquery = "Select * from labreports where id=" + id + " ";
            MySqlDataAdapter ad = new MySqlDataAdapter(getquery, constring);
            DataSet ds = new DataSet();
            ad.Fill(ds, "labreports");
            viewlabreport.DataSource = ds.Tables["labreports"];
        }
    }
}
