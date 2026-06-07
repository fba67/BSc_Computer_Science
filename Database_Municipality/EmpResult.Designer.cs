namespace MunicipalityDisplay
{
    partial class EmpResult
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
            System.Windows.Forms.Label empNameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpResult));
            System.Windows.Forms.Label empSSNLabel1;
            System.Windows.Forms.Label areaNumLabel1;
            System.Windows.Forms.Label zoneNumLabel1;
            System.Windows.Forms.Label empSalaryLabel1;
            this.backmgr = new System.Windows.Forms.Button();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.empNameTextBox1 = new System.Windows.Forms.TextBox();
            this.empSSNTextBox1 = new System.Windows.Forms.TextBox();
            this.areaNumTextBox1 = new System.Windows.Forms.TextBox();
            this.zoneNumTextBox1 = new System.Windows.Forms.TextBox();
            this.empSalaryTextBox1 = new System.Windows.Forms.TextBox();
            empNameLabel1 = new System.Windows.Forms.Label();
            empSSNLabel1 = new System.Windows.Forms.Label();
            areaNumLabel1 = new System.Windows.Forms.Label();
            zoneNumLabel1 = new System.Windows.Forms.Label();
            empSalaryLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // empNameLabel1
            // 
            resources.ApplyResources(empNameLabel1, "empNameLabel1");
            empNameLabel1.Name = "empNameLabel1";
            // 
            // empSSNLabel1
            // 
            resources.ApplyResources(empSSNLabel1, "empSSNLabel1");
            empSSNLabel1.Name = "empSSNLabel1";
            // 
            // areaNumLabel1
            // 
            resources.ApplyResources(areaNumLabel1, "areaNumLabel1");
            areaNumLabel1.Name = "areaNumLabel1";
            // 
            // zoneNumLabel1
            // 
            resources.ApplyResources(zoneNumLabel1, "zoneNumLabel1");
            zoneNumLabel1.Name = "zoneNumLabel1";
            // 
            // empSalaryLabel1
            // 
            resources.ApplyResources(empSalaryLabel1, "empSalaryLabel1");
            empSalaryLabel1.Name = "empSalaryLabel1";
            // 
            // backmgr
            // 
            this.backmgr.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.backmgr, "backmgr");
            this.backmgr.Name = "backmgr";
            this.backmgr.UseVisualStyleBackColor = false;
            this.backmgr.Click += new System.EventHandler(this.backmgr_Click);
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeBindingNavigatorSaveItem});
            resources.ApplyResources(this.employeeBindingNavigator, "employeeBindingNavigator");
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.municipalityDatabaseDataSet;
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
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.employeeBindingNavigatorSaveItem, "employeeBindingNavigatorSaveItem");
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contractor_CompanyTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.OnlookerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZoneTableAdapter = null;
            // 
            // empNameTextBox1
            // 
            this.empNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmpName", true));
            resources.ApplyResources(this.empNameTextBox1, "empNameTextBox1");
            this.empNameTextBox1.Name = "empNameTextBox1";
            // 
            // empSSNTextBox1
            // 
            this.empSSNTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmpSSN", true));
            resources.ApplyResources(this.empSSNTextBox1, "empSSNTextBox1");
            this.empSSNTextBox1.Name = "empSSNTextBox1";
            // 
            // areaNumTextBox1
            // 
            this.areaNumTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "AreaNum", true));
            resources.ApplyResources(this.areaNumTextBox1, "areaNumTextBox1");
            this.areaNumTextBox1.Name = "areaNumTextBox1";
            // 
            // zoneNumTextBox1
            // 
            this.zoneNumTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ZoneNum", true));
            resources.ApplyResources(this.zoneNumTextBox1, "zoneNumTextBox1");
            this.zoneNumTextBox1.Name = "zoneNumTextBox1";
            // 
            // empSalaryTextBox1
            // 
            this.empSalaryTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmpSalary", true));
            resources.ApplyResources(this.empSalaryTextBox1, "empSalaryTextBox1");
            this.empSalaryTextBox1.Name = "empSalaryTextBox1";
            // 
            // EmpResult
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(empNameLabel1);
            this.Controls.Add(this.empNameTextBox1);
            this.Controls.Add(empSSNLabel1);
            this.Controls.Add(this.empSSNTextBox1);
            this.Controls.Add(areaNumLabel1);
            this.Controls.Add(this.areaNumTextBox1);
            this.Controls.Add(zoneNumLabel1);
            this.Controls.Add(this.zoneNumTextBox1);
            this.Controls.Add(empSalaryLabel1);
            this.Controls.Add(this.empSalaryTextBox1);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Controls.Add(this.backmgr);
            this.Name = "EmpResult";
            this.Load += new System.EventHandler(this.MgrResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backmgr;
        private MunicipalityDatabaseDataSet municipalityDatabaseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox empNameTextBox1;
        private System.Windows.Forms.TextBox empSSNTextBox1;
        private System.Windows.Forms.TextBox areaNumTextBox1;
        private System.Windows.Forms.TextBox zoneNumTextBox1;
        private System.Windows.Forms.TextBox empSalaryTextBox1;
    }
}