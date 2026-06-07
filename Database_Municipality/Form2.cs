using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MunicipalityDisplay
{
    public partial class Form2 : Form
    {
        Form1 f;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            f = f1;
        }
        int zonenumber;
        private void button1_Click(object sender, EventArgs e)
        {
            //f.Close();
            if (textBox1.Text == "")
                MessageBox.Show("لطفاً شماره منطقه را وارد کنید");
            else
            {
                ZoneForm z = new ZoneForm(zonenumber,this);
                this.Hide();
                z.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }
        private bool ISInt(string s){
            for (int i = 0; i < s.Length; i++)
                if (s[i] - '0' > 9 || s[i] - '0' < 0)
                    return false;
            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!ISInt(textBox1.Text))
            {
                MessageBox.Show("لطفاً شماره منطقه را به طرز صحیح وارد کنید");
                textBox1.Text = "";
            }
            else if(textBox1.Text!="")
            {
                zonenumber = int.Parse(textBox1.Text);
            }
        }

        private void MunicipalityEmps_Click(object sender, EventArgs e)
        {
            Hide();
            MunicipalityEmpForm me = new MunicipalityEmpForm(this);
            me.Show();
        }
        string mgrname;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (mgrtextBox.Text == "")
                MessageBox.Show("لطفاً نام مدیر را وارد کنید");
            else
                mgrname = mgrtextBox.Text;
        }

        private void mgrok_Click(object sender, EventArgs e)
        {
            if(mgrtextBox.Text=="")
                MessageBox.Show("لطفاً نام مدیر را وارد کنید");
            else
            {
                Hide();
                MgrSearchResult mgrres = new MgrSearchResult(mgrname, this);
                mgrres.Show();
            }
        }

    }
}
