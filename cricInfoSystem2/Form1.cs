using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cricInfoSystem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From LogIn where Username='" + textBox2.Text + "' and Password='" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Menu ss = new Menu();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Pease enter valid username & password!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
