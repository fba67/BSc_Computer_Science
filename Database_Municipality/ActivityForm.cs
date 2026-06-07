using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class ActivityForm : Form
    {
        
        public ActivityForm(int a,int z,AreaForm af)
        {
            InitializeComponent();
            @areanum = a;
            @zonenum = z;
            areaform = af;
        }
        AreaForm areaform;
       
        private void ActivityForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Activity' table. You can move, or remove it, as needed.
            
            this.activityTableAdapter.UpdateActivitySalary(@areanum,@zonenum,@actNameTextBox.Text);            
            this.label1.Text = "منطقۀ " + @zonenum.ToString() + " > ";
            this.label2.Text = "ناحیۀ " + @areanum.ToString();
            this.activityViewTableAdapter.FillByActivityView(municipalityDatabaseDataSet.ActivityView, @areanum,@zonenum);
            if (salaryTextBox.Text != "")
            {
                double sal = double.Parse(salaryTextBox.Text);
                int roundedsal = (int)Math.Floor(sal);
                salaryTextBox.Text = roundedsal.ToString();
            }
        }

        private void activityback_Click(object sender, EventArgs e)
        {
            this.Hide();
            areaform.Show();
        }

        private void activityViewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activityViewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            double sal = double.Parse(salaryTextBox.Text);
            int roundedsal = (int)Math.Floor(sal);
            salaryTextBox.Text = roundedsal.ToString();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            double sal = double.Parse(salaryTextBox.Text);
            int roundedsal = (int)Math.Floor(sal);
            salaryTextBox.Text = roundedsal.ToString();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            double sal = double.Parse(salaryTextBox.Text);
            int roundedsal = (int)Math.Floor(sal);
            salaryTextBox.Text = roundedsal.ToString();
        }
    }
}
