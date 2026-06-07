using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class ContracForm : Form
    {
        AreaForm areaform;
        public ContracForm(int a,int z,string cn,AreaForm af)
        {
            InitializeComponent();
            @areanum = a;
            @zonenum = z;
            @compname = cn;
            areaform = af;
        }

        private void contractor_CompanyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractor_CompanyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void ContracForm_Load(object sender, EventArgs e)
        {
            contractor_CompanyTableAdapter.UpdateSalary(@areanum, @zonenum, @compname);

            contractor_CompanyTableAdapter.FillBycontract(municipalityDatabaseDataSet.Contractor_Company, @areanum, @zonenum);
            this.label1.Text = "منطقۀ " + @zonenum.ToString() + " > ";
            this.label2.Text = "ناحیۀ " + @areanum.ToString();
        }

        private void contractback_Click(object sender, EventArgs e)
        {
            this.Hide();
            areaform.Show();
        }

        private void contreport_Click(object sender, EventArgs e)
        {
            Hide();
            //ContractReport cr = new ContractReport(compname,this);
            //cr.Show();
        }
    }
}
