using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cricInfoSystem2
{
    public partial class Fixture : Form
    {
        public Fixture()
        {
            InitializeComponent();
        }

        private void fixtureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fixtureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet3);

        }

        private void Fixture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet3.Fixture' table. You can move, or remove it, as needed.
            this.fixtureTableAdapter.Fill(this.masterDataSet3.Fixture);

        }
    }
}
