using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class ActivityFillingForm : Form
    {
        public ActivityFillingForm(AreaForm af)
        {
            InitializeComponent();
            areaform = af;
        }

        private void activityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void activityBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.activityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void ActivityFillingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Activity' table. You can move, or remove it, as needed.
            this.activityTableAdapter.Fill(this.municipalityDatabaseDataSet.Activity);

        }
        AreaForm areaform;
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            areaform.Show();
        }
    }
}
