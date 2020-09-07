using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace cricInfoSystem2
{
    public partial class Scorecard : Form
    {
        public Scorecard()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
       

        void connectDatabase()
        {
            con.ConnectionString = @"Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            cmd.Connection = con;
        }

        private void Scorecard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet4.Fixture' table. You can move, or remove it, as needed.
            this.fixtureTableAdapter1.Fill(this.masterDataSet4.Fixture);
            // TODO: This line of code loads data into the 'masterDataSet3.Fixture' table. You can move, or remove it, as needed.
            this.fixtureTableAdapter.Fill(this.masterDataSet3.Fixture);
            // TODO: This line of code loads data into the 'masterDataSet4.Scorecard' table. You can move, or remove it, as needed.
            this.scorecardTableAdapter.Fill(this.masterDataSet4.Scorecard);
            // TODO: This line of code loads data into the 'masterDataSet4.Scorecard' table. You can move, or remove it, as needed.
            this.scorecardTableAdapter.Fill(this.masterDataSet4.Scorecard);
            // TODO: This line of code loads data into the 'masterDataSet3.Fixture' table. You can move, or remove it, as needed.
            

        }

        private void fixtureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void scorecardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scorecardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet4);

        }

        private void scorecardBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.scorecardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet4);

        }

        
    }
}
