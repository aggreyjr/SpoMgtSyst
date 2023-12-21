namespace sportmanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" && txtPassword.Text == "")
            {
                MessageBox.Show("Don't Leave Any field Unfilled");
            }
           else if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin")
            {
                MessageBox.Show("Logged In as Admin");
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            else if (txtUsername.Text == "Usjm" && txtPassword.Text == "Usjm")
            {
                MessageBox.Show("Welcome to User Pool");
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Try Again Crefully!");
            }
        }
    }
}