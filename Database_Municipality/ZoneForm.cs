using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class ZoneForm : Form
    {
        int @zonenum;
        public ZoneForm(int zn,Form2 f2)
        {
            InitializeComponent();
            @zonenum = zn;
            form2 = f2;
        }

        private void zoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.municipalityDatabaseDataSet);

        }

        private void Zone_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'municipalityDatabaseDataSet.Zone' table. You can move, or remove it, as needed.
            //this.zoneTableAdapter.Fill(this.municipalityDatabaseDataSet.Zone);
            zoneTableAdapter.FillByZoneNum(municipalityDatabaseDataSet.Zone,@zonenum);
            textBox1.Text = "1";
            zonelabel.Text = "منطقۀ "+zonenum;
        }
        private bool ISInt(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (s[i] - '0' > 9 || s[i] - '0' < 0)
                    return false;
            return true;
        }
        int @areanum;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!ISInt(textBox1.Text))
            {
                MessageBox.Show("لطفاً شماره ناحیه را به طرز صحیح وارد کنید");
                textBox1.Text = "";
            }
            else if (textBox1.Text != "")
            {
                areanum = int.Parse(textBox1.Text);
            }
        }

        private void areaok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("لطفاً شماره ناحیه را وارد کنید");
            else
            {
                AreaForm area = new AreaForm(@areanum, @zonenum,this);
                this.Hide();
                area.ShowDialog();
            }
        }
        string empname;
        private void mgrzonetextBox_TextChanged(object sender, EventArgs e)
        {
            if (empzonetextBox.Text == "لطفاً نام کارمند را وارد کنید")
                MessageBox.Show("");
            else
            empname = empzonetextBox.Text;
        }

        private void searchmagrzone_Click(object sender, EventArgs e)
        {
            if (empzonetextBox.Text == "")
                MessageBox.Show("لطفاً نام کارمند را وارد کنید");
            else
            {
                Hide();
                EmpResult mg = new EmpResult(empname, @zonenum, this);
                mg.Show();
            }
        }

        private void startDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        Form2 form2;
        private void zoneback_Click(object sender, EventArgs e)
        {
            Hide();
            form2.Show();
        }

        
    }
}
