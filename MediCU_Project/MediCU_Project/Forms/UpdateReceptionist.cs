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
    public partial class UpdateReceptionist : Form
    {
        public UpdateReceptionist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uid;
            string rpw, rcpw;
            uid = int.Parse(ruid.Text);
            rpw = rupw.Text;
            rcpw = rucpw.Text;

            MySqlConnection updatecon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string updateqry = "Update receptionist set Password='" + rpw + "'where RecId=" + uid + "";
            MySqlCommand cmd2 = new MySqlCommand(updateqry, updatecon);
            try
            {
                if (String.IsNullOrEmpty(rpw) || String.IsNullOrEmpty(rcpw))
                {
                    MessageBox.Show("Type a new password.");
                }
                else if (rpw == rcpw)
                {
                    updatecon.Open();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Password changed sucessfully.");

                }
                else
                {
                    MessageBox.Show("Your Password and Confirmed Password didn't match.");
                }
            }
            catch (MySqlException se)
            {
                MessageBox.Show(" " + se);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rid;
            rid = int.Parse(urid.Text);
            MySqlConnection scon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string sqry = "Select * from receptionist where RecId=" + rid + "";
            MySqlDataAdapter arec = new MySqlDataAdapter(sqry, scon);
            DataSet recds = new DataSet();
            arec.Fill(recds, "receptionist");
            int i = recds.Tables[0].Rows.Count;

            if (i > 0)
            {
                MySqlConnection ucon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
                string uqry = "Delete from receptionist where RecId=" + rid + "";
                MySqlCommand cmd3 = new MySqlCommand(uqry, ucon);

                try
                {
                    ucon.Open();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.");
                }
                catch (MySqlException se)
                {
                    MessageBox.Show("" + se);
                }

            }
            else
            {
                MessageBox.Show("ID is not exist.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            string nic, fullname, dob, address, mobile, email;
            id = int.Parse(rid.Text);
            nic = rnic.Text;
            fullname = rfname.Text;
            dob = rdob.Text;
            address = rad.Text;
            mobile = rmob.Text;
            email = rmail.Text;



            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Update receptionist set NIC='" + nic + "',DOB='" + dob + "',FullName='" + fullname + "',Address='" + address + "',Mobile='" + mobile + "',Email='" + email + "' where RecId=" + id + " ";
            MySqlCommand cmd = new MySqlCommand(qry, areg);

            try
            {

                areg.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update details registration Successfully.");

            }


            catch (MySqlException se)
            {
                MessageBox.Show(" " + se);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            rid.Text=null;
            rnic.Text = null;
            rfname.Text = null;
            rdob.Text = null;
            rad.Text = null;
            rmob.Text = null;
            rmail.Text = null;
        }
    }
}
