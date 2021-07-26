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
    public partial class DoctorRegistration : Form
    {
        public DoctorRegistration()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int did;
            string nic, fullname, dob, address, mobile, email, password, cpw, state, exp, special,adates,ft,tt;
            did = int.Parse(RegNo.Text);
            nic = dnic.Text;
            fullname = dfn.Text;
            dob = ddob.Text;
            address = dadd.Text;
            mobile = dmobile.Text;
            email = dmail.Text;
            password = dpw.Text;
            cpw = dcpw.Text;
            state = drstate.Text;
            exp = dex.Text;
            special = dsp.Text;
            ft = dtp1.Text;
            tt = dtp2.Text;
            adates = dadates.Text;


            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Insert into doctor values(" + did + ",'" + nic + "','" + fullname + "','" + dob + "','" + address + "','" + mobile + "','" + email + "','" + password + "','" + state + "','" + exp + "','" + special + "','"+ft+"','"+tt+"','"+adates+"');";
            MySqlCommand cmd = new MySqlCommand(qry, areg);

            try
            {
                if (password == cpw)
                {
                    areg.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Registration Successfully.");

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
            RegNo.Text = null;
            dnic.Text = null;
            dfn.Text = null;
            ddob.Text = null;
            dadd.Text = null;
            dmobile.Text = null;
            dmail.Text = null;
            dpw.Text = null;
            dcpw.Text = null;
            drstate.Text = null;
            dex.Text = null;
            dsp.Text = null;
            dtp1.Text = null;
            dtp2.Text = null;
            dadates.Text = null;
        }
    }
}
