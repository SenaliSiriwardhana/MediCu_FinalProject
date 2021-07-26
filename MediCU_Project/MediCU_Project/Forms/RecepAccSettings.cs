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
    public partial class RecepAccSettings : Form
    {
        private int id;
        public RecepAccSettings()
        {
            InitializeComponent();
        }
        public RecepAccSettings(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p, cp;
            p = repw.Text;
            cp = recpw.Text;
            MySqlConnection con2 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry2 = "Update receptionist set Password='" + p + "'where RecId=" + id + "";
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
            unic = rnic.Text;
            udob = rdob.Text;
            fnm = rfn.Text;
            add = rad.Text;
            umobile = rm.Text;
            umail = rmail.Text;

            MySqlConnection con3 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry3 = "Update receptionist set NIC='" + unic + "',DOB='" + udob + "',FullName='" + fnm + "',Address='" + add + "',Mobile='" + umobile + "',Email='" + umail + "'where RecId=" + id + "";
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
            rnic.Text=null;
            rdob.Text=null;
            rfn.Text=null;
            rad.Text=null;
            rm.Text=null;
            rmail.Text=null;
        }
    }
}
