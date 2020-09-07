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
    public partial class Batsman_details : Form
    {
        public Batsman_details()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Batsman_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet10.Player_info' table. You can move, or remove it, as needed.
            this.player_infoTableAdapter.Fill(this.masterDataSet10.Player_info);
            // TODO: This line of code loads data into the 'masterDataSet9.Fixture' table. You can move, or remove it, as needed.
            this.fixtureTableAdapter.Fill(this.masterDataSet9.Fixture);

        }
    }
}
