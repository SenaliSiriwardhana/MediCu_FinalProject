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
    public partial class NewUpdateLab : Form
    {
        public NewUpdateLab()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int laid;
            string Lno, Lname, Ldate, Ladd, LT, Lmail, Lla, Llo,pw,cpw;
            laid=int.Parse(id.Text);
            Lname = labname.Text;
            Lno = regno.Text;
            Ldate = regdate.Text;
            Ladd = ad.Text;
            LT = cp.Text;
            Lmail = mail.Text;
            Lla = lati.Text;
            Llo = longi.Text;
            pw = password.Text;
            cpw = cp.Text;
            MySqlConnection pcon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string pqry = "Insert into lab values("+laid+",'" + Lname + "','" + Lno + "','" + Ldate + "','" + Ladd + "','" + LT + "','" + Lmail + "','" + Lla + "','" + Llo + "','"+pw+"')";
            MySqlCommand cmd = new MySqlCommand(pqry, pcon);
            try
            {
                if (pw == cpw)
                {
                    pcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lab Registration Successfully.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            int labid;
            string Lname, Ldate, Laddress, Ltel, Lmail, Llati, Llongi;
            labid = int.Parse(lid.Text);
            Lname = lname.Text;
            Ldate = ldate.Text;
            Laddress = ladd.Text;
            Ltel = ltel.Text;
            Lmail = lmail.Text;
            Llati = llati.Text;
            Llongi = llong.Text;
            

            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Update lab set labname='" + Lname + "',regdate='"+Ldate+"',address='" + Laddress + "',telno='" + Ltel + "',email='" + Lmail + "',latitude='" + Llati + "',longitude='" + Llongi + "' where labid =" + labid + " ";
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

        private void button7_Click(object sender, EventArgs e)
        {
            lid.Text = null;
            id.Text = null;
            tel.Text = null;
            labname.Text = null;
            regno.Text = null;
            regdate.Text = null;
            ad.Text = null;
            cp.Text = null;
            mail.Text = null;
            lati.Text = null;
            longi.Text = null;
            password.Text = null;
            cp.Text = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lid.Text =null;
            lname.Text = null;
            ldate.Text = null;
            ladd.Text = null;
            ltel.Text = null;
            lmail.Text = null;
            llati.Text = null;
            llong.Text = null;
        }
    }
}
