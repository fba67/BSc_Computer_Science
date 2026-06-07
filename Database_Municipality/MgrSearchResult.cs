using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class MgrSearchResult : Form
    {
        string @mgrname;
        Form2 form2;
        public MgrSearchResult(string mgrn,Form2 f2)
        {
            InitializeComponent();
            form2 = f2;
            mgrname = mgrn;
        }

        private void zoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void MgrSearchResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Zone' table. You can move, or remove it, as needed.
            this.zoneTableAdapter.FillByMgrname(this.municipalityDatabaseDataSet.Zone,@mgrname);

        }

        private void mgrsearchback_Click(object sender, EventArgs e)
        {
            Hide();
            form2.Show();
        }
    }
}
