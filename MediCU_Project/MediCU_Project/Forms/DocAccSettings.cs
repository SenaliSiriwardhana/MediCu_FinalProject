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
    public partial class DocAccSettings : Form
    {
        private int docid;
        public DocAccSettings()
        {
            InitializeComponent();
        }
        public DocAccSettings(int docid)
        {
            InitializeComponent();
            this.docid = docid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p, cp;
            p = dpw.Text;
            cp = dcpw.Text;
            MySqlConnection con2 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry2 = "Update doctor set Password='" + p + "'where DoctorId=" + docid + "";
            MySqlCommand cmd2 = new MySqlCommand(qry2, con2);

            try
            {
                if (p == cp)
                {
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Password Updation Successfully. ");
                }
                else
                {
                    MessageBox.Show("Your password and confirm password didn't match.");
                }
            }
            catch (MySqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string unic, udob, fnm, add, umobile, umail;
            unic = nic.Text;
            udob = dob.Text;
            fnm = fn.Text;
            add = ad.Text;
            umobile = m.Text;
            umail = mail.Text;

            MySqlConnection con3 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry3 = "Update doctor set NIC='" + unic + "',DOB='" + udob + "',FullName='" + fnm + "',Address='" + add + "',Mobile='" + umobile + "',Email='" + umail + "'where DoctorId=" + docid + "";
            MySqlCommand cmd3 = new MySqlCommand(qry3, con3);
            try
            {


                con3.Open();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Details Updation Successfully. ");


            }
            catch (MySqlException see)
            {
                MessageBox.Show("" + see);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          nic.Text=null;
          dob.Text = null;
          fn.Text = null;
          ad.Text = null;
          m.Text = null;
          mail.Text = null;
        }

        private void DocAccSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
