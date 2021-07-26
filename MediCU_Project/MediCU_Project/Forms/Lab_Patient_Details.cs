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
    public partial class Lab_Patient_Details : Form
    {
        public Lab_Patient_Details()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            int pid;
            string agee;
            pid = int.Parse(patientid.Text);
            agee = age.Text;


            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry = "Select Name,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS Age from patient where Id=" + pid + "";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            try
            {
                con.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                name.Text = sdr["Name"].ToString();
                age.Text = sdr["Age"].ToString();
            }
            catch (MySqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(patientid.Text);
            string constring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;";
            string getquery = "Select TestName from labreports where id=" + id + " ";
            MySqlDataAdapter ad = new MySqlDataAdapter(getquery, constring);
            DataSet ds = new DataSet();
            ad.Fill(ds, "labreports");
            labtests.DataSource = ds.Tables["labreports"];

            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            cb.HeaderText = "Select";
            cb.Width = 25;
            cb.Name = "selectbox";
            cb.DefaultCellStyle.BackColor = Color.Red;
            labtests.Columns.Insert(0, cb);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drv in labtests.Rows)
            {
                bool cbselect = Convert.ToBoolean(drv.Cells["selectbox"].Value);
                if (cbselect)
                {

                    tn.Text = drv.Cells[1].Value.ToString();


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labtests.DataSource = null;
            labtests.Columns.RemoveAt(labtests.Columns.Count - 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float result = Convert.ToSingle(p.Text);
            p.Text = result.ToString();
            dt.Rows.Add(tn.Text, p.Text);
            choosetests.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tn.Text = null;
            p.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float sum = 0;
            for (int i = 0; i < choosetests.Rows.Count; ++i)
            {
                sum += Convert.ToSingle(choosetests.Rows[i].Cells[1].Value);
            }
            getTotal.Text = sum.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String test = DateTime.Now.ToString("dd.MM.yyy");
            e.Graphics.DrawString("Lab Invoice", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("ID", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 100));
            e.Graphics.DrawString(patientid.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 100));
            e.Graphics.DrawString("Name", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 150));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 150));
            e.Graphics.DrawString(name.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 150));
            e.Graphics.DrawString("Age", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 200));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 200));
            e.Graphics.DrawString(age.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 200));
            e.Graphics.DrawString("Date", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 250));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 250));
            e.Graphics.DrawString(test, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 250));
            e.Graphics.DrawString("Total", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 300));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 300));
            e.Graphics.DrawString("LKR", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString(getTotal.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(250, 300));



            Bitmap bm = new Bitmap(this.choosetests.Width, this.choosetests.Height);
            choosetests.DrawToBitmap(bm, new Rectangle(0, 0, this.choosetests.Width, this.choosetests.Height));
            e.Graphics.DrawImage(bm, 200, 400);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void labtests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void Lab_Patient_Details_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Test_Name", typeof(string)); 
            dt.Columns.Add("Price", typeof(string));


            choosetests.DataSource = dt; 
        }

        private void choosetests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
