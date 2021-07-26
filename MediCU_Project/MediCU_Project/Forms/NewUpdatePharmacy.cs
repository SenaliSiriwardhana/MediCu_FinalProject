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
    public partial class NewUpdatePharmacy : Form
    {
        public NewUpdatePharmacy()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int pid;
            string Prno,Pname, Pdate, Padd, PT, Pmail, Pla, Plo,pp,pcpw;
            pid = int.Parse(id.Text);
            Prno = pno.Text;
            Pname = pname.Text;
            Pdate = pdate.Text;
            Padd = padd.Text;
            PT = ptno.Text;
            Pmail = pmail.Text;
            Pla = pl.Text;
            Plo = plo.Text;
            pp = password.Text;
            pcpw = cp.Text;

            MySqlConnection pcon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string pqry = "Insert into pharmacy values("+pid+",'"+Pname+"','"+Prno+"','"+Pdate+"','"+Padd+"','"+PT+"','"+Pmail+"','"+Pla+"','"+Plo+"','"+pp+"')";
            MySqlCommand cmd = new MySqlCommand(pqry, pcon);
            try
            {
                if (pp == pcpw)
                {
                    pcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pharmacy Registration Successfully.");
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
            id.Text = null;
            pno.Text=null;
            pname.Text = null;
            pdate.Text = null;
            padd.Text = null;
            ptno.Text = null;
            pmail.Text = null;
            pl.Text = null;
            plo.Text = null;
            password.Text = null;
            cp.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int puid;
            string pname, pdate, paddress, ptel, pmail, plati, plongi;
            puid = int.Parse(pid.Text);
            pname = upn.Text;
            pdate = upd.Text;
            paddress = upad.Text;
            ptel = upt.Text;
            pmail = upe.Text;
            plati = upla.Text;
            plongi = uplo.Text;



            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Update pharmacy set PhaName='" + pname + "',RegDate='" + pdate + "',Address='" + paddress + "',TelNo='" + ptel + "',Email='" + pmail + "',Latitude='" + plati + "',Longitude='"+plongi+"' where Phaid=" + puid + " ";
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

            pid.Text = null;
            upn.Text=null;
            upd.Text=null;
            upad.Text=null;
            upt.Text=null;
            upe.Text=null;
            upla.Text=null;
            uplo.Text=null;


        }
    }
}
