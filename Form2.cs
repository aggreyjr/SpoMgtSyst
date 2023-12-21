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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void looutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 frm7=new Form7();
            frm7.ShowDialog();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void teamRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            MessageBox.Show("Logged Out Successfully");
        }
    }
}
