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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {


                string DbConn = "datasource=localhost;port=3306;username=root;password=";


                string Query = "INSERT INTO sports.players (`NAME`, `CONTACT`,`AGE`,`WEIGHT`,`EMAIL`,`COURSE`,`NIN`) VALUES ('" + this.txtName.Text + "', '" + this.txtContact.Text + "', '" + this.txtAge.Text + "','" + this.txtWeight.Text +"','"+this.txtEmail.Text+"','"+this.txtCourse.Text+"','"+this.txtNin.Text+"');";


                MySqlConnection MyConn2 = new MySqlConnection(DbConn);


                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here the query is executed and posted into the database.
                MessageBox.Show("Player Added!");
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string DbConn = "datasource=localhost;port=3306;username=root;password=";
                //Data Display query
                string Query = "select * from sports.players;";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string DbConn = "datasource=localhost;port=3306;username=root;password=";
                string Query = "delete from sports.players where ID='" + this.txtId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(DbConn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Player Terminated");
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


                string Query = "UPDATE sports.players SET  `NAME`='" + this.txtName.Text+"', `CONTACT`='"+this.txtContact.Text+"', `AGE`='"+this.txtAge.Text+"', `WEIGHT`='"+this.txtWeight.Text+"', `EMAIL`='"+this.txtEmail.Text+"', `COURSE`='"+this.txtCourse.Text+"', `NIN`='"+this.txtNin.Text+"' WHERE `ID`='" + this.txtId.Text + "';";


                MySqlConnection MyConn2 = new MySqlConnection(DbConn);


                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Invetory Item Updated Succesfully!");
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
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
