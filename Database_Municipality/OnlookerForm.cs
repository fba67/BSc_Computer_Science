using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class OnlookerForm : Form
    {
        public OnlookerForm(AreaForm af)
        {
            InitializeComponent();
            areaform = af;
        }

        private void onlookerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.onlookerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void onlookerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.onlookerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void OnlookerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Onlooker' table. You can move, or remove it, as needed.
            this.onlookerTableAdapter.Fill(this.municipalityDatabaseDataSet.Onlooker);

        }
        AreaForm areaform;
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            areaform.Show();
        }
    }
}
