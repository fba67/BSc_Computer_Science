namespace MunicipalityDisplay
{
    partial class ContractReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractReport));
            this.municipalityDatabaseDataSet = new MunicipalityDisplay.MunicipalityDatabaseDataSet();
            this.contractReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractReportTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ContractReportTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.contractReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contractReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contractReportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrepback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractReportBindingNavigator)).BeginInit();
            this.contractReportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // municipalityDatabaseDataSet
            // 
            this.municipalityDatabaseDataSet.DataSetName = "MunicipalityDatabaseDataSet";
            this.municipalityDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractReportBindingSource
            // 
            this.contractReportBindingSource.DataMember = "ContractReport";
            this.contractReportBindingSource.DataSource = this.municipalityDatabaseDataSet;
            // 
            // contractReportTableAdapter
            // 
            this.contractReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Contractor_CompanyTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OnlookerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZoneTableAdapter = null;
            // 
            // contractReportBindingNavigator
            // 
            this.contractReportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractReportBindingNavigator.BindingSource = this.contractReportBindingSource;
            this.contractReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractReportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contractReportBindingNavigatorSaveItem});
            this.contractReportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractReportBindingNavigator.Name = "contractReportBindingNavigator";
            this.contractReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractReportBindingNavigator.Size = new System.Drawing.Size(396, 25);
            this.contractReportBindingNavigator.TabIndex = 0;
            this.contractReportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // contractReportBindingNavigatorSaveItem
            // 
            this.contractReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractReportBindingNavigatorSaveItem.Enabled = false;
            this.contractReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractReportBindingNavigatorSaveItem.Image")));
            this.contractReportBindingNavigatorSaveItem.Name = "contractReportBindingNavigatorSaveItem";
            this.contractReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contractReportBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // contractReportDataGridView
            // 
            this.contractReportDataGridView.AutoGenerateColumns = false;
            this.contractReportDataGridView.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.contractReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.contractReportDataGridView.DataSource = this.contractReportBindingSource;
            this.contractReportDataGridView.Location = new System.Drawing.Point(24, 47);
            this.contractReportDataGridView.Name = "contractReportDataGridView";
            this.contractReportDataGridView.Size = new System.Drawing.Size(343, 220);
            this.contractReportDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AreaNum";
            this.dataGridViewTextBoxColumn1.HeaderText = "شماره ناحیه";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ZoneNum";
            this.dataGridViewTextBoxColumn2.HeaderText = "شماره منطقه";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "turnover";
            this.dataGridViewTextBoxColumn3.HeaderText = "عملکرد";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // contrepback
            // 
            this.contrepback.BackColor = System.Drawing.Color.Aquamarine;
            this.contrepback.Location = new System.Drawing.Point(24, 302);
            this.contrepback.Name = "contrepback";
            this.contrepback.Size = new System.Drawing.Size(60, 20);
            this.contrepback.TabIndex = 2;
            this.contrepback.Text = "بازگشت";
            this.contrepback.UseVisualStyleBackColor = false;
            this.contrepback.Click += new System.EventHandler(this.contrepback_Click);
            // 
            // ContractReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(396, 342);
            this.Controls.Add(this.contrepback);
            this.Controls.Add(this.contractReportDataGridView);
            this.Controls.Add(this.contractReportBindingNavigator);
            this.Name = "ContractReport";
            this.Text = "سابقۀ شرکت";
            this.Load += new System.EventHandler(this.ContractReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractReportBindingNavigator)).EndInit();
            this.contractReportBindingNavigator.ResumeLayout(false);
            this.contractReportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MunicipalityDatabaseDataSet municipalityDatabaseDataSet;
        private System.Windows.Forms.BindingSource contractReportBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ContractReportTableAdapter contractReportTableAdapter;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractReportBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contractReportBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView contractReportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button contrepback;
    }
}