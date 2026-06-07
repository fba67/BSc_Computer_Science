using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class ContractForm : Form
    {
        public ContractForm(AreaForm af)
        {
            InitializeComponent();
            areaform = af;
        }
        AreaForm areaform;
        private void contractor_CompanyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractor_CompanyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void contractor_CompanyBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.contractor_CompanyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Contractor_Company' table. You can move, or remove it, as needed.
            this.contractor_CompanyTableAdapter.Fill(this.municipalityDatabaseDataSet.Contractor_Company);

        }

        private void contractback_Click(object sender, EventArgs e)
        {
            Hide();
            areaform.Show();
        }
    }
}
