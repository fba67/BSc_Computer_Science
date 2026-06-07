namespace MunicipalityDisplay
{
    partial class ActivityForm
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
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            this.label1 = new System.Windows.Forms.Label();
            this.activityback = new System.Windows.Forms.Button();
            this.activityViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.activityViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.activityViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.actNameTextBox = new System.Windows.Forms.TextBox();
            this.areaNumTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.oLSSNTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.basePriceTextBox = new System.Windows.Forms.TextBox();
            this.surchargeTextBox = new System.Windows.Forms.TextBox();
            this.validatePercentTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.oLNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.activityViewTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ActivityViewTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.activityTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ActivityTableAdapter();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityViewBindingNavigator)).BeginInit();
            this.activityViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // activityback
            // 
            this.activityback.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.activityback, "activityback");
            this.activityback.Name = "activityback";
            this.activityback.UseVisualStyleBackColor = false;
            this.activityback.Click += new System.EventHandler(this.activityback_Click);
            // 
            // activityViewBindingNavigator
            // 
            this.activityViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.activityViewBindingNavigator.BindingSource = this.activityViewBindingSource;
            this.activityViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activityViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.activityViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.activityViewBindingNavigatorSaveItem});
            resources.ApplyResources(this.activityViewBindingNavigator, "activityViewBindingNavigator");
            this.activityViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activityViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activityViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activityViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activityViewBindingNavigator.Name = "activityViewBindingNavigator";
            this.activityViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // activityViewBindingSource
            // 
            this.activityViewBindingSource.DataMember = "ActivityView";
            this.activityViewBindingSource.DataSource = this.municipalityDatabaseDataSet;
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
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // activityViewBindingNavigatorSaveItem
            // 
            this.activityViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.activityViewBindingNavigatorSaveItem, "activityViewBindingNavigatorSaveItem");
            this.activityViewBindingNavigatorSaveItem.Name = "activityViewBindingNavigatorSaveItem";
            this.activityViewBindingNavigatorSaveItem.Click += new System.EventHandler(this.activityViewBindingNavigatorSaveItem_Click);
            // 
            // actNameTextBox
            // 
            this.actNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "ActName", true));
            resources.ApplyResources(this.actNameTextBox, "actNameTextBox");
            this.actNameTextBox.Name = "actNameTextBox";
            // 
            // areaNumTextBox
            // 
            this.areaNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "AreaNum", true));
            resources.ApplyResources(this.areaNumTextBox, "areaNumTextBox");
            this.areaNumTextBox.Name = "areaNumTextBox";
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "Value", true));
            resources.ApplyResources(this.valueTextBox, "valueTextBox");
            this.valueTextBox.Name = "valueTextBox";
            // 
            // oLSSNTextBox
            // 
            this.oLSSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "OLSSN", true));
            resources.ApplyResources(this.oLSSNTextBox, "oLSSNTextBox");
            this.oLSSNTextBox.Name = "oLSSNTextBox";
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "Unit", true));
            resources.ApplyResources(this.unitTextBox, "unitTextBox");
            this.unitTextBox.Name = "unitTextBox";
            // 
            // basePriceTextBox
            // 
            this.basePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "BasePrice", true));
            resources.ApplyResources(this.basePriceTextBox, "basePriceTextBox");
            this.basePriceTextBox.Name = "basePriceTextBox";
            // 
            // surchargeTextBox
            // 
            this.surchargeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "Surcharge", true));
            resources.ApplyResources(this.surchargeTextBox, "surchargeTextBox");
            this.surchargeTextBox.Name = "surchargeTextBox";
            // 
            // validatePercentTextBox
            // 
            this.validatePercentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "ValidatePercent", true));
            resources.ApplyResources(this.validatePercentTextBox, "validatePercentTextBox");
            this.validatePercentTextBox.Name = "validatePercentTextBox";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "Salary", true));
            resources.ApplyResources(this.salaryTextBox, "salaryTextBox");
            this.salaryTextBox.Name = "salaryTextBox";
            // 
            // oLNameTextBox
            // 
            this.oLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityViewBindingSource, "OLName", true));
            resources.ApplyResources(this.oLNameTextBox, "oLNameTextBox");
            this.oLNameTextBox.Name = "oLNameTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // activityViewTableAdapter
            // 
            this.activityViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = this.activityTableAdapter;
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contractor_CompanyTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OnlookerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZoneTableAdapter = null;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "Activity";
            this.activityBindingSource.DataSource = this.municipalityDatabaseDataSet;
            // 
            // ActivityForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Controls.Add(label8);
            this.Controls.Add(label9);
            this.Controls.Add(label10);
            this.Controls.Add(label11);
            this.Controls.Add(label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actNameTextBox);
            this.Controls.Add(this.areaNumTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.oLSSNTextBox);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.basePriceTextBox);
            this.Controls.Add(this.surchargeTextBox);
            this.Controls.Add(this.validatePercentTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.oLNameTextBox);
            this.Controls.Add(this.activityViewBindingNavigator);
            this.Controls.Add(this.activityback);
            this.Controls.Add(this.label1);
            this.Name = "ActivityForm";
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityViewBindingNavigator)).EndInit();
            this.activityViewBindingNavigator.ResumeLayout(false);
            this.activityViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        int @areanum, @zonenum;
        private System.Windows.Forms.Button activityback;
        private MunicipalityDatabaseDataSet municipalityDatabaseDataSet;
        private System.Windows.Forms.BindingSource activityViewBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ActivityViewTableAdapter activityViewTableAdapter;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator activityViewBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton activityViewBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox actNameTextBox;
        private System.Windows.Forms.TextBox areaNumTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox oLSSNTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox basePriceTextBox;
        private System.Windows.Forms.TextBox surchargeTextBox;
        private System.Windows.Forms.TextBox validatePercentTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox oLNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ActivityTableAdapter activityTableAdapter;
    }
}