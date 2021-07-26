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
    public partial class RegisterAdmin : Form
    {
        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int aid;
            string nic, fullname, dob, address, mobile, email, password,cpw , state, exp, othquali;
            aid = int.Parse(this.aid.Text);
            nic = anic.Text;
            fullname = afn.Text;
            dob = adob.Text;
            address = aadd.Text;
            mobile = amobile.Text;
            email = aemail.Text;
            password = apw.Text;
            cpw = acpw.Text;
            state = astate.Text;
            exp = aexp.Text;
            othquali = aothqu.Text;


            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Insert into admin values(" + aid+",'"+nic+"','" + fullname + "','" + dob + "','" + address + "','" + mobile + "','" +email + "','" + password + "','" + state + "','" + exp + "','" + othquali + "');";
            MySqlCommand cmd = new MySqlCommand(qry, areg);

            try
            {
                if (password == cpw)
                {
                    areg.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Registration Successfully.");
                    
                }
                else
                {
                    MessageBox.Show("Your Password and Confirmed Password don't match.");
                }
            }
            catch(MySqlException se)
            {
                MessageBox.Show(" " + se);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            aid.Text = null;
            anic.Text = null;
            afn.Text = null;
            adob.Text = null;
            aadd.Text = null;
            amobile.Text = null;
            aemail.Text = null;
            apw.Text = null;
            acpw.Text = null;
            astate.Text = null;
            aexp.Text = null;
            aothqu.Text = null;

        }

        private void RegisterAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
