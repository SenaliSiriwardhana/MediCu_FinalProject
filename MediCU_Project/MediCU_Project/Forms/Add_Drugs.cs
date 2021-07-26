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
    public partial class Add_Drugs : Form
    {
        public Add_Drugs()
        {
            InitializeComponent();
        }

        private void Add_Drugs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int quantity;
            float price;
            name = dname.Text;
            quantity = int.Parse(dq.Text);
            price = float.Parse(dprice.Text);
            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry = "Insert into pharmacydrugstore Values(NULL,'"+name+"',"+price+","+quantity+")";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Drug added.");
            }
            catch(MySqlException se)
            {
                MessageBox.Show("" + se);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int uid = int.Parse(id.Text); ;
            string n=name.Text;
            int q = int.Parse(quantity.Text); ;
            float up = float.Parse(uprice.Text); ;
         
            MySqlConnection areg = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=database1;");
            string qry = "Update pharmacydrugstore set Drugname='" + n + "',Unitprice='" + up + "',Quantity='" +q + "' where phdrugstoreid=" + uid + " ";
            MySqlCommand cmd = new MySqlCommand(qry, areg);

            try
            {

                areg.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update drugs Successfully.");

            }


            catch (MySqlException se)
            {
                MessageBox.Show(" " + se);
            }
        }
    }
}
