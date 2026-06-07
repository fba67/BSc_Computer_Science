using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class EmpForm : Form
    {
        int @areanum, @zonenum;
        AreaForm areaform;
        public EmpForm(int a,int z,AreaForm af)
        {
            InitializeComponent();
            @areanum = a;
            @zonenum = z;
            areaform = af;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void EmpForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.municipalityDatabaseDataSet.Employee);
            employeeTableAdapter.FillByemp(municipalityDatabaseDataSet.Employee, @areanum, @zonenum);
            this.label1.Text = "منطقۀ " + @zonenum.ToString() + " > ";
            this.label2.Text = "ناحیۀ " + @areanum.ToString();
        }

        private void empback_Click(object sender, EventArgs e)
        {
            this.Hide();
            areaform.Show();
        }

        
    }
}
