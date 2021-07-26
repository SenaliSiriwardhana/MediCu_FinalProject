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
    public partial class AccSettingsPanel : Form
    {
        private int id;

       
        public AccSettingsPanel()
        {
            InitializeComponent();
        }

        public AccSettingsPanel(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AccSettingsPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            string p, cp;
            p = npw.Text;
            cp = cnpw.Text;
            MySqlConnection con2 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry2 = "Update admin set Password='" + p + "'where AdminId="+id+"";
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
            string unic, udob, fn, add, umobile, umail;
            unic = nic.Text;
            udob = dob.Text;
            fn = fullname.Text;
            add = ad.Text;
            umobile = mobile.Text;
            umail = mail.Text;

            MySqlConnection con3 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry3 = "Update admin set NIC='"+unic+"',DOB='"+udob+"',FullName='"+fn+"',Address='"+add+"',Mobile='"+umobile+"',Email='"+umail+"'where AdminId="+id+"";
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
            nic.Text = null;
            dob.Text = null;
            fullname.Text = null;
            ad.Text = null;
            mobile.Text = null;
            mail.Text = null;
        }
    }
}
