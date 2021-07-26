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
    public partial class AccSettingLab : Form
    {
        private int id;
        public AccSettingLab()
        {
            InitializeComponent();
        }
        public AccSettingLab(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lupw, lucpw;
            lupw = labpw.Text;
            lucpw = labcpw.Text;
            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry = "Update lab set Password='"+lupw+"' where labId="+id+"";
            MySqlCommand cmd = new MySqlCommand(qry, con);


            try
            {
                if (lupw == lucpw)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
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
            string n, dat, add, mobile, em, latitude, longi;
            n = name.Text;
            dat = date.Text;
            add = ad.Text;
            mobile = mob.Text;
            em = mail.Text;
            latitude = lati.Text;
            longi = lon.Text;

            MySqlConnection con3 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry3 = "Update lab set labname='" + n + "',regdate='" + dat + "',address='" + add + "',telno='" + mobile + "',email='" + em + "',latitude='" + latitude + "',longitude='" + longi + "'where labId=" + id + "";
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
            mob.Text = null;
            mail.Text = null;
            lati.Text = null;
            lon.Text = null;
        }
    }
}
