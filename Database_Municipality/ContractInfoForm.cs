using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class ContractInfoForm : Form
    {
        public ContractInfoForm(int a,int z,string cn,AreaForm af)
        {
            InitializeComponent();
            areaform = af;
            @areanum = a;
            @zonenum = z;
            @compname = cn;
        }
        int @areanum, @zonenum;
        string @compname;
        private void ContractInfoForm_Load(object sender, EventArgs e)
        {
            this.label1.Text = "منطقۀ " + @zonenum.ToString() + " > ";
            this.label2.Text = "ناحیۀ " + @areanum.ToString();
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Contractor_Company' table. You can move, or remove it, as needed.
            if (compNameTextBox.Text != "")
            {
                this.contractInfoTableAdapter.FillByContractInfo(this.municipalityDatabaseDataSet.ContractInfo, @areanum, @zonenum, @compname);

                this.contractor_CompanyTableAdapter.UpdateSalary(@areanum, @zonenum, @compname);
                // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.ContractInfo' table. You can move, or remove it, as needed.

                double sal = double.Parse(salaryTextBox.Text);
                int roundedsal = (int)Math.Floor(sal);
                salaryTextBox.Text = roundedsal.ToString();
            }
        }

        private void contractreport_Click(object sender, EventArgs e)
        {
            Hide();
            ContractReport cr = new ContractReport(compname,this);
            cr.Show();
        }
        AreaForm areaform;
        private void contreportback_Click(object sender, EventArgs e)
        {
            this.Hide();
            areaform.Show();
        }
    }
}
