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

namespace MediCU_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password, type;
            int id;
            id = int.Parse(RegNo.Text);
            int docid;
            docid = int.Parse(RegNo.Text);
            password = Pw.Text;
            type = AccType.GetItemText(AccType.SelectedItem);
            


            if (type == "Admin")
            {
                MySqlConnection lcon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
                string lqry = "Select * from admin where AdminId=" + id + " and Password='" + password + "'";
                MySqlDataAdapter ad = new MySqlDataAdapter(lqry, lcon);
                DataSet ds = new DataSet();
                ad.Fill(ds, "admin");
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    Form2 f2 = new Form2(id);
                    f2.Show();
                    this.Hide();
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please Fill Required fields. ");
                }
                else
                {
                    MessageBox.Show("Login failed. Please recheck your ID, Password and Account Type. ");
                }
            }
            

            
            else if (type == "Doctor")
            {
                MySqlConnection lcon = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
                string lqry = "Select * from doctor where DoctorId=" + id + " and Password='" + password + "'";
                MySqlDataAdapter ad = new MySqlDataAdapter(lqry, lcon);
                DataSet ds = new DataSet();
                ad.Fill(ds, "doctor");
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    Forms.MediCuDoctor d = new Forms.MediCuDoctor(docid);
                    d.Show();
                    this.Hide();
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please Fill Required fields. ");
                }
                else
                {
                    MessageBox.Show("Login failed. Please recheck your ID, Password and Account Type. ");
                }
            }
            

            else if (type == "Laboratory")
            {
                MySqlConnection lcon3 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
                string lqry3 = "Select * from lab where labid=" + id + " and password='" + password + "'";
                MySqlDataAdapter ad3 = new MySqlDataAdapter(lqry3, lcon3);
                DataSet ds3 = new DataSet();
                ad3.Fill(ds3, "lab");
                int k = ds3.Tables[0].Rows.Count;
                if (k > 0)
                {
                    Forms.MediCuLaboratory mcl = new Forms.MediCuLaboratory(id);
                    mcl.Show();
                    this.Hide();
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please Fill Required fields. ");
                }
                else
                {
                    MessageBox.Show("Login failed. Please recheck your ID, Password and Account Type. ");
                }
            }
            else if (type == "Pharmacy")
            {
                MySqlConnection lcon4 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
                string lqry4 = "Select * from pharmacy where Phaid=" + id + " and Password='"+password+"'";
                MySqlDataAdapter ad4 = new MySqlDataAdapter(lqry4, lcon4);
                DataSet ds4 = new DataSet();
                ad4.Fill(ds4, "pharmacy");
                int l = ds4.Tables[0].Rows.Count;
                if (l > 0)
                {
                    Forms.MediCuPharmacyPanel mp = new Forms.MediCuPharmacyPanel(id);
                    mp.Show();
                    this.Hide();
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please Fill Required fields. ");
                }
                else
                {
                    MessageBox.Show("Login failed. Please recheck your ID, Password and Account Type. ");
                }
                
            }
            else
            {
                MySqlConnection lcon5 = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;convert zero datetime=True");
                string lqry5 = "Select * from receptionist where RecId=" + id + " and Password='" + password + "'";
                MySqlDataAdapter ad5 = new MySqlDataAdapter(lqry5, lcon5);
                DataSet ds5 = new DataSet();
                ad5.Fill(ds5, "receptionist");
                int m = ds5.Tables[0].Rows.Count;
                if (m > 0)
                {
                    Forms.MediCuReceptionist mcr = new Forms.MediCuReceptionist(id);
                    mcr.Show();
                    this.Hide();
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please Fill Required fields. ");
                }
                else
                {
                    MessageBox.Show("Login failed. Please recheck your ID, Password and Account Type. ");
                }
                
            }
            
        }
    }
}
