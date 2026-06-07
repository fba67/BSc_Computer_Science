namespace MunicipalityDisplay
{
    partial class ActivityFillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityFillingForm));
            System.Windows.Forms.Label actNameLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label oLSSNLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label basePriceLabel;
            System.Windows.Forms.Label surchargeLabel;
            System.Windows.Forms.Label validatePercentLabel;
            System.Windows.Forms.Label areaNumLabel;
            this.municipalityDatabaseDataSet = new MunicipalityDisplay.MunicipalityDatabaseDataSet();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ActivityTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.activityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.activityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.actNameTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.oLSSNTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.basePriceTextBox = new System.Windows.Forms.TextBox();
            this.surchargeTextBox = new System.Windows.Forms.TextBox();
            this.validatePercentTextBox = new System.Windows.Forms.TextBox();
            this.areaNumTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            actNameLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            oLSSNLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            basePriceLabel = new System.Windows.Forms.Label();
            surchargeLabel = new System.Windows.Forms.Label();
            validatePercentLabel = new System.Windows.Forms.Label();
            areaNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).BeginInit();
            this.activityBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // municipalityDatabaseDataSet
            // 
            this.municipalityDatabaseDataSet.DataSetName = "MunicipalityDatabaseDataSet";
            this.municipalityDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "Activity";
            this.activityBindingSource.DataSource = this.municipalityDatabaseDataSet;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
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
            // activityBindingNavigator
            // 
            this.activityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.activityBindingNavigator.BindingSource = this.activityBindingSource;
            this.activityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.activityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.activityBindingNavigatorSaveItem});
            this.activityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activityBindingNavigator.Name = "activityBindingNavigator";
            this.activityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activityBindingNavigator.Size = new System.Drawing.Size(302, 25);
            this.activityBindingNavigator.TabIndex = 0;
            this.activityBindingNavigator.Text = "bindingNavigator1";
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
            // activityBindingNavigatorSaveItem
            // 
            this.activityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.activityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("activityBindingNavigatorSaveItem.Image")));
            this.activityBindingNavigatorSaveItem.Name = "activityBindingNavigatorSaveItem";
            this.activityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.activityBindingNavigatorSaveItem.Text = "Save Data";
            this.activityBindingNavigatorSaveItem.Click += new System.EventHandler(this.activityBindingNavigatorSaveItem_Click_1);
            // 
            // actNameLabel
            // 
            actNameLabel.AutoSize = true;
            actNameLabel.Location = new System.Drawing.Point(179, 57);
            actNameLabel.Name = "actNameLabel";
            actNameLabel.Size = new System.Drawing.Size(54, 13);
            actNameLabel.TabIndex = 1;
            actNameLabel.Text = "نام فعالیت";
            // 
            // actNameTextBox
            // 
            this.actNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActName", true));
            this.actNameTextBox.Location = new System.Drawing.Point(73, 54);
            this.actNameTextBox.Name = "actNameTextBox";
            this.actNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.actNameTextBox.TabIndex = 2;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(179, 83);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(49, 13);
            valueLabel.TabIndex = 3;
            valueLabel.Text = "مقدار کار";
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "Value", true));
            this.valueTextBox.Location = new System.Drawing.Point(73, 80);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 4;
            // 
            // oLSSNLabel
            // 
            oLSSNLabel.AutoSize = true;
            oLSSNLabel.Location = new System.Drawing.Point(179, 109);
            oLSSNLabel.Name = "oLSSNLabel";
            oLSSNLabel.Size = new System.Drawing.Size(63, 13);
            oLSSNLabel.TabIndex = 5;
            oLSSNLabel.Text = "کد ملی ناظر";
            // 
            // oLSSNTextBox
            // 
            this.oLSSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "OLSSN", true));
            this.oLSSNTextBox.Location = new System.Drawing.Point(73, 106);
            this.oLSSNTextBox.Name = "oLSSNTextBox";
            this.oLSSNTextBox.Size = new System.Drawing.Size(100, 20);
            this.oLSSNTextBox.TabIndex = 6;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(179, 135);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(28, 13);
            unitLabel.TabIndex = 7;
            unitLabel.Text = "واحد";
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "Unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(73, 132);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitTextBox.TabIndex = 8;
            // 
            // basePriceLabel
            // 
            basePriceLabel.AutoSize = true;
            basePriceLabel.Location = new System.Drawing.Point(179, 161);
            basePriceLabel.Name = "basePriceLabel";
            basePriceLabel.Size = new System.Drawing.Size(79, 13);
            basePriceLabel.TabIndex = 9;
            basePriceLabel.Text = "(قیمت پایه (ریال";
            // 
            // basePriceTextBox
            // 
            this.basePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "BasePrice", true));
            this.basePriceTextBox.Location = new System.Drawing.Point(73, 158);
            this.basePriceTextBox.Name = "basePriceTextBox";
            this.basePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.basePriceTextBox.TabIndex = 10;
            // 
            // surchargeLabel
            // 
            surchargeLabel.AutoSize = true;
            surchargeLabel.Location = new System.Drawing.Point(179, 187);
            surchargeLabel.Name = "surchargeLabel";
            surchargeLabel.Size = new System.Drawing.Size(62, 13);
            surchargeLabel.TabIndex = 11;
            surchargeLabel.Text = "(جریمه (ریال";
            // 
            // surchargeTextBox
            // 
            this.surchargeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "Surcharge", true));
            this.surchargeTextBox.Location = new System.Drawing.Point(73, 184);
            this.surchargeTextBox.Name = "surchargeTextBox";
            this.surchargeTextBox.Size = new System.Drawing.Size(100, 20);
            this.surchargeTextBox.TabIndex = 12;
            // 
            // validatePercentLabel
            // 
            validatePercentLabel.AutoSize = true;
            validatePercentLabel.Location = new System.Drawing.Point(179, 213);
            validatePercentLabel.Name = "validatePercentLabel";
            validatePercentLabel.Size = new System.Drawing.Size(74, 13);
            validatePercentLabel.TabIndex = 13;
            validatePercentLabel.Text = "درصد تایید کار";
            // 
            // validatePercentTextBox
            // 
            this.validatePercentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ValidatePercent", true));
            this.validatePercentTextBox.Location = new System.Drawing.Point(73, 210);
            this.validatePercentTextBox.Name = "validatePercentTextBox";
            this.validatePercentTextBox.Size = new System.Drawing.Size(100, 20);
            this.validatePercentTextBox.TabIndex = 14;
            // 
            // areaNumLabel
            // 
            areaNumLabel.AutoSize = true;
            areaNumLabel.Location = new System.Drawing.Point(179, 239);
            areaNumLabel.Name = "areaNumLabel";
            areaNumLabel.Size = new System.Drawing.Size(63, 13);
            areaNumLabel.TabIndex = 15;
            areaNumLabel.Text = "شماره ناحیه";
            // 
            // areaNumTextBox
            // 
            this.areaNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "AreaNum", true));
            this.areaNumTextBox.Location = new System.Drawing.Point(73, 236);
            this.areaNumTextBox.Name = "areaNumTextBox";
            this.areaNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaNumTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(32, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 20);
            this.button1.TabIndex = 17;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActivityFillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(302, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(actNameLabel);
            this.Controls.Add(this.actNameTextBox);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(oLSSNLabel);
            this.Controls.Add(this.oLSSNTextBox);
            this.Controls.Add(unitLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(basePriceLabel);
            this.Controls.Add(this.basePriceTextBox);
            this.Controls.Add(surchargeLabel);
            this.Controls.Add(this.surchargeTextBox);
            this.Controls.Add(validatePercentLabel);
            this.Controls.Add(this.validatePercentTextBox);
            this.Controls.Add(areaNumLabel);
            this.Controls.Add(this.areaNumTextBox);
            this.Controls.Add(this.activityBindingNavigator);
            this.Name = "ActivityFillingForm";
            this.Text = "مشخصات فعالیت";
            this.Load += new System.EventHandler(this.ActivityFillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).EndInit();
            this.activityBindingNavigator.ResumeLayout(false);
            this.activityBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MunicipalityDatabaseDataSet municipalityDatabaseDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ActivityTableAdapter activityTableAdapter;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator activityBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton activityBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox actNameTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox oLSSNTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox basePriceTextBox;
        private System.Windows.Forms.TextBox surchargeTextBox;
        private System.Windows.Forms.TextBox validatePercentTextBox;
        private System.Windows.Forms.TextBox areaNumTextBox;
        private System.Windows.Forms.Button button1;

    }
}