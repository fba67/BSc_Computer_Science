namespace MunicipalityDisplay
{
    partial class ContractInfoForm
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
            System.Windows.Forms.Label contractNumLabel;
            System.Windows.Forms.Label oLNameLabel;
            System.Windows.Forms.Label agentNameLabel;
            System.Windows.Forms.Label onlookerSSNLabel;
            System.Windows.Forms.Label compNameLabel;
            System.Windows.Forms.Label p_MLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label areaNumLabel;
            System.Windows.Forms.Label zoneNumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractInfoForm));
            this.contractInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.contractInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.contractInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contractNumTextBox = new System.Windows.Forms.TextBox();
            this.oLNameTextBox = new System.Windows.Forms.TextBox();
            this.agentNameTextBox = new System.Windows.Forms.TextBox();
            this.onlookerSSNTextBox = new System.Windows.Forms.TextBox();
            this.compNameTextBox = new System.Windows.Forms.TextBox();
            this.p_MTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.areaNumTextBox = new System.Windows.Forms.TextBox();
            this.zoneNumTextBox = new System.Windows.Forms.TextBox();
            this.contractreport = new System.Windows.Forms.Button();
            this.contreportback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contractInfoTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ContractInfoTableAdapter();
            this.tableAdapterManager = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager();
            this.contractor_CompanyTableAdapter = new MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.Contractor_CompanyTableAdapter();
            this.contractor_CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            contractNumLabel = new System.Windows.Forms.Label();
            oLNameLabel = new System.Windows.Forms.Label();
            agentNameLabel = new System.Windows.Forms.Label();
            onlookerSSNLabel = new System.Windows.Forms.Label();
            compNameLabel = new System.Windows.Forms.Label();
            p_MLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            areaNumLabel = new System.Windows.Forms.Label();
            zoneNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoBindingNavigator)).BeginInit();
            this.contractInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contractNumLabel
            // 
            contractNumLabel.AutoSize = true;
            contractNumLabel.Location = new System.Drawing.Point(277, 72);
            contractNumLabel.Name = "contractNumLabel";
            contractNumLabel.Size = new System.Drawing.Size(71, 13);
            contractNumLabel.TabIndex = 1;
            contractNumLabel.Text = "شماره قرارداد";
            // 
            // oLNameLabel
            // 
            oLNameLabel.AutoSize = true;
            oLNameLabel.Location = new System.Drawing.Point(277, 98);
            oLNameLabel.Name = "oLNameLabel";
            oLNameLabel.Size = new System.Drawing.Size(43, 13);
            oLNameLabel.TabIndex = 3;
            oLNameLabel.Text = "نام ناظر";
            // 
            // agentNameLabel
            // 
            agentNameLabel.AutoSize = true;
            agentNameLabel.Location = new System.Drawing.Point(276, 151);
            agentNameLabel.Name = "agentNameLabel";
            agentNameLabel.Size = new System.Drawing.Size(55, 13);
            agentNameLabel.TabIndex = 5;
            agentNameLabel.Text = "نام نماینده";
            // 
            // onlookerSSNLabel
            // 
            onlookerSSNLabel.AutoSize = true;
            onlookerSSNLabel.Location = new System.Drawing.Point(276, 125);
            onlookerSSNLabel.Name = "onlookerSSNLabel";
            onlookerSSNLabel.Size = new System.Drawing.Size(63, 13);
            onlookerSSNLabel.TabIndex = 7;
            onlookerSSNLabel.Text = "کد ملی ناظر";
            // 
            // compNameLabel
            // 
            compNameLabel.AutoSize = true;
            compNameLabel.Location = new System.Drawing.Point(277, 176);
            compNameLabel.Name = "compNameLabel";
            compNameLabel.Size = new System.Drawing.Size(102, 13);
            compNameLabel.TabIndex = 9;
            compNameLabel.Text = "نام شرکت پیمانکاری";
            // 
            // p_MLabel
            // 
            p_MLabel.AutoSize = true;
            p_MLabel.Location = new System.Drawing.Point(277, 202);
            p_MLabel.Name = "p_MLabel";
            p_MLabel.Size = new System.Drawing.Size(62, 13);
            p_MLabel.TabIndex = 11;
            p_MLabel.Text = "پلوس/مینوس";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(276, 228);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(62, 13);
            salaryLabel.TabIndex = 13;
            salaryLabel.Text = "(حقوق (ریال";
            // 
            // areaNumLabel
            // 
            areaNumLabel.AutoSize = true;
            areaNumLabel.Location = new System.Drawing.Point(277, 254);
            areaNumLabel.Name = "areaNumLabel";
            areaNumLabel.Size = new System.Drawing.Size(63, 13);
            areaNumLabel.TabIndex = 15;
            areaNumLabel.Text = "شماره ناحیه";
            // 
            // zoneNumLabel
            // 
            zoneNumLabel.AutoSize = true;
            zoneNumLabel.Location = new System.Drawing.Point(277, 280);
            zoneNumLabel.Name = "zoneNumLabel";
            zoneNumLabel.Size = new System.Drawing.Size(65, 13);
            zoneNumLabel.TabIndex = 17;
            zoneNumLabel.Text = "شماره منطقه";
            // 
            // contractInfoBindingNavigator
            // 
            this.contractInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractInfoBindingNavigator.BindingSource = this.contractInfoBindingSource;
            this.contractInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contractInfoBindingNavigatorSaveItem});
            this.contractInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractInfoBindingNavigator.Name = "contractInfoBindingNavigator";
            this.contractInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractInfoBindingNavigator.Size = new System.Drawing.Size(408, 25);
            this.contractInfoBindingNavigator.TabIndex = 0;
            this.contractInfoBindingNavigator.Text = "bindingNavigator1";
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
            // contractInfoBindingSource
            // 
            this.contractInfoBindingSource.DataMember = "ContractInfo";
            this.contractInfoBindingSource.DataSource = this.municipalityDatabaseDataSet;
            // 
            // municipalityDatabaseDataSet
            // 
            this.municipalityDatabaseDataSet.DataSetName = "MunicipalityDatabaseDataSet";
            this.municipalityDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // contractInfoBindingNavigatorSaveItem
            // 
            this.contractInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractInfoBindingNavigatorSaveItem.Enabled = false;
            this.contractInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractInfoBindingNavigatorSaveItem.Image")));
            this.contractInfoBindingNavigatorSaveItem.Name = "contractInfoBindingNavigatorSaveItem";
            this.contractInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contractInfoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // contractNumTextBox
            // 
            this.contractNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoBindingSource, "ContractNum", true));
            this.contractNumTextBox.Location = new System.Drawing.Point(160, 65);
            this.contractNumTextBox.Name = "contractNumTextBox";
            this.contractNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.contractNumTextBox.TabIndex = 2;
            // 
            // oLNameTextBox
            // 
            this.oLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoBindingSource, "OLName", true));
            this.oLNameTextBox.Location = new System.Drawing.Point(160, 91);
            this.oLNameTextBox.Name = "oLNameTextBox";
            this.oLNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.oLNameTextBox.TabIndex = 4;
            // 
            // agentNameTextBox
            // 
            this.agentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoBindingSource, "AgentName", true));
            this.agentNameTextBox.Location = new System.Drawing.Point(160, 144);
            this.agentNameTextBox.Name = "agentNameTextBox";
            this.agentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.agentNameTextBox.TabIndex = 6;
            // 
            // onlookerSSNTextBox
            // 
            this.onlookerSSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoBindingSource, "OnlookerSSN", true));
            this.onlookerSSNTextBox.Location = new System.Drawing.Point(160, 118);
            this.onlookerSSNTextBox.Name = "onlookerSSNTextBox";
            this.onlookerSSNTextBox.Size = new System.Drawing.Size(100, 20);
            this.onlookerSSNTextBox.TabIndex = 8;
            // 
            // compNameTextBox
            // 
            this.compNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoBindingSource, "CompName", true));
            this.compNameTextBox.Location = new System.Drawing.Point(160, 169);
            this.compNameTextBox.Name = "compNameTextBox";
            this.compNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.compNameTextBox.TabIndex = 10;
            // 
            // p_MTextBox
            // 
            this.p_MTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoBindingSource, "P_M", true));
            this.p_MTextBox.Location = new System.Drawing.Point(160, 195);
            this.p_MTextBox.Name = "p_MTextBox";
            this.p_MTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_MTextBox.TabIndex = 12;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(160, 221);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 14;
            // 
            // areaNumTextBox
            // 
            this.areaNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoBindingSource, "AreaNum", true));
            this.areaNumTextBox.Location = new System.Drawing.Point(160, 247);
            this.areaNumTextBox.Name = "areaNumTextBox";
            this.areaNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaNumTextBox.TabIndex = 16;
            // 
            // zoneNumTextBox
            // 
            this.zoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractInfoBindingSource, "ZoneNum", true));
            this.zoneNumTextBox.Location = new System.Drawing.Point(160, 273);
            this.zoneNumTextBox.Name = "zoneNumTextBox";
            this.zoneNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.zoneNumTextBox.TabIndex = 18;
            // 
            // contractreport
            // 
            this.contractreport.BackColor = System.Drawing.Color.Aquamarine;
            this.contractreport.Location = new System.Drawing.Point(79, 167);
            this.contractreport.Name = "contractreport";
            this.contractreport.Size = new System.Drawing.Size(75, 23);
            this.contractreport.TabIndex = 19;
            this.contractreport.Text = "سابقۀ شرکت";
            this.contractreport.UseVisualStyleBackColor = false;
            this.contractreport.Click += new System.EventHandler(this.contractreport_Click);
            // 
            // contreportback
            // 
            this.contreportback.BackColor = System.Drawing.Color.Aquamarine;
            this.contreportback.Location = new System.Drawing.Point(79, 320);
            this.contreportback.Name = "contreportback";
            this.contreportback.Size = new System.Drawing.Size(75, 23);
            this.contreportback.TabIndex = 20;
            this.contreportback.Text = "بازگشت";
            this.contreportback.UseVisualStyleBackColor = false;
            this.contreportback.Click += new System.EventHandler(this.contreportback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // contractInfoTableAdapter
            // 
            this.contractInfoTableAdapter.ClearBeforeFill = true;
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
            // contractor_CompanyTableAdapter
            // 
            this.contractor_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // contractor_CompanyBindingSource
            // 
            this.contractor_CompanyBindingSource.DataMember = "Contractor_Company";
            this.contractor_CompanyBindingSource.DataSource = this.municipalityDatabaseDataSet;
            // 
            // ContractInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(408, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contreportback);
            this.Controls.Add(this.contractreport);
            this.Controls.Add(contractNumLabel);
            this.Controls.Add(this.contractNumTextBox);
            this.Controls.Add(oLNameLabel);
            this.Controls.Add(this.oLNameTextBox);
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
            this.Controls.Add(areaNumLabel);
            this.Controls.Add(this.areaNumTextBox);
            this.Controls.Add(zoneNumLabel);
            this.Controls.Add(this.zoneNumTextBox);
            this.Controls.Add(this.contractInfoBindingNavigator);
            this.Name = "ContractInfoForm";
            this.Text = "مشخصات قرارداد";
            this.Load += new System.EventHandler(this.ContractInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoBindingNavigator)).EndInit();
            this.contractInfoBindingNavigator.ResumeLayout(false);
            this.contractInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractor_CompanyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MunicipalityDatabaseDataSet municipalityDatabaseDataSet;
        private System.Windows.Forms.BindingSource contractInfoBindingSource;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.ContractInfoTableAdapter contractInfoTableAdapter;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contractInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contractNumTextBox;
        private System.Windows.Forms.TextBox oLNameTextBox;
        private System.Windows.Forms.TextBox agentNameTextBox;
        private System.Windows.Forms.TextBox onlookerSSNTextBox;
        private System.Windows.Forms.TextBox compNameTextBox;
        private System.Windows.Forms.TextBox p_MTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox areaNumTextBox;
        private System.Windows.Forms.TextBox zoneNumTextBox;
        private System.Windows.Forms.Button contractreport;
        private System.Windows.Forms.Button contreportback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MunicipalityDisplay.MunicipalityDatabaseDataSetTableAdapters.Contractor_CompanyTableAdapter contractor_CompanyTableAdapter;
        private System.Windows.Forms.BindingSource contractor_CompanyBindingSource;
    }
}