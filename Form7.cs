using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.IO;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {


                string DbConn = "datasource=localhost;port=3306;username=root;password=";


                string Query = "INSERT INTO sports.teams (`TEAM NAME`, `TEAM ID`,`NUMBER OF PRAYERS`) VALUES ('" + this.txtTeam.Text + "', '" + this.txtTeamId.Text + "','" + this.txtPlayers.Text + "');";


                MySqlConnection MyConn2 = new MySqlConnection(DbConn);


                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Team Added Successfully!");
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
                string Query = "delete from sports.teams where ID='" + this.txtId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(DbConn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Team Trashed");
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


                string Query = "UPDATE sports.teams SET  `TEAM NAME`='"+this.txtTeam.Text+"', `TEAM ID`='"+this.txtTeamId.Text+"', `NUMBER OF PRAYERS`='"+this.txtPlayers+"' WHERE ID='"+this.txtId.Text+"';";


                MySqlConnection MyConn2 = new MySqlConnection(DbConn);


                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Team Updated Succesfully!");
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
                string Query = "select * from sports.teams;";
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
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
