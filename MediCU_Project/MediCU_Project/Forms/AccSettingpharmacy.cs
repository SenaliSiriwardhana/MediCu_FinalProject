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
    
    public partial class AccSettingpharmacy : Form
    {
        private int id;
        public AccSettingpharmacy()
        {
            InitializeComponent();
        }
        public AccSettingpharmacy(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p, cp;
            p = phpw.Text;
            cp = phcpw.Text;
            MySqlConnection con2 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1");
            string qry2 = "Update pharmacy set Password='" + p + "'where Phaid=" + id + "";
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
            string n, dat, add, mobile, em, latitude, longii;
            n = name.Text;
            dat = date.Text;
            add = ad.Text;
            mobile = tno.Text;
            em = mail.Text;
            latitude = lati.Text;
            longii = longi.Text;

            MySqlConnection con3 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1");
            string qry3 = "Update pharmacy set PhaName='" + n + "',RegDate='" + dat + "',Address='" + add + "',TelNo='" + mobile + "',Email='" + em + "',Latitude='" + latitude + "',Longitude='" + longii + "'where Phaid=" + id + "";
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
            name.Text=null;
            date.Text = null;
            ad.Text = null;
            tno.Text = null;
            mail.Text = null;
            lati.Text = null;
            longi.Text = null;
        }
    }
}
