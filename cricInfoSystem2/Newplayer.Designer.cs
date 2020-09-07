namespace cricInfoSystem2
{
    partial class Newplayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label tel_NoLabel;
            System.Windows.Forms.Label teamNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Newplayer));
            this.masterDataSet2 = new cricInfoSystem2.masterDataSet2();
            this.player_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.player_infoTableAdapter = new cricInfoSystem2.masterDataSet2TableAdapters.Player_infoTableAdapter();
            this.tableAdapterManager = new cricInfoSystem2.masterDataSet2TableAdapters.TableAdapterManager();
            this.player_infoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.player_infoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.idMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.tel_NoTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.leftRadioButton = new System.Windows.Forms.RadioButton();
            this.rightRadioButton = new System.Windows.Forms.RadioButton();
            this._Left_SpinRadioButton = new System.Windows.Forms.RadioButton();
            this.left_SpeedRadioButton = new System.Windows.Forms.RadioButton();
            this.right_SpinRadioButton = new System.Windows.Forms.RadioButton();
            this.right_SpeedRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Photobutton = new System.Windows.Forms.Button();
            this.PhotoOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.findButton = new System.Windows.Forms.Button();
            this.player_infoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.masterDataSet3 = new cricInfoSystem2.masterDataSet3();
            this.player_infoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.player_infoTableAdapter1 = new cricInfoSystem2.masterDataSet3TableAdapters.Player_infoTableAdapter();
            this.tableAdapterManager1 = new cricInfoSystem2.masterDataSet3TableAdapters.TableAdapterManager();
            this.teamNameComboBox = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            tel_NoLabel = new System.Windows.Forms.Label();
            teamNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_infoBindingNavigator)).BeginInit();
            this.player_infoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player_infoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_infoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Location = new System.Drawing.Point(48, 58);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Location = new System.Drawing.Point(48, 103);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = System.Drawing.Color.Transparent;
            ageLabel.Location = new System.Drawing.Point(48, 136);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(42, 20);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Location = new System.Drawing.Point(48, 171);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // tel_NoLabel
            // 
            tel_NoLabel.AutoSize = true;
            tel_NoLabel.BackColor = System.Drawing.Color.Transparent;
            tel_NoLabel.Location = new System.Drawing.Point(48, 210);
            tel_NoLabel.Name = "tel_NoLabel";
            tel_NoLabel.Size = new System.Drawing.Size(58, 20);
            tel_NoLabel.TabIndex = 9;
            tel_NoLabel.Text = "Tel No:";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new System.Drawing.Point(48, 248);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(99, 20);
            teamNameLabel.TabIndex = 28;
            teamNameLabel.Text = "Team Name:";
            // 
            // masterDataSet2
            // 
            this.masterDataSet2.DataSetName = "masterDataSet2";
            this.masterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // player_infoBindingSource
            // 
            this.player_infoBindingSource.DataMember = "Player_info";
            this.player_infoBindingSource.DataSource = this.masterDataSet2;
            // 
            // player_infoTableAdapter
            // 
            this.player_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Player_infoTableAdapter = this.player_infoTableAdapter;
            this.tableAdapterManager.UpdateOrder = cricInfoSystem2.masterDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // player_infoBindingNavigator
            // 
            this.player_infoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.player_infoBindingNavigator.BindingSource = this.player_infoBindingSource;
            this.player_infoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.player_infoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.player_infoBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.player_infoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.player_infoBindingNavigatorSaveItem,
            this.bindingNavigatorCancelItem});
            this.player_infoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.player_infoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.player_infoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.player_infoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.player_infoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.player_infoBindingNavigator.Name = "player_infoBindingNavigator";
            this.player_infoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.player_infoBindingNavigator.Size = new System.Drawing.Size(668, 38);
            this.player_infoBindingNavigator.TabIndex = 0;
            this.player_infoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // player_infoBindingNavigatorSaveItem
            // 
            this.player_infoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.player_infoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("player_infoBindingNavigatorSaveItem.Image")));
            this.player_infoBindingNavigatorSaveItem.Name = "player_infoBindingNavigatorSaveItem";
            this.player_infoBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.player_infoBindingNavigatorSaveItem.Text = "Save Data";
            this.player_infoBindingNavigatorSaveItem.Click += new System.EventHandler(this.player_infoBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCancelItem
            // 
            this.bindingNavigatorCancelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancelItem.Image")));
            this.bindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelItem.Name = "bindingNavigatorCancelItem";
            this.bindingNavigatorCancelItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorCancelItem.Text = "CancelUpdate";
            this.bindingNavigatorCancelItem.Click += new System.EventHandler(this.bindingNavigatorCancelItem_Click);
            // 
            // idMaskedTextBox
            // 
            this.idMaskedTextBox.BackColor = System.Drawing.Color.Beige;
            this.idMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.player_infoBindingSource, "Id", true));
            this.idMaskedTextBox.Location = new System.Drawing.Point(159, 58);
            this.idMaskedTextBox.Mask = "NB-000";
            this.idMaskedTextBox.Name = "idMaskedTextBox";
            this.idMaskedTextBox.Size = new System.Drawing.Size(104, 26);
            this.idMaskedTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.player_infoBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(159, 97);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(192, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.player_infoBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(159, 130);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(104, 26);
            this.ageTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.player_infoBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(159, 171);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(192, 26);
            this.addressTextBox.TabIndex = 8;
            // 
            // tel_NoTextBox
            // 
            this.tel_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.player_infoBindingSource, "Tel_No", true));
            this.tel_NoTextBox.Location = new System.Drawing.Point(159, 210);
            this.tel_NoTextBox.Name = "tel_NoTextBox";
            this.tel_NoTextBox.Size = new System.Drawing.Size(192, 26);
            this.tel_NoTextBox.TabIndex = 10;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.White;
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.player_infoBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(470, 50);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(178, 309);
            this.photoPictureBox.TabIndex = 12;
            this.photoPictureBox.TabStop = false;
            // 
            // leftRadioButton
            // 
            this.leftRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.player_infoBindingSource, "Left", true));
            this.leftRadioButton.Location = new System.Drawing.Point(48, 25);
            this.leftRadioButton.Name = "leftRadioButton";
            this.leftRadioButton.Size = new System.Drawing.Size(104, 24);
            this.leftRadioButton.TabIndex = 14;
            this.leftRadioButton.TabStop = true;
            this.leftRadioButton.Text = "Left";
            this.leftRadioButton.UseVisualStyleBackColor = true;
            // 
            // rightRadioButton
            // 
            this.rightRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.player_infoBindingSource, "Right", true));
            this.rightRadioButton.Location = new System.Drawing.Point(48, 55);
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.Size = new System.Drawing.Size(104, 24);
            this.rightRadioButton.TabIndex = 16;
            this.rightRadioButton.TabStop = true;
            this.rightRadioButton.Text = "Right";
            this.rightRadioButton.UseVisualStyleBackColor = true;
            // 
            // _Left_SpinRadioButton
            // 
            this._Left_SpinRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.player_infoBindingSource, " Left Spin", true));
            this._Left_SpinRadioButton.Location = new System.Drawing.Point(50, 38);
            this._Left_SpinRadioButton.Name = "_Left_SpinRadioButton";
            this._Left_SpinRadioButton.Size = new System.Drawing.Size(131, 24);
            this._Left_SpinRadioButton.TabIndex = 18;
            this._Left_SpinRadioButton.TabStop = true;
            this._Left_SpinRadioButton.Text = "LeftSpin";
            this._Left_SpinRadioButton.UseVisualStyleBackColor = true;
            // 
            // left_SpeedRadioButton
            // 
            this.left_SpeedRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.player_infoBindingSource, "Left Speed", true));
            this.left_SpeedRadioButton.Location = new System.Drawing.Point(50, 68);
            this.left_SpeedRadioButton.Name = "left_SpeedRadioButton";
            this.left_SpeedRadioButton.Size = new System.Drawing.Size(131, 24);
            this.left_SpeedRadioButton.TabIndex = 20;
            this.left_SpeedRadioButton.TabStop = true;
            this.left_SpeedRadioButton.Text = "LeftSpeed";
            this.left_SpeedRadioButton.UseVisualStyleBackColor = true;
            this.left_SpeedRadioButton.CheckedChanged += new System.EventHandler(this.left_SpeedRadioButton_CheckedChanged);
            // 
            // right_SpinRadioButton
            // 
            this.right_SpinRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.player_infoBindingSource, "Right Spin", true));
            this.right_SpinRadioButton.Location = new System.Drawing.Point(50, 98);
            this.right_SpinRadioButton.Name = "right_SpinRadioButton";
            this.right_SpinRadioButton.Size = new System.Drawing.Size(131, 24);
            this.right_SpinRadioButton.TabIndex = 22;
            this.right_SpinRadioButton.TabStop = true;
            this.right_SpinRadioButton.Text = "RightSpin";
            this.right_SpinRadioButton.UseVisualStyleBackColor = true;
            // 
            // right_SpeedRadioButton
            // 
            this.right_SpeedRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.player_infoBindingSource, "Right Speed", true));
            this.right_SpeedRadioButton.Location = new System.Drawing.Point(50, 128);
            this.right_SpeedRadioButton.Name = "right_SpeedRadioButton";
            this.right_SpeedRadioButton.Size = new System.Drawing.Size(131, 24);
            this.right_SpeedRadioButton.TabIndex = 24;
            this.right_SpeedRadioButton.TabStop = true;
            this.right_SpeedRadioButton.Text = "RightSpeed";
            this.right_SpeedRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this._Left_SpinRadioButton);
            this.groupBox1.Controls.Add(this.left_SpeedRadioButton);
            this.groupBox1.Controls.Add(this.right_SpinRadioButton);
            this.groupBox1.Controls.Add(this.right_SpeedRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(227, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 166);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BowlingStyle";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.leftRadioButton);
            this.groupBox2.Controls.Add(this.rightRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(21, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BattingStyle";
            // 
            // Photobutton
            // 
            this.Photobutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Photobutton.Location = new System.Drawing.Point(573, 389);
            this.Photobutton.Name = "Photobutton";
            this.Photobutton.Size = new System.Drawing.Size(75, 34);
            this.Photobutton.TabIndex = 27;
            this.Photobutton.Text = "Photo..";
            this.Photobutton.UseVisualStyleBackColor = false;
            this.Photobutton.Click += new System.EventHandler(this.Photobutton_Click);
            // 
            // PhotoOpenDialog
            // 
            this.PhotoOpenDialog.FileName = "openFileDialog1";
            this.PhotoOpenDialog.Filter = "Images Files|*.bmp;*.jpg;*.gif;*.png";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.Transparent;
            this.findButton.Location = new System.Drawing.Point(290, 55);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 36);
            this.findButton.TabIndex = 28;
            this.findButton.Text = "Find..";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // player_infoDataGridView
            // 
            this.player_infoDataGridView.AllowUserToAddRows = false;
            this.player_infoDataGridView.AllowUserToDeleteRows = false;
            this.player_infoDataGridView.AutoGenerateColumns = false;
            this.player_infoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.player_infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.player_infoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6});
            this.player_infoDataGridView.DataSource = this.player_infoBindingSource;
            this.player_infoDataGridView.Location = new System.Drawing.Point(21, 468);
            this.player_infoDataGridView.Name = "player_infoDataGridView";
            this.player_infoDataGridView.ReadOnly = true;
            this.player_infoDataGridView.RowHeadersWidth = 62;
            this.player_infoDataGridView.RowTemplate.Height = 28;
            this.player_infoDataGridView.Size = new System.Drawing.Size(614, 220);
            this.player_infoDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 59;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 87;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn3.HeaderText = "Age";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 104;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tel_No";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tel_No";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 95;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Photo";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 57;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Left";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Left";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 43;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Right";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Right";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 53;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = " Left Spin";
            this.dataGridViewCheckBoxColumn3.HeaderText = " Left Spin";
            this.dataGridViewCheckBoxColumn3.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 83;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Left Speed";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Left Speed";
            this.dataGridViewCheckBoxColumn4.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Width = 94;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "Right Spin";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Right Spin";
            this.dataGridViewCheckBoxColumn5.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.ReadOnly = true;
            this.dataGridViewCheckBoxColumn5.Width = 89;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "Right Speed";
            this.dataGridViewCheckBoxColumn6.HeaderText = "Right Speed";
            this.dataGridViewCheckBoxColumn6.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.ReadOnly = true;
            this.dataGridViewCheckBoxColumn6.Width = 104;
            // 
            // masterDataSet3
            // 
            this.masterDataSet3.DataSetName = "masterDataSet3";
            this.masterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // player_infoBindingSource1
            // 
            this.player_infoBindingSource1.DataMember = "Player_info";
            this.player_infoBindingSource1.DataSource = this.masterDataSet3;
            // 
            // player_infoTableAdapter1
            // 
            this.player_infoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.FixtureTableAdapter = null;
            this.tableAdapterManager1.LogInTableAdapter = null;
            this.tableAdapterManager1.Player_infoTableAdapter = this.player_infoTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = cricInfoSystem2.masterDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teamNameComboBox
            // 
            this.teamNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.player_infoBindingSource1, "TeamName", true));
            this.teamNameComboBox.FormattingEnabled = true;
            this.teamNameComboBox.Items.AddRange(new object[] {
            "VadaStrikers",
            "AriyaalaiKillaadi 100",
            "Lightning Hawks",
            "Nallur JollyFriends",
            "PointPedro Samuraai",
            "Valvai Blues",
            "InuvilUnitedStars",
            "JaffnaRoyals",
            "JuraSuperKings",
            "TamilStarsDortmand"});
            this.teamNameComboBox.Location = new System.Drawing.Point(160, 240);
            this.teamNameComboBox.Name = "teamNameComboBox";
            this.teamNameComboBox.Size = new System.Drawing.Size(121, 28);
            this.teamNameComboBox.TabIndex = 29;
            // 
            // Newplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(668, 720);
            this.Controls.Add(teamNameLabel);
            this.Controls.Add(this.teamNameComboBox);
            this.Controls.Add(this.player_infoDataGridView);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.Photobutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idMaskedTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(tel_NoLabel);
            this.Controls.Add(this.tel_NoTextBox);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.player_infoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Newplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newplayer";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Newplayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_infoBindingNavigator)).EndInit();
            this.player_infoBindingNavigator.ResumeLayout(false);
            this.player_infoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player_infoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_infoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet2 masterDataSet2;
        private System.Windows.Forms.BindingSource player_infoBindingSource;
        private masterDataSet2TableAdapters.Player_infoTableAdapter player_infoTableAdapter;
        private masterDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator player_infoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton player_infoBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox idMaskedTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox tel_NoTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.RadioButton leftRadioButton;
        private System.Windows.Forms.RadioButton rightRadioButton;
        private System.Windows.Forms.RadioButton _Left_SpinRadioButton;
        private System.Windows.Forms.RadioButton left_SpeedRadioButton;
        private System.Windows.Forms.RadioButton right_SpinRadioButton;
        private System.Windows.Forms.RadioButton right_SpeedRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Photobutton;
        private System.Windows.Forms.OpenFileDialog PhotoOpenDialog;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridView player_infoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private masterDataSet3 masterDataSet3;
        private System.Windows.Forms.BindingSource player_infoBindingSource1;
        private masterDataSet3TableAdapters.Player_infoTableAdapter player_infoTableAdapter1;
        private masterDataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox teamNameComboBox;
    }
}