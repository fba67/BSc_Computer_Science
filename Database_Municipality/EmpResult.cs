using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class EmpResult : Form
    {
        public EmpResult(string mn,int zn,ZoneForm zf)
        {
            InitializeComponent();
            zoneform = zf;
            empname = mn;
            @zonenum = zn;
        }
        string empname;
        ZoneForm zoneform;
        int @zonenum;
        private void MgrResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Zone' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.municipalityDatabaseDataSet.Employee);
            employeeTableAdapter.FillByEmpName(municipalityDatabaseDataSet.Employee, @empname);
        }

        private void backmgr_Click(object sender, EventArgs e)
        {
            Hide();
            zoneform.Show();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }
    }
}
