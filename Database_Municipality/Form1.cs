using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);
            //this.employeeTableAdapter.Fill(this.municipalityDatabaseDataSet.Employee);
            //this.employeeTableAdapter.UpdateQuery(municipalityDatabaseDataSet.Employee.EmpNameColumn.ToString(), municipalityDatabaseDataSet.Employee.AreaNumColumn.ToString(), municipalityDatabaseDataSet.Employee.ZoneNumColumn.ToString(), int.Parse(municipalityDatabaseDataSet.Employee.EmpSalaryColumn.ToString()));
            this.employeeTableAdapter.Update(this.municipalityDatabaseDataSet.Employee);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.municipalityDatabaseDataSet.Employee);
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 enter = new Form2( this);
            enter.ShowDialog(); 
        }
       
    }
}
