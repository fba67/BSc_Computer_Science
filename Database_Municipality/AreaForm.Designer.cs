namespace MunicipalityDisplay
{
    partial class AreaForm
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
            System.Windows.Forms.Label compNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaForm));
            this.areaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipalityDatabaseDataSet = new MunicipalityDisplay.MunicipalityDatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.compNameTextBox = new System.Windows.Forms.TextBox();
            this.areaemp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.areactivity = new System.Windows.Forms.Button();
            this.areaTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.AreaTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.areaback = new System.Windows.Forms.Button();
            this.contractbut = new System.Windows.Forms.Button();
            this.activityeditbut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.areaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            compNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingNavigator)).BeginInit();
            this.areaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // compNameLabel
            // 
            resources.ApplyResources(compNameLabel, "compNameLabel");
            compNameLabel.Name = "compNameLabel";
            // 
            // areaBindingNavigator
            // 
            this.areaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.areaBindingNavigator.BindingSource = this.areaBindingSource;
            this.areaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.areaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.areaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.areaBindingNavigatorSaveItem});
            resources.ApplyResources(this.areaBindingNavigator, "areaBindingNavigator");
            this.areaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.areaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.areaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.areaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.areaBindingNavigator.Name = "areaBindingNavigator";
            this.areaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.municipalityDatabaseDataSet;
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
            // compNameTextBox
            // 
            this.compNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "CompName", true));
            resources.ApplyResources(this.compNameTextBox, "compNameTextBox");
            this.compNameTextBox.Name = "compNameTextBox";
            this.compNameTextBox.TextChanged += new System.EventHandler(this.compNameTextBox_TextChanged);
            // 
            // areaemp
            // 
            this.areaemp.BackColor = System.Drawing.Color.Aquamarine;
            this.areaemp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.areaemp, "areaemp");
            this.areaemp.Name = "areaemp";
            this.areaemp.UseVisualStyleBackColor = false;
            this.areaemp.Click += new System.EventHandler(this.areaemp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // areactivity
            // 
            this.areactivity.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.areactivity, "areactivity");
            this.areactivity.Name = "areactivity";
            this.areactivity.UseVisualStyleBackColor = false;
            this.areactivity.Click += new System.EventHandler(this.button2_Click);
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = this.areaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contractor_CompanyTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OnlookerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZoneTableAdapter = null;
            // 
            // areaback
            // 
            this.areaback.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.areaback, "areaback");
            this.areaback.Name = "areaback";
            this.areaback.UseVisualStyleBackColor = false;
            this.areaback.Click += new System.EventHandler(this.areaback_Click);
            // 
            // contractbut
            // 
            this.contractbut.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.contractbut, "contractbut");
            this.contractbut.Name = "contractbut";
            this.contractbut.UseVisualStyleBackColor = false;
            this.contractbut.Click += new System.EventHandler(this.contractbut_Click);
            // 
            // activityeditbut
            // 
            this.activityeditbut.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.activityeditbut, "activityeditbut");
            this.activityeditbut.Name = "activityeditbut";
            this.activityeditbut.UseVisualStyleBackColor = false;
            this.activityeditbut.Click += new System.EventHandler(this.activityeditbut_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            // areaBindingNavigatorSaveItem
            // 
            this.areaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.areaBindingNavigatorSaveItem, "areaBindingNavigatorSaveItem");
            this.areaBindingNavigatorSaveItem.Name = "areaBindingNavigatorSaveItem";
            this.areaBindingNavigatorSaveItem.Click += new System.EventHandler(this.areaBindingNavigatorSaveItem_Click);
            // 
            // AreaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.activityeditbut);
            this.Controls.Add(this.contractbut);
            this.Controls.Add(this.areaback);
            this.Controls.Add(this.areactivity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.areaemp);
            this.Controls.Add(compNameLabel);
            this.Controls.Add(this.compNameTextBox);
            this.Controls.Add(this.areaBindingNavigator);
            this.Name = "AreaForm";
            this.Load += new System.EventHandler(this.AreaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingNavigator)).EndInit();
            this.areaBindingNavigator.ResumeLayout(false);
            this.areaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MunicipalityDatabaseDataSet municipalityDatabaseDataSet;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator areaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton areaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox compNameTextBox;
        private System.Windows.Forms.Button areaemp;
        private System.Windows.Forms.Button button1;
        int @areanum, @zonenum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button areactivity;
        private System.Windows.Forms.Button areaback;
        private System.Windows.Forms.Button contractbut;
        private System.Windows.Forms.Button activityeditbut;
        private System.Windows.Forms.Button button2;

    }
}