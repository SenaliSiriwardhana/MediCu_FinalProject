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
    public partial class AddDrugs : Form
    {
        public AddDrugs()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String dname;
            dname = drugname.Text;
            MySqlConnection dcon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string dqry="Insert into drugs values(NULL,'"+dname+"')";
            MySqlCommand cmd = new MySqlCommand(dqry, dcon);
            try
            {

                dcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Drug Registration Successfully.");
            }
            catch (MySqlException se)
            {
                MessageBox.Show(" " + se);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int drugid;
            string drugname;
            drugid = int.Parse(did.Text);
            drugname = dn.Text;
            MySqlConnection dcon2 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string dqry2 = "Update drugs set Name='" + drugname + "'where DrugId=" + drugid + "";
            MySqlCommand cmd2 = new MySqlCommand(dqry2, dcon2);
            try
            {

                dcon2.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Drug Updated Successfully.");
            }
            catch (MySqlException se)
            {
                MessageBox.Show(" " + se);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int drugid;
            drugid = int.Parse(ddn.Text);
            MySqlConnection dcon3 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string dqry3 = "Delete from drugs where DrugId="+drugid+"";
            MySqlCommand cmd3 = new MySqlCommand(dqry3, dcon3);

            try
            {

                dcon3.Open();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Drug Deleted Successfully.");
            }
            catch (MySqlException se)
            {
                MessageBox.Show(" " + se);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;";
            string getquery = "Select * from drugs";
            MySqlDataAdapter ad = new MySqlDataAdapter(getquery, constring);
            DataSet ds = new DataSet();
            ad.Fill(ds, "lab");
            dgvdrug.DataSource = ds.Tables["lab"];
        }
    }
}
