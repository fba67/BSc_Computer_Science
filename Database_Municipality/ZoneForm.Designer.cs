namespace MunicipalityDisplay
{
    partial class ZoneForm
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
            System.Windows.Forms.Label zoneNumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoneForm));
            System.Windows.Forms.Label mgrNameLabel;
            System.Windows.Forms.Label mgrSSNLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label colseDateLabel;
            this.zoneBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.zoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipalityDatabaseDataSet = new MunicipalityDisplay.MunicipalityDatabaseDataSet();
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
            this.zoneBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.areaok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchmgrlabel = new System.Windows.Forms.Label();
            this.empzonetextBox = new System.Windows.Forms.TextBox();
            this.searchemprzone = new System.Windows.Forms.Button();
            this.zoneNumTextBox = new System.Windows.Forms.TextBox();
            this.mgrNameTextBox = new System.Windows.Forms.TextBox();
            this.mgrSSNTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.colseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.zoneback = new System.Windows.Forms.Button();
            this.zoneTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ZoneTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.zonelabel = new System.Windows.Forms.Label();
            zoneNumLabel = new System.Windows.Forms.Label();
            mgrNameLabel = new System.Windows.Forms.Label();
            mgrSSNLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            colseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zoneBindingNavigator)).BeginInit();
            this.zoneBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // zoneNumLabel
            // 
            resources.ApplyResources(zoneNumLabel, "zoneNumLabel");
            zoneNumLabel.Name = "zoneNumLabel";
            // 
            // mgrNameLabel
            // 
            resources.ApplyResources(mgrNameLabel, "mgrNameLabel");
            mgrNameLabel.Name = "mgrNameLabel";
            // 
            // mgrSSNLabel
            // 
            resources.ApplyResources(mgrSSNLabel, "mgrSSNLabel");
            mgrSSNLabel.Name = "mgrSSNLabel";
            // 
            // startDateLabel
            // 
            resources.ApplyResources(startDateLabel, "startDateLabel");
            startDateLabel.Name = "startDateLabel";
            // 
            // colseDateLabel
            // 
            resources.ApplyResources(colseDateLabel, "colseDateLabel");
            colseDateLabel.Name = "colseDateLabel";
            // 
            // zoneBindingNavigator
            // 
            this.zoneBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zoneBindingNavigator.BindingSource = this.zoneBindingSource;
            this.zoneBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zoneBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zoneBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zoneBindingNavigatorSaveItem});
            resources.ApplyResources(this.zoneBindingNavigator, "zoneBindingNavigator");
            this.zoneBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zoneBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zoneBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zoneBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zoneBindingNavigator.Name = "zoneBindingNavigator";
            this.zoneBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // zoneBindingSource
            // 
            this.zoneBindingSource.DataMember = "Zone";
            this.zoneBindingSource.DataSource = this.municipalityDatabaseDataSet;
            // 
            // municipalityDatabaseDataSet
            // 
            this.municipalityDatabaseDataSet.DataSetName = "MunicipalityDatabaseDataSet";
            this.municipalityDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // zoneBindingNavigatorSaveItem
            // 
            this.zoneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.zoneBindingNavigatorSaveItem, "zoneBindingNavigatorSaveItem");
            this.zoneBindingNavigatorSaveItem.Name = "zoneBindingNavigatorSaveItem";
            this.zoneBindingNavigatorSaveItem.Click += new System.EventHandler(this.zoneBindingNavigatorSaveItem_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // areaok
            // 
            this.areaok.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.areaok, "areaok");
            this.areaok.Name = "areaok";
            this.areaok.UseVisualStyleBackColor = false;
            this.areaok.Click += new System.EventHandler(this.areaok_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // searchmgrlabel
            // 
            resources.ApplyResources(this.searchmgrlabel, "searchmgrlabel");
            this.searchmgrlabel.Name = "searchmgrlabel";
            // 
            // empzonetextBox
            // 
            resources.ApplyResources(this.empzonetextBox, "empzonetextBox");
            this.empzonetextBox.Name = "empzonetextBox";
            this.empzonetextBox.TextChanged += new System.EventHandler(this.mgrzonetextBox_TextChanged);
            // 
            // searchemprzone
            // 
            this.searchemprzone.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.searchemprzone, "searchemprzone");
            this.searchemprzone.Name = "searchemprzone";
            this.searchemprzone.UseVisualStyleBackColor = false;
            this.searchemprzone.Click += new System.EventHandler(this.searchmagrzone_Click);
            // 
            // zoneNumTextBox
            // 
            this.zoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoneBindingSource, "ZoneNum", true));
            resources.ApplyResources(this.zoneNumTextBox, "zoneNumTextBox");
            this.zoneNumTextBox.Name = "zoneNumTextBox";
            // 
            // mgrNameTextBox
            // 
            this.mgrNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoneBindingSource, "MgrName", true));
            resources.ApplyResources(this.mgrNameTextBox, "mgrNameTextBox");
            this.mgrNameTextBox.Name = "mgrNameTextBox";
            // 
            // mgrSSNTextBox
            // 
            this.mgrSSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoneBindingSource, "MgrSSN", true));
            resources.ApplyResources(this.mgrSSNTextBox, "mgrSSNTextBox");
            this.mgrSSNTextBox.Name = "mgrSSNTextBox";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zoneBindingSource, "StartDate", true));
            resources.ApplyResources(this.startDateDateTimePicker, "startDateDateTimePicker");
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.ValueChanged += new System.EventHandler(this.startDateDateTimePicker_ValueChanged);
            // 
            // colseDateDateTimePicker
            // 
            this.colseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zoneBindingSource, "ColseDate", true));
            resources.ApplyResources(this.colseDateDateTimePicker, "colseDateDateTimePicker");
            this.colseDateDateTimePicker.Name = "colseDateDateTimePicker";
            // 
            // zoneback
            // 
            this.zoneback.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.zoneback, "zoneback");
            this.zoneback.Name = "zoneback";
            this.zoneback.UseVisualStyleBackColor = false;
            this.zoneback.Click += new System.EventHandler(this.zoneback_Click);
            // 
            // zoneTableAdapter
            // 
            this.zoneTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contractor_CompanyTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OnlookerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZoneTableAdapter = this.zoneTableAdapter;
            // 
            // zonelabel
            // 
            resources.ApplyResources(this.zonelabel, "zonelabel");
            this.zonelabel.Name = "zonelabel";
            // 
            // ZoneForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.zonelabel);
            this.Controls.Add(this.zoneback);
            this.Controls.Add(zoneNumLabel);
            this.Controls.Add(this.zoneNumTextBox);
            this.Controls.Add(mgrNameLabel);
            this.Controls.Add(this.mgrNameTextBox);
            this.Controls.Add(mgrSSNLabel);
            this.Controls.Add(this.mgrSSNTextBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(colseDateLabel);
            this.Controls.Add(this.colseDateDateTimePicker);
            this.Controls.Add(this.searchemprzone);
            this.Controls.Add(this.empzonetextBox);
            this.Controls.Add(this.searchmgrlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.areaok);
            this.Controls.Add(this.zoneBindingNavigator);
            this.DoubleBuffered = true;
            this.Name = "ZoneForm";
            this.Load += new System.EventHandler(this.Zone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoneBindingNavigator)).EndInit();
            this.zoneBindingNavigator.ResumeLayout(false);
            this.zoneBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MunicipalityDatabaseDataSet municipalityDatabaseDataSet;
        private System.Windows.Forms.BindingSource zoneBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ZoneTableAdapter zoneTableAdapter;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zoneBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zoneBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button areaok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label searchmgrlabel;
        private System.Windows.Forms.TextBox empzonetextBox;
        private System.Windows.Forms.Button searchemprzone;
        private System.Windows.Forms.TextBox zoneNumTextBox;
        private System.Windows.Forms.TextBox mgrNameTextBox;
        private System.Windows.Forms.TextBox mgrSSNTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker colseDateDateTimePicker;
        private System.Windows.Forms.Button zoneback;
        private System.Windows.Forms.Label zonelabel;
    }
}