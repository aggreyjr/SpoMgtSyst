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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string DbConn = "datasource=localhost;port=3306;username=root;password=";


                string Query = "INSERT INTO sports.results (`GAME`, `GAME DATE`,`OVERALL RESULTS`,`LOCATION`,`TEAMS IN ACTION`,`TIME`) VALUES ('" + this.txtGame.Text + "', '" + this.txtDate.Text + "', '" + this.txtResult.Text + "','" + this.txtLocation.Text + "','" + this.txtTeams.Text + "','" + this.txtTime.Text + "');";


                MySqlConnection MyConn2 = new MySqlConnection(DbConn);


                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Info Added Successfully!");
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


                string Query = "UPDATE sports.results SET `GAME`='"+this.txtGame.Text+"', `GAME DATE`='"+this.txtDate.Text+"', `OVERALL RESULTS`='"+this.txtResult.Text+"', `LOCATION`='"+this.txtLocation.Text+"', `TEAMS IN ACTION`='"+this.txtTeams.Text+"', `TIME`='"+this.txtTime.Text+"' WHERE `ID`='"+this.txtId.Text+"';";


                MySqlConnection MyConn2 = new MySqlConnection(DbConn);


                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Info Updated!");
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
                string Query = "delete from sports.results where ID='" + this.txtId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(DbConn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Info Deleted!");
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
                string Query = "select * from sports.results;";
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
