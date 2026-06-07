using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class MunicipalityEmpForm : Form
    {
        public MunicipalityEmpForm(Form2 f2)
        {
            InitializeComponent();
            form2 = f2;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void MunicipalityEmpForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.municipalityDatabaseDataSet.Employee);

        }
        Form2 form2;
        private void munempback_Click(object sender, EventArgs e)
        {
            Hide();
            form2.Show();
        }
    }
}
