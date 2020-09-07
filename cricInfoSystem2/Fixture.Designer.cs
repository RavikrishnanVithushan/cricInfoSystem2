namespace cricInfoSystem2
{
    partial class Fixture
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
            System.Windows.Forms.Label match_NoLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label team_1NameLabel;
            System.Windows.Forms.Label team_2NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fixture));
            this.masterDataSet3 = new cricInfoSystem2.masterDataSet3();
            this.fixtureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fixtureTableAdapter = new cricInfoSystem2.masterDataSet3TableAdapters.FixtureTableAdapter();
            this.tableAdapterManager = new cricInfoSystem2.masterDataSet3TableAdapters.TableAdapterManager();
            this.fixtureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fixtureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.match_NoTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.team_1NameComboBox = new System.Windows.Forms.ComboBox();
            this.team_2NameComboBox = new System.Windows.Forms.ComboBox();
            this.fixtureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            match_NoLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            team_1NameLabel = new System.Windows.Forms.Label();
            team_2NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixtureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixtureBindingNavigator)).BeginInit();
            this.fixtureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixtureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // match_NoLabel
            // 
            match_NoLabel.AutoSize = true;
            match_NoLabel.Location = new System.Drawing.Point(48, 58);
            match_NoLabel.Name = "match_NoLabel";
            match_NoLabel.Size = new System.Drawing.Size(81, 20);
            match_NoLabel.TabIndex = 1;
            match_NoLabel.Text = "Match No:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(48, 91);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(48, 20);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // team_1NameLabel
            // 
            team_1NameLabel.AutoSize = true;
            team_1NameLabel.Location = new System.Drawing.Point(48, 122);
            team_1NameLabel.Name = "team_1NameLabel";
            team_1NameLabel.Size = new System.Drawing.Size(108, 20);
            team_1NameLabel.TabIndex = 5;
            team_1NameLabel.Text = "Team 1Name:";
            // 
            // team_2NameLabel
            // 
            team_2NameLabel.AutoSize = true;
            team_2NameLabel.Location = new System.Drawing.Point(48, 156);
            team_2NameLabel.Name = "team_2NameLabel";
            team_2NameLabel.Size = new System.Drawing.Size(108, 20);
            team_2NameLabel.TabIndex = 7;
            team_2NameLabel.Text = "Team 2Name:";
            // 
            // masterDataSet3
            // 
            this.masterDataSet3.DataSetName = "masterDataSet3";
            this.masterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fixtureBindingSource
            // 
            this.fixtureBindingSource.DataMember = "Fixture";
            this.fixtureBindingSource.DataSource = this.masterDataSet3;
            // 
            // fixtureTableAdapter
            // 
            this.fixtureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FixtureTableAdapter = this.fixtureTableAdapter;
            this.tableAdapterManager.LogInTableAdapter = null;
            this.tableAdapterManager.Player_infoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cricInfoSystem2.masterDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fixtureBindingNavigator
            // 
            this.fixtureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fixtureBindingNavigator.BindingSource = this.fixtureBindingSource;
            this.fixtureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fixtureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fixtureBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fixtureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fixtureBindingNavigatorSaveItem});
            this.fixtureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fixtureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fixtureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fixtureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fixtureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fixtureBindingNavigator.Name = "fixtureBindingNavigator";
            this.fixtureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fixtureBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.fixtureBindingNavigator.TabIndex = 0;
            this.fixtureBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // fixtureBindingNavigatorSaveItem
            // 
            this.fixtureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fixtureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fixtureBindingNavigatorSaveItem.Image")));
            this.fixtureBindingNavigatorSaveItem.Name = "fixtureBindingNavigatorSaveItem";
            this.fixtureBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.fixtureBindingNavigatorSaveItem.Text = "Save Data";
            this.fixtureBindingNavigatorSaveItem.Click += new System.EventHandler(this.fixtureBindingNavigatorSaveItem_Click);
            // 
            // match_NoTextBox
            // 
            this.match_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fixtureBindingSource, "Match No", true));
            this.match_NoTextBox.Location = new System.Drawing.Point(162, 55);
            this.match_NoTextBox.Name = "match_NoTextBox";
            this.match_NoTextBox.Size = new System.Drawing.Size(200, 26);
            this.match_NoTextBox.TabIndex = 2;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fixtureBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(162, 87);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // team_1NameComboBox
            // 
            this.team_1NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fixtureBindingSource, "Team_1Name", true));
            this.team_1NameComboBox.FormattingEnabled = true;
            this.team_1NameComboBox.Items.AddRange(new object[] {
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
            this.team_1NameComboBox.Location = new System.Drawing.Point(162, 119);
            this.team_1NameComboBox.Name = "team_1NameComboBox";
            this.team_1NameComboBox.Size = new System.Drawing.Size(200, 28);
            this.team_1NameComboBox.TabIndex = 6;
            // 
            // team_2NameComboBox
            // 
            this.team_2NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fixtureBindingSource, "Team_2Name", true));
            this.team_2NameComboBox.FormattingEnabled = true;
            this.team_2NameComboBox.Items.AddRange(new object[] {
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
            this.team_2NameComboBox.Location = new System.Drawing.Point(162, 153);
            this.team_2NameComboBox.Name = "team_2NameComboBox";
            this.team_2NameComboBox.Size = new System.Drawing.Size(200, 28);
            this.team_2NameComboBox.TabIndex = 8;
            // 
            // fixtureDataGridView
            // 
            this.fixtureDataGridView.AllowUserToAddRows = false;
            this.fixtureDataGridView.AllowUserToDeleteRows = false;
            this.fixtureDataGridView.AutoGenerateColumns = false;
            this.fixtureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fixtureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.fixtureDataGridView.DataSource = this.fixtureBindingSource;
            this.fixtureDataGridView.Location = new System.Drawing.Point(52, 215);
            this.fixtureDataGridView.Name = "fixtureDataGridView";
            this.fixtureDataGridView.RowHeadersWidth = 62;
            this.fixtureDataGridView.RowTemplate.Height = 28;
            this.fixtureDataGridView.Size = new System.Drawing.Size(661, 220);
            this.fixtureDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Match No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Match No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Team_1Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Team_1Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Team_2Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Team_2Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Fixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.fixtureDataGridView);
            this.Controls.Add(match_NoLabel);
            this.Controls.Add(this.match_NoTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(team_1NameLabel);
            this.Controls.Add(this.team_1NameComboBox);
            this.Controls.Add(team_2NameLabel);
            this.Controls.Add(this.team_2NameComboBox);
            this.Controls.Add(this.fixtureBindingNavigator);
            this.Name = "Fixture";
            this.Text = "Fixture";
            this.Load += new System.EventHandler(this.Fixture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixtureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixtureBindingNavigator)).EndInit();
            this.fixtureBindingNavigator.ResumeLayout(false);
            this.fixtureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixtureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet3 masterDataSet3;
        private System.Windows.Forms.BindingSource fixtureBindingSource;
        private masterDataSet3TableAdapters.FixtureTableAdapter fixtureTableAdapter;
        private masterDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fixtureBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fixtureBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox match_NoTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox team_1NameComboBox;
        private System.Windows.Forms.ComboBox team_2NameComboBox;
        private System.Windows.Forms.DataGridView fixtureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}