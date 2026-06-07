using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class AreaForm : Form
    {
        ZoneForm zoneform;
        public AreaForm(int arnm,int zn,ZoneForm zf)
        {
            InitializeComponent();
            @areanum = arnm;
            @zonenum = zn;
            zoneform = zf;
        }

        private void areaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void AreaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Area' table. You can move, or remove it, as needed.
            //try
            //{
            //    //this.areaTableAdapter.Fill(this.municipalityDatabaseDataSet.Area);
            //    this.areaTableAdapter.FillByAreanum(municipalityDatabaseDataSet.Area,@zonenum,@areanum);
            //}
            //catch (ConstraintException)
            //{

            //    MessageBox.Show("eshtebaah");
            //}
            this.areaTableAdapter.FillByAreanum(municipalityDatabaseDataSet.Area, @zonenum, @areanum);
            
            this.areaemp.Text = "کارمندان ناحیۀ " + @areanum.ToString();
            this.label1.Text = "منطقۀ "+@zonenum.ToString()+" > ";
            this.label2.Text = "ناحیۀ " + @areanum.ToString();
            this.areactivity.Text ="فعالیت های ناحیۀ "+@areanum.ToString();
            
        }

        private void areaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            ContractInfoForm contract = new ContractInfoForm(@areanum, @zonenum, compname,this);
            contract.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivityForm activity = new ActivityForm(@areanum, @zonenum,this);
            activity.Show();
        }

        private void areaemp_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpForm emp = new EmpForm(@areanum, @zonenum,this);
            emp.Show();
        }
        string compname;
        private void compNameTextBox_TextChanged(object sender, EventArgs e)
        {
            compname = compNameTextBox.Text;
        }

        private void areaback_Click(object sender, EventArgs e)
        {
            Hide();
            zoneform.Show();
        }

        private void contractbut_Click(object sender, EventArgs e)
        {
            Hide();
            ContractForm cf = new ContractForm(this);
            cf.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            OnlookerForm ol = new OnlookerForm(this);
            ol.Show();
        }

        private void activityeditbut_Click(object sender, EventArgs e)
        {
            Hide();
            ActivityFillingForm af = new ActivityFillingForm(this);
            af.Show();
        }

        
    }
}
