namespace MunicipalityDisplay
{
    partial class ContractForm
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
            System.Windows.Forms.Label agentNameLabel;
            System.Windows.Forms.Label onlookerSSNLabel;
            System.Windows.Forms.Label compNameLabel;
            System.Windows.Forms.Label p_MLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractForm));
            this.municipalityDatabaseDataSet = new MunicipalityDisplay.MunicipalityDatabaseDataSet();
            this.contractor_CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractor_CompanyTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.Contractor_CompanyTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.contractor_CompanyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agentNameTextBox = new System.Windows.Forms.TextBox();
            this.onlookerSSNTextBox = new System.Windows.Forms.TextBox();
            this.compNameTextBox = new System.Windows.Forms.TextBox();
            this.p_MTextBox = new System.Windows.Forms.TextBox();
            this.contractback = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.contractor_CompanyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            agentNameLabel = new System.Windows.Forms.Label();
            onlookerSSNLabel = new System.Windows.Forms.Label();
            compNameLabel = new System.Windows.Forms.Label();
            p_MLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingNavigator)).BeginInit();
            this.contractor_CompanyBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // municipalityDatabaseDataSet
            // 
            this.municipalityDatabaseDataSet.DataSetName = "MunicipalityDatabaseDataSet";
            this.municipalityDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractor_CompanyBindingSource
            // 
            this.contractor_CompanyBindingSource.DataMember = "Contractor_Company";
            this.contractor_CompanyBindingSource.DataSource = this.municipalityDatabaseDataSet;
            // 
            // contractor_CompanyTableAdapter
            // 
            this.contractor_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contractor_CompanyTableAdapter = this.contractor_CompanyTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OnlookerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZoneTableAdapter = null;
            // 
            // contractor_CompanyBindingNavigator
            // 
            this.contractor_CompanyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractor_CompanyBindingNavigator.BindingSource = this.contractor_CompanyBindingSource;
            this.contractor_CompanyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractor_CompanyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractor_CompanyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contractor_CompanyBindingNavigatorSaveItem});
            this.contractor_CompanyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractor_CompanyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractor_CompanyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractor_CompanyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractor_CompanyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractor_CompanyBindingNavigator.Name = "contractor_CompanyBindingNavigator";
            this.contractor_CompanyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractor_CompanyBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.contractor_CompanyBindingNavigator.TabIndex = 0;
            this.contractor_CompanyBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // agentNameLabel
            // 
            agentNameLabel.AutoSize = true;
            agentNameLabel.Location = new System.Drawing.Point(162, 76);
            agentNameLabel.Name = "agentNameLabel";
            agentNameLabel.Size = new System.Drawing.Size(39, 13);
            agentNameLabel.TabIndex = 1;
            agentNameLabel.Text = "نماینده";
            // 
            // agentNameTextBox
            // 
            this.agentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractor_CompanyBindingSource, "AgentName", true));
            this.agentNameTextBox.Location = new System.Drawing.Point(47, 69);
            this.agentNameTextBox.Name = "agentNameTextBox";
            this.agentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.agentNameTextBox.TabIndex = 2;
            // 
            // onlookerSSNLabel
            // 
            onlookerSSNLabel.AutoSize = true;
            onlookerSSNLabel.Location = new System.Drawing.Point(162, 102);
            onlookerSSNLabel.Name = "onlookerSSNLabel";
            onlookerSSNLabel.Size = new System.Drawing.Size(63, 13);
            onlookerSSNLabel.TabIndex = 3;
            onlookerSSNLabel.Text = "کد ملی ناظر";
            // 
            // onlookerSSNTextBox
            // 
            this.onlookerSSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractor_CompanyBindingSource, "OnlookerSSN", true));
            this.onlookerSSNTextBox.Location = new System.Drawing.Point(47, 95);
            this.onlookerSSNTextBox.Name = "onlookerSSNTextBox";
            this.onlookerSSNTextBox.Size = new System.Drawing.Size(100, 20);
            this.onlookerSSNTextBox.TabIndex = 4;
            // 
            // compNameLabel
            // 
            compNameLabel.AutoSize = true;
            compNameLabel.Location = new System.Drawing.Point(162, 128);
            compNameLabel.Name = "compNameLabel";
            compNameLabel.Size = new System.Drawing.Size(86, 13);
            compNameLabel.TabIndex = 5;
            compNameLabel.Text = "شرکت پیمانکاری";
            // 
            // compNameTextBox
            // 
            this.compNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractor_CompanyBindingSource, "CompName", true));
            this.compNameTextBox.Location = new System.Drawing.Point(47, 121);
            this.compNameTextBox.Name = "compNameTextBox";
            this.compNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.compNameTextBox.TabIndex = 6;
            // 
            // p_MLabel
            // 
            p_MLabel.AutoSize = true;
            p_MLabel.Location = new System.Drawing.Point(162, 154);
            p_MLabel.Name = "p_MLabel";
            p_MLabel.Size = new System.Drawing.Size(62, 13);
            p_MLabel.TabIndex = 7;
            p_MLabel.Text = "پلوس/مینوس";
            // 
            // p_MTextBox
            // 
            this.p_MTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractor_CompanyBindingSource, "P_M", true));
            this.p_MTextBox.Location = new System.Drawing.Point(47, 147);
            this.p_MTextBox.Name = "p_MTextBox";
            this.p_MTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_MTextBox.TabIndex = 8;
            // 
            // contractback
            // 
            this.contractback.BackColor = System.Drawing.Color.Aquamarine;
            this.contractback.Location = new System.Drawing.Point(27, 229);
            this.contractback.Name = "contractback";
            this.contractback.Size = new System.Drawing.Size(60, 20);
            this.contractback.TabIndex = 11;
            this.contractback.Text = "بازگشت";
            this.contractback.UseVisualStyleBackColor = false;
            this.contractback.Click += new System.EventHandler(this.contractback_Click);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // contractor_CompanyBindingNavigatorSaveItem
            // 
            this.contractor_CompanyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractor_CompanyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractor_CompanyBindingNavigatorSaveItem.Image")));
            this.contractor_CompanyBindingNavigatorSaveItem.Name = "contractor_CompanyBindingNavigatorSaveItem";
            this.contractor_CompanyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contractor_CompanyBindingNavigatorSaveItem.Text = "Save Data";
            this.contractor_CompanyBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractor_CompanyBindingNavigatorSaveItem_Click_1);
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.contractback);
            this.Controls.Add(agentNameLabel);
            this.Controls.Add(this.agentNameTextBox);
            this.Controls.Add(onlookerSSNLabel);
            this.Controls.Add(this.onlookerSSNTextBox);
            this.Controls.Add(compNameLabel);
            this.Controls.Add(this.compNameTextBox);
            this.Controls.Add(p_MLabel);
            this.Controls.Add(this.p_MTextBox);
            this.Controls.Add(this.contractor_CompanyBindingNavigator);
            this.Name = "ContractForm";
            this.Text = "فرم قراردادها";
            this.Load += new System.EventHandler(this.ContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingNavigator)).EndInit();
            this.contractor_CompanyBindingNavigator.ResumeLayout(false);
            this.contractor_CompanyBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MunicipalityDatabaseDataSet municipalityDatabaseDataSet;
        private System.Windows.Forms.BindingSource contractor_CompanyBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.Contractor_CompanyTableAdapter contractor_CompanyTableAdapter;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractor_CompanyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contractor_CompanyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox agentNameTextBox;
        private System.Windows.Forms.TextBox onlookerSSNTextBox;
        private System.Windows.Forms.TextBox compNameTextBox;
        private System.Windows.Forms.TextBox p_MTextBox;
        private System.Windows.Forms.Button contractback;

    }
}