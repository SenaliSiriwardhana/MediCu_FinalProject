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
    public partial class UpdateDoctors : Form
    {
        public UpdateDoctors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uid;
            string npw, cpw;
            uid = int.Parse(duid.Text);
            npw = dupw.Text;
            cpw = ducpw.Text;

            MySqlConnection updatecon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string updateqry = "Update doctor set Password='" + npw + "'where DoctorId=" + uid + "";
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
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int did;
            did = int.Parse(dduid.Text);
            MySqlConnection scon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string sqry = "Select * from doctor where DoctorId=" + did + "";
            MySqlDataAdapter adoctor = new MySqlDataAdapter(sqry, scon);
            DataSet doctords = new DataSet();
            adoctor.Fill(doctords, "doctor");
            int i = doctords.Tables[0].Rows.Count;

            if (i > 0)
            {
                MySqlConnection ucon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
                string uqry = "Delete from doctor where DoctorId=" + did + "";
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
            aid = int.Parse(dcid.Text);
            nic = dcnic.Text;
            fullname = dcfn.Text;
            dob = dcdob.Text;
            address = dcadd.Text;
            mobile = dcmobile.Text;
            email = dmail.Text;



            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Update doctor set NIC='" + nic + "',DOB='" + dob + "',FullName='" + fullname + "',Address='" + address + "',Mobile='" + mobile + "',Email='" + email + "' where DoctorId=" + aid + " ";
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
            dcid.Text=null;
            dcnic.Text = null;
            dcfn.Text = null;
            dcdob.Text = null;
            dcadd.Text = null;
            dcmobile.Text = null;
            dmail.Text = null;
        }

        private void UpdateDoctors_Load(object sender, EventArgs e)
        {

        }
    }
}
