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
    public partial class Update_Admin : Form
    {
        public Update_Admin( )
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uid;
            string npw, cpw;
            uid = int.Parse(updateid.Text);
            npw = uanpw.Text;
            cpw = uacpw.Text;

            MySqlConnection updatecon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string updateqry = "Update admin set Password='" + npw + "'where AdminId=" + uid + "";
            MySqlCommand cmd2 = new MySqlCommand(updateqry, updatecon);
            try
            {
                if (String.IsNullOrEmpty(npw) || String.IsNullOrEmpty(cpw))
                {
                    MessageBox.Show("Type a new password.");
                }
                else if (npw == cpw)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int did;
            did = int.Parse(dltid.Text);
            MySqlConnection scon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string sqry = "Select * from admin where AdminId=" + did + "";
            MySqlDataAdapter ad = new MySqlDataAdapter(sqry, scon);
            DataSet ds = new DataSet();
            ad.Fill(ds, "admin");
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
            {
                MySqlConnection ucon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
                string uqry = "Delete from admin where AdminId=" + did + "";
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
            int aid;
            string nic, fullname, dob, address, mobile, email;
            aid = int.Parse(uid.Text);
            nic = unic.Text;
            fullname = ufn.Text;
            dob = udob.Text;
            address = uad.Text;
            mobile = um.Text;
            email = uem.Text;
            


            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Update admin set NIC='"+nic+"',DOB='"+dob+"',FullName='"+fullname+ "',Address='" + address + "',Mobile='" + mobile + "',Email='" + email + "' where AdminId="+aid+" ";
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
            uid.Text = null;
            unic.Text = null;
            ufn.Text = null;
            udob.Text = null;
            uad.Text = null;
            um.Text = null;
            uem.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
    

