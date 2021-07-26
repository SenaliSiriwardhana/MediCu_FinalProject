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
using System.Net.Mail;
using System.Net;


namespace MediCU_Project.Forms
{
    public partial class Receptionist_Patient : Form
    {
        public Receptionist_Patient()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int searchpid;
            string pnic, pname, pdob, pad, pmob, pmail;
            searchpid = int.Parse(searchpidmain.Text);
            pname = patname.Text;
            pdob = date.Text;
            pad = address.Text;
            pmob = mobile.Text;
            pmail = eemail.Text;
            pnic = nicc.Text;
            


            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True;");
            string qry = "Select * from patient where Id=" + searchpid + "";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            try
            {
                con.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                patname.Text = sdr["Name"].ToString();
                date.Text = sdr["DOB"].ToString();
                
                address.Text = sdr["Address"].ToString();
                mobile.Text = sdr["Mobile"].ToString();
                eemail.Text = sdr["Email"].ToString();
                nicc.Text = sdr["NIC"].ToString();
            }
            catch (MySqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            
            int searchpid;
            string pnic, pname, pdob, pad, pmob, pmail;
            searchpid = int.Parse(searchpidmain.Text);
            pdob= DateTime.MinValue.ToString("yyyy/MM/dd");
            pname = patname.Text;
            pdob = date.Text;
            pad = address.Text;
            pmob = mobile.Text;
            pmail = eemail.Text;
            pnic = nicc.Text;


            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Update patient set Name='" + pname + "',NIC='" + pnic + "',DOB='" + pdob + "',Address='" + pad + "',Mobile='" + pmob + "',Email='" + pmail + "'where Id=" + searchpid + "";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");

            }
            catch (MySqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int appid;
            int patientId;
            string date, docnaame, mail;
            patientId = int.Parse(searchpidmain.Text);
            appid = int.Parse(appointid.Text);
            date = dtp2.Text;
            docnaame = docname.Text;
            mail = mail2.Text;
            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Insert into appointmentpay values(" + appid + ",'" + date + "','" + docnaame + "','" + mail + "'," + patientId + ")";
            MySqlCommand cmd = new MySqlCommand(qry, areg);

            try
            {
                areg.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appoinment added successfully.");
                emailto.Text = mail2.Text;
                emailsub.Text = "Appointment Payment Notification";
                emailbody.Text = "Appointment ID : " + appid + " \n Apppointment Date:  " + date + " \n Doctor Name:  " + docnaame + " \n Payment Status: Paid \n Thank you for the recent payment that you made on the date for the amount. This is a confirmation \n that the amount has been successfully received and deposited in our account.\n Thank You.\n MediCu Team.";
            }
            catch (MySqlException se)
            {
                MessageBox.Show(" " + se);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("medicuofficialc@gmail.com");
                msg.To.Add(emailto.Text);
                msg.Subject = emailsub.Text;
                msg.Body = emailbody.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "medicuofficialc@gmail.com";
                ntcd.Password = "medicu123";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Email sent successfully");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            patname.Text=null;
            date.Text = null;
            address.Text = null;
            mobile.Text = null;
            eemail.Text = null;
            nicc.Text = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            appointid.Text=null;
            dtp2.Text=null;
            docname.Text=null;
            mail2.Text=null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            emailto.Text=null;
            emailsub.Text=null;
            emailbody.Text=null;
        }
    }
}
