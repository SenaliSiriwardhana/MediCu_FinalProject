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
    public partial class NewPhInv : Form
    {
        

        public NewPhInv()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            MySqlConnection scon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry = "Select * from drugs";
            MySqlCommand cmd = new MySqlCommand(qry, scon);
            MySqlDataReader sdr;
            try
            {
                scon.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string dbcolname = sdr ["Name"].ToString();
                    dpdrug.Items.Add(dbcolname);
                }
            }
            catch(Exception se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void NewPhInv_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pid;
            string age;
            pid = int.Parse(dpid.Text);
            age = dpa.Text;
            

            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry= "Select Name,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS Age from patient where Id=" + pid+"";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            try
            {
                con.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                dpn.Text = sdr["Name"].ToString();
                dpa.Text = sdr["Age"].ToString();
            }
            catch(MySqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void dpdrug_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pid;
            string dname, qua;
            pid = int.Parse(dpid.Text);
            dname= dpdrug.GetItemText(dpdrug.SelectedItem);
            qua = dpqua.Text;
            String test = DateTime.Now.ToString("dd.MM.yyyy");

            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Insert into pharmacyinvoices values(NULL,'" + dname + "','" + qua + "',"+pid+") ";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Drug added.");
            }
            catch(MySqlException see)
            {
                MessageBox.Show("" + see);
            }

            
        }
    }
}
