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
    public partial class ReceptionistRegistration : Form
    {
        public ReceptionistRegistration()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int rid;
            string nic, rfullname, dob, raddress, mobile, remail, rpassword, cpw, state, exp, rqualification;
            rid = int.Parse(Rrecid.Text);
            nic = rnic.Text;
            rfullname = rfname.Text;
            dob = rdob.Text;
            raddress = rad.Text;
            mobile = rmobile.Text;
            remail = rmail.Text;
            rpassword = rpw.Text;
            cpw = rcpw.Text;
            state = rstate.Text;
            exp = rex.Text;
            rqualification = rqua.Text;

            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Insert into receptionist values(" + rid + ",'" + nic + "','" + rfullname + "','" + dob + "','" + raddress + "','" + mobile + "','" + remail + "','" + rpassword + "','" + state + "','" + exp + "','"+rqualification+"');";
            MySqlCommand cmd = new MySqlCommand(qry, areg);

            try
            {
                if (rpassword == cpw)
                {
                    areg.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Registration Successfully.");

                }
                else
                {
                    MessageBox.Show("Your Password and Confirmed Password don't match.");
                }
            }
            catch (MySqlException se)
            {
                MessageBox.Show(" " + se);
            }

        
    }

        private void button7_Click(object sender, EventArgs e)
        {
            Rrecid.Text=null;
            rnic.Text = null;
            rfname.Text = null;
            rdob.Text = null;
            rad.Text = null;
            rmobile.Text = null;
            rmail.Text = null;
            rpw.Text = null;
            rcpw.Text = null;
            rstate.Text = null;
            rex.Text = null;
            rqua.Text = null;
        }
    }
}
