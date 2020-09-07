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
    public partial class Newplayer : Form
    {
        public Newplayer()
        {
            InitializeComponent();
        }

        private void player_infoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.player_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet2);

        }

        private void Newplayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet3.Player_info' table. You can move, or remove it, as needed.
            this.player_infoTableAdapter1.Fill(this.masterDataSet3.Player_info);
            // TODO: This line of code loads data into the 'masterDataSet2.Player_info' table. You can move, or remove it, as needed.
            this.player_infoTableAdapter.Fill(this.masterDataSet2.Player_info);
            masterDataSet2.Player_info.LeftColumn.DefaultValue = false;
            masterDataSet2.Player_info.RightColumn.DefaultValue = true;
            masterDataSet2.Player_info._Left_SpinColumn.DefaultValue = false;
            masterDataSet2.Player_info.Left_SpeedColumn.DefaultValue = false;
            masterDataSet2.Player_info.Right_SpinColumn.DefaultValue = true;
            masterDataSet2.Player_info.Right_SpeedColumn.DefaultValue = false;


        }

        private void left_SpeedRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Photobutton_Click(object sender, EventArgs e)
        {
            PhotoOpenDialog.FileName = "";
            if (PhotoOpenDialog.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(PhotoOpenDialog.FileName);
            }  
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            player_infoBindingSource.CancelEdit();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string value;
            int index;
            value = Microsoft.VisualBasic.Interaction.InputBox("Id.", "Find Player");
            index = player_infoBindingSource.Find("Id", value);
            player_infoBindingSource.Position = index;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                idMaskedTextBox.Text = "";
            }catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
           









        }
    }
}
