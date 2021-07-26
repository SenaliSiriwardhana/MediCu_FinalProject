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
    public partial class NewLabR : Form
    {
        public NewLabR()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pid;
            string testname, status;
            pid = int.Parse(lpid.Text);
            testname = ltest.GetItemText(ltest.SelectedItem);
            status = lstatus.Text;

            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry = "Insert into labreports values(NULL,'" + testname + "','" + status + "'," + pid + ") ";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Test added.");
            }
            catch (MySqlException see)
            {
                MessageBox.Show("" + see);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pid;
            string age;
            pid = int.Parse(lpid.Text);
            age = lpage.Text;


            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry = "Select Name,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS Age from patient where Id=" + pid + "";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            try
            {
                con.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                lpname.Text = sdr["Name"].ToString();
                lpage.Text = sdr["Age"].ToString();
            }
            catch (MySqlException se)
            {
                MessageBox.Show("" + se);
            }
        }
    }
}
