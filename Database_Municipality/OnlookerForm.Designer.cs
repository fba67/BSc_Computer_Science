namespace MunicipalityDisplay
{
    partial class OnlookerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlookerForm));
            System.Windows.Forms.Label oLNameLabel;
            System.Windows.Forms.Label oLSSNLabel;
            this.municipalityDatabaseDataSet = new MunicipalityDisplay.MunicipalityDatabaseDataSet();
            this.onlookerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlookerTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.OnlookerTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.onlookerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.onlookerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oLNameTextBox = new System.Windows.Forms.TextBox();
            this.oLSSNTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            oLNameLabel = new System.Windows.Forms.Label();
            oLSSNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlookerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlookerBindingNavigator)).BeginInit();
            this.onlookerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // municipalityDatabaseDataSet
            // 
            this.municipalityDatabaseDataSet.DataSetName = "MunicipalityDatabaseDataSet";
            this.municipalityDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // onlookerBindingSource
            // 
            this.onlookerBindingSource.DataMember = "Onlooker";
            this.onlookerBindingSource.DataSource = this.municipalityDatabaseDataSet;
            // 
            // onlookerTableAdapter
            // 
            this.onlookerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contractor_CompanyTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OnlookerTableAdapter = this.onlookerTableAdapter;
            this.tableAdapterManager.UpdateOrder = MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZoneTableAdapter = null;
            // 
            // onlookerBindingNavigator
            // 
            this.onlookerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.onlookerBindingNavigator.BindingSource = this.onlookerBindingSource;
            this.onlookerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.onlookerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.onlookerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.onlookerBindingNavigatorSaveItem});
            this.onlookerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.onlookerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.onlookerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.onlookerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.onlookerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.onlookerBindingNavigator.Name = "onlookerBindingNavigator";
            this.onlookerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.onlookerBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.onlookerBindingNavigator.TabIndex = 0;
            this.onlookerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // onlookerBindingNavigatorSaveItem
            // 
            this.onlookerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.onlookerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("onlookerBindingNavigatorSaveItem.Image")));
            this.onlookerBindingNavigatorSaveItem.Name = "onlookerBindingNavigatorSaveItem";
            this.onlookerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.onlookerBindingNavigatorSaveItem.Text = "Save Data";
            this.onlookerBindingNavigatorSaveItem.Click += new System.EventHandler(this.onlookerBindingNavigatorSaveItem_Click_1);
            // 
            // oLNameLabel
            // 
            oLNameLabel.AutoSize = true;
            oLNameLabel.Location = new System.Drawing.Point(178, 103);
            oLNameLabel.Name = "oLNameLabel";
            oLNameLabel.Size = new System.Drawing.Size(43, 13);
            oLNameLabel.TabIndex = 1;
            oLNameLabel.Text = "نام ناظر";
            // 
            // oLNameTextBox
            // 
            this.oLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.onlookerBindingSource, "OLName", true));
            this.oLNameTextBox.Location = new System.Drawing.Point(69, 96);
            this.oLNameTextBox.Name = "oLNameTextBox";
            this.oLNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.oLNameTextBox.TabIndex = 2;
            // 
            // oLSSNLabel
            // 
            oLSSNLabel.AutoSize = true;
            oLSSNLabel.Location = new System.Drawing.Point(178, 129);
            oLSSNLabel.Name = "oLSSNLabel";
            oLSSNLabel.Size = new System.Drawing.Size(63, 13);
            oLSSNLabel.TabIndex = 3;
            oLSSNLabel.Text = "کد ملی ناظر";
            // 
            // oLSSNTextBox
            // 
            this.oLSSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.onlookerBindingSource, "OLSSN", true));
            this.oLSSNTextBox.Location = new System.Drawing.Point(69, 122);
            this.oLSSNTextBox.Name = "oLSSNTextBox";
            this.oLSSNTextBox.Size = new System.Drawing.Size(100, 20);
            this.oLSSNTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(33, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OnlookerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(oLNameLabel);
            this.Controls.Add(this.oLNameTextBox);
            this.Controls.Add(oLSSNLabel);
            this.Controls.Add(this.oLSSNTextBox);
            this.Controls.Add(this.onlookerBindingNavigator);
            this.Name = "OnlookerForm";
            this.Text = "فرم ناظر";
            this.Load += new System.EventHandler(this.OnlookerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlookerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlookerBindingNavigator)).EndInit();
            this.onlookerBindingNavigator.ResumeLayout(false);
            this.onlookerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MunicipalityDatabaseDataSet municipalityDatabaseDataSet;
        private System.Windows.Forms.BindingSource onlookerBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.OnlookerTableAdapter onlookerTableAdapter;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator onlookerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton onlookerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox oLNameTextBox;
        private System.Windows.Forms.TextBox oLSSNTextBox;
        private System.Windows.Forms.Button button1;

    }
}