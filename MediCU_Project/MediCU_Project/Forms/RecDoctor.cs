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
    public partial class RecDoctor : Form
    {
        public RecDoctor()
        {
            InitializeComponent();
            Fillcombo();
            Fillcombo2();
        }
        void Fillcombo()
        {
            MySqlConnection scon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Select * from doctor";
            MySqlCommand cmd = new MySqlCommand(qry, scon);
            MySqlDataReader sdr;
            try
            {
                scon.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string dbcolname = sdr["Specialization"].ToString();
                    docsp.Items.Add(dbcolname);
                    
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
            }
        }
        void Fillcombo2()
        {
            
        }
            
            
        

        private void RecDoctor_Load(object sender, EventArgs e)
        {

        }

        private void docsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getspec= docsp.GetItemText(docsp.SelectedItem);
            MySqlConnection scon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Select * from doctor where Specialization='"+getspec+"'";
            MySqlCommand cmd = new MySqlCommand(qry, scon);
            MySqlDataReader sdr;
            try
            {
                scon.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string dbcolname = sdr["FullName"].ToString();
                    dname.Items.Add(dbcolname);
                    dname.Items.Remove(dname.SelectedItem);


                }
                
            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void dname_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string getdocname = dname.GetItemText(dname.SelectedItem);
            

            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry= "SELECT * FROM doctor WHERE FullName = '" + dname.Text+"'";
   
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader sdr;
            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    did.Text = sdr["DoctorId"].ToString();
                    days.Text = sdr["AvailableDates"].ToString();
                    atime.Text = sdr["ArrivalTimeFrom"].ToString();
                    deptime.Text = sdr["ArrivalTimeTo"].ToString();
                    DateTime t1=DateTime.Parse(atime.Text);
                    //DateTime.TryParse(atime.Text,out t1);
                    DateTime t2=DateTime.Parse(deptime.Text);
                    //DateTime.TryParse(deptime.Text, out t2);
                    TimeSpan ts = (t2 - t1);
                    time.Text = ts.ToString();
                    



                }
               
            }
            catch (MySqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void checkcount_Click(object sender, EventArgs e)
        {
            int getdocid = int.Parse(did.Text);

            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
            string qry = "Select count(DoctorId) as pcount from appointment where DoctorId='"+getdocid+"'";

            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader sdr;
            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                   patcount.Text = sdr["pcount"].ToString();
                    
                }

            }
            catch (MySqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void did_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float result = Convert.ToInt32(patcount.Text) * Convert.ToSingle(fee.Text);
            amount.Text = result.ToString();
        }
    }

}
