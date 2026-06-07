using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class ContractReport : Form
    {
        public ContractReport(string cn,ContractInfoForm ci)
        {
            InitializeComponent();
            @compname = cn;
            contractinfo = ci;
        }
        string @compname;
        private void ContractReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.ContractReport' table. You can move, or remove it, as needed.
            this.contractReportTableAdapter.FillByReport(this.municipalityDatabaseDataSet.ContractReport,@compname);
            

        }
        ContractInfoForm contractinfo;
        private void contrepback_Click(object sender, EventArgs e)
        {
            Hide();
            contractinfo.Show();
        }
    }
}
