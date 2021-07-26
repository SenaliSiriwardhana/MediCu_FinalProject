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
    public partial class Pharmacy_Patient_Details : Form
    {
        public Pharmacy_Patient_Details()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pid;
            string agee;
            pid = int.Parse(ID.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(ID.Text);
            string constring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;";
            string getquery = "Select DrugName,Quantity from pharmacyinvoices where PatientId=" + id + " ";
            MySqlDataAdapter ad = new MySqlDataAdapter(getquery, constring);
            DataSet ds = new DataSet();
            ad.Fill(ds, "pharmacyinvoices");
            dgvp.DataSource = ds.Tables["pharmacyinvoices"];

            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            cb.HeaderText = "Select";
            cb.Width = 25;
            cb.Name = "selectbox";
            cb.DefaultCellStyle.BackColor = Color.Red;
            dgvp.Columns.Insert(0, cb);





        }

        private void button2_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow drv in dgvp.Rows)
            {
                bool cbselect = Convert.ToBoolean(drv.Cells["selectbox"].Value);
                if (cbselect)
                {

                    n.Text = drv.Cells[1].Value.ToString();
                    q.Text = drv.Cells[2].Value.ToString();
                    
                }

            }



        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            float result = Convert.ToInt32(q.Text) * Convert.ToSingle(p.Text);
            st.Text = result.ToString();
            dt.Rows.Add(n.Text, q.Text, p.Text, result);
            dgv3.DataSource = dt;
            
        }


        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgv2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pharmacy_Patient_Details_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("UnitPrice", typeof(string));
            dt.Columns.Add("Amount", typeof(string));

            dgv3.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n.Text = null;
            q.Text = null;
            p.Text = null;
            st.Text = null;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dgvp.DataSource = null;
            dgvp.Columns.RemoveAt(dgvp.Columns.Count - 1);

        }

        private void dgvp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dgvp.Rows[index];
            n.Text = selectedrow.Cells[0].Value.ToString();
            q.Text = selectedrow.Cells[1].Value.ToString();

        }

        private void getTotal_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            float sum = 0;
            for (int i = 0; i < dgv3.Rows.Count; ++i)
            {
                sum += Convert.ToSingle(dgv3.Rows[i].Cells[3].Value);
            }
            getTotal.Text = sum.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            e.Graphics.DrawString("Pharmacy Invoice", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("ID", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 100));
            e.Graphics.DrawString(ID.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 100));
            e.Graphics.DrawString("Name", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 150));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 150));
            e.Graphics.DrawString(name.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 150));
            e.Graphics.DrawString("Age", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 200));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 200));
            e.Graphics.DrawString(age.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 200));
            e.Graphics.DrawString("Date", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 250));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 250));
            e.Graphics.DrawString(thisDay.ToString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 250));
            e.Graphics.DrawString("Total", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 300));
            e.Graphics.DrawString(":", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 300));
            e.Graphics.DrawString("LKR", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString(getTotal.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(250, 300));



            Bitmap bm = new Bitmap(this.dgv3.Width, this.dgv3.Height);
            dgv3.DrawToBitmap(bm, new Rectangle(0, 0, this.dgv3.Width, this.dgv3.Height));
            e.Graphics.DrawImage(bm, 200, 400);

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void dgvp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
    }
