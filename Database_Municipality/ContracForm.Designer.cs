namespace MunicipalityDisplay
{
    partial class ContracForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContracForm));
            System.Windows.Forms.Label onlookerSSNLabel;
            System.Windows.Forms.Label compNameLabel;
            System.Windows.Forms.Label p_MLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label contractNumLabel;
            System.Windows.Forms.Label oLNameLabel;
            System.Windows.Forms.Label oLNameLabel1;
            this.contractor_CompanyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agentNameTextBox = new System.Windows.Forms.TextBox();
            this.onlookerSSNTextBox = new System.Windows.Forms.TextBox();
            this.compNameTextBox = new System.Windows.Forms.TextBox();
            this.p_MTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contractback = new System.Windows.Forms.Button();
            this.contractNumTextBox = new System.Windows.Forms.TextBox();
            this.oLNameTextBox = new System.Windows.Forms.TextBox();
            this.oLNameTextBox1 = new System.Windows.Forms.TextBox();
            this.contreport = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.contractor_CompanyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.onlookerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipalityDatabaseDataSet = new MunicipalityDisplay.MunicipalityDatabaseDataSet();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractor_CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractor_CompanyTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.Contractor_CompanyTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.areaTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.AreaTableAdapter();
            this.onlookerTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.OnlookerTableAdapter();
            agentNameLabel = new System.Windows.Forms.Label();
            onlookerSSNLabel = new System.Windows.Forms.Label();
            compNameLabel = new System.Windows.Forms.Label();
            p_MLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            contractNumLabel = new System.Windows.Forms.Label();
            oLNameLabel = new System.Windows.Forms.Label();
            oLNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingNavigator)).BeginInit();
            this.contractor_CompanyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlookerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agentNameLabel
            // 
            resources.ApplyResources(agentNameLabel, "agentNameLabel");
            agentNameLabel.Name = "agentNameLabel";
            // 
            // onlookerSSNLabel
            // 
            resources.ApplyResources(onlookerSSNLabel, "onlookerSSNLabel");
            onlookerSSNLabel.Name = "onlookerSSNLabel";
            // 
            // compNameLabel
            // 
            resources.ApplyResources(compNameLabel, "compNameLabel");
            compNameLabel.Name = "compNameLabel";
            // 
            // p_MLabel
            // 
            resources.ApplyResources(p_MLabel, "p_MLabel");
            p_MLabel.Name = "p_MLabel";
            // 
            // salaryLabel
            // 
            resources.ApplyResources(salaryLabel, "salaryLabel");
            salaryLabel.Name = "salaryLabel";
            // 
            // contractNumLabel
            // 
            resources.ApplyResources(contractNumLabel, "contractNumLabel");
            contractNumLabel.Name = "contractNumLabel";
            // 
            // oLNameLabel
            // 
            resources.ApplyResources(oLNameLabel, "oLNameLabel");
            oLNameLabel.Name = "oLNameLabel";
            // 
            // oLNameLabel1
            // 
            resources.ApplyResources(oLNameLabel1, "oLNameLabel1");
            oLNameLabel1.Name = "oLNameLabel1";
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
            resources.ApplyResources(this.contractor_CompanyBindingNavigator, "contractor_CompanyBindingNavigator");
            this.contractor_CompanyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractor_CompanyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractor_CompanyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractor_CompanyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractor_CompanyBindingNavigator.Name = "contractor_CompanyBindingNavigator";
            this.contractor_CompanyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // agentNameTextBox
            // 
            this.agentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractor_CompanyBindingSource, "AgentName", true));
            resources.ApplyResources(this.agentNameTextBox, "agentNameTextBox");
            this.agentNameTextBox.Name = "agentNameTextBox";
            // 
            // onlookerSSNTextBox
            // 
            this.onlookerSSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractor_CompanyBindingSource, "OnlookerSSN", true));
            resources.ApplyResources(this.onlookerSSNTextBox, "onlookerSSNTextBox");
            this.onlookerSSNTextBox.Name = "onlookerSSNTextBox";
            // 
            // compNameTextBox
            // 
            this.compNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractor_CompanyBindingSource, "CompName", true));
            resources.ApplyResources(this.compNameTextBox, "compNameTextBox");
            this.compNameTextBox.Name = "compNameTextBox";
            // 
            // p_MTextBox
            // 
            this.p_MTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractor_CompanyBindingSource, "P_M", true));
            resources.ApplyResources(this.p_MTextBox, "p_MTextBox");
            this.p_MTextBox.Name = "p_MTextBox";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractor_CompanyBindingSource, "Salary", true));
            resources.ApplyResources(this.salaryTextBox, "salaryTextBox");
            this.salaryTextBox.Name = "salaryTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // contractback
            // 
            this.contractback.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.contractback, "contractback");
            this.contractback.Name = "contractback";
            this.contractback.UseVisualStyleBackColor = false;
            this.contractback.Click += new System.EventHandler(this.contractback_Click);
            // 
            // contractNumTextBox
            // 
            this.contractNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "ContractNum", true));
            resources.ApplyResources(this.contractNumTextBox, "contractNumTextBox");
            this.contractNumTextBox.Name = "contractNumTextBox";
            // 
            // oLNameTextBox
            // 
            this.oLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.onlookerBindingSource, "OLName", true));
            resources.ApplyResources(this.oLNameTextBox, "oLNameTextBox");
            this.oLNameTextBox.Name = "oLNameTextBox";
            // 
            // oLNameTextBox1
            // 
            this.oLNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.onlookerBindingSource, "OLName", true));
            resources.ApplyResources(this.oLNameTextBox1, "oLNameTextBox1");
            this.oLNameTextBox1.Name = "oLNameTextBox1";
            // 
            // contreport
            // 
            this.contreport.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.contreport, "contreport");
            this.contreport.Name = "contreport";
            this.contreport.UseVisualStyleBackColor = false;
            this.contreport.Click += new System.EventHandler(this.contreport_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
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
            // contractor_CompanyBindingNavigatorSaveItem
            // 
            this.contractor_CompanyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.contractor_CompanyBindingNavigatorSaveItem, "contractor_CompanyBindingNavigatorSaveItem");
            this.contractor_CompanyBindingNavigatorSaveItem.Name = "contractor_CompanyBindingNavigatorSaveItem";
            this.contractor_CompanyBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractor_CompanyBindingNavigatorSaveItem_Click);
            // 
            // onlookerBindingSource
            // 
            this.onlookerBindingSource.DataMember = "Onlooker";
            this.onlookerBindingSource.DataSource = this.municipalityDatabaseDataSet;
            // 
            // municipalityDatabaseDataSet
            // 
            this.municipalityDatabaseDataSet.DataSetName = "MunicipalityDatabaseDataSet";
            this.municipalityDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.municipalityDatabaseDataSet;
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
            this.tableAdapterManager.AreaTableAdapter = this.areaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contractor_CompanyTableAdapter = this.contractor_CompanyTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OnlookerTableAdapter = this.onlookerTableAdapter;
            this.tableAdapterManager.UpdateOrder = MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZoneTableAdapter = null;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // onlookerTableAdapter
            // 
            this.onlookerTableAdapter.ClearBeforeFill = true;
            // 
            // ContracForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.contreport);
            this.Controls.Add(oLNameLabel1);
            this.Controls.Add(this.oLNameTextBox1);
            this.Controls.Add(oLNameLabel);
            this.Controls.Add(this.oLNameTextBox);
            this.Controls.Add(contractNumLabel);
            this.Controls.Add(this.contractNumTextBox);
            this.Controls.Add(this.contractback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(agentNameLabel);
            this.Controls.Add(this.agentNameTextBox);
            this.Controls.Add(onlookerSSNLabel);
            this.Controls.Add(this.onlookerSSNTextBox);
            this.Controls.Add(compNameLabel);
            this.Controls.Add(this.compNameTextBox);
            this.Controls.Add(p_MLabel);
            this.Controls.Add(this.p_MTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.contractor_CompanyBindingNavigator);
            this.Name = "ContracForm";
            this.Load += new System.EventHandler(this.ContracForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingNavigator)).EndInit();
            this.contractor_CompanyBindingNavigator.ResumeLayout(false);
            this.contractor_CompanyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlookerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox salaryTextBox;
        
        int @areanum, @zonenum;
        string @compname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button contractback;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private System.Windows.Forms.TextBox contractNumTextBox;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.OnlookerTableAdapter onlookerTableAdapter;
        private System.Windows.Forms.BindingSource onlookerBindingSource;
        private System.Windows.Forms.TextBox oLNameTextBox;
        private System.Windows.Forms.TextBox oLNameTextBox1;
        private System.Windows.Forms.Button contreport;
    }
}