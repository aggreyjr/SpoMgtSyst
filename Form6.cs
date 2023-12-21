using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportmanagement
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string DbConn = "datasource=localhost;port=3306;username=root;password=";
                //Data Display query
                string Query = "select * from sports.inventory;";
                MySqlConnection MyConn2 = new MySqlConnection(DbConn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string DbConn = "datasource=localhost;port=3306;username=root;password=";


                string Query = "INSERT INTO sports.inventory (`ITEM`, `REG DATE`,`ITEM NO`,`USE.`,`NO OF ITEMS`) VALUES ('" + this.txtItem.Text + "', '" + this.txtDate.Text + "','" + this.txtNo.Text + "','" + this.txtUse.Text + "','" + this.txtAmount.Text + "');";


                MySqlConnection MyConn2 = new MySqlConnection(DbConn);


                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Inventory Added Successfully!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                string DbConn = "datasource=localhost;port=3306;username=root;password=";


                string Query = "UPDATE sports.inventory SET `ITEM`='"+this.txtItem.Text+"', `REG DATE`='"+this.txtDate.Text+"', `ITEM NO`='"+this.txtNo.Text+"', `USE.`='"+this.txtUse.Text+"', `NO OF ITEMS`='"+this.txtAmount.Text+"' WHERE ID='"+this.txtId.Text+"';";


                MySqlConnection MyConn2 = new MySqlConnection(DbConn);


                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Invetory Updated Succesfully!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string DbConn = "datasource=localhost;port=3306;username=root;password=";
                string Query = "delete from sports.inventory where ID='" + this.txtId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(DbConn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Inventory Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(); 
            form2.ShowDialog();
        }
    }
}
