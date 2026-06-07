using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mine
{

    public partial class Form1 : Form
    {
        public Form1(int a)
        {
            InitializeComponent();
            length = a;
            labeltxt = a + 1;
            btn = new Button[length, length];
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    btn[i, j] = new Button();
        }
        int[,] MSArray ;
        public void MineSweper(int i,int j)
        {
            SetBombs(i,j);
        }
        void SetBombs(int i,int j)
        {
            int counter = 0;

           
            MSArray = new int[length, length];
            while (counter < length + 1)
            {
                Random r = new Random();
                Random c = new Random();
                int row = r.Next(length);
                int col = c.Next(length);
                if (MSArray[row, col] != 10&&row!=i&&col!=j)
                {
                    counter++;
                    MSArray[row, col] = 10;
                }
            }
            for (int s = 0; s < MSArray.GetLength(0); s++)
                for (int t = 0; t < MSArray.GetLength(1); t++)
                    NoofBombs(s, t);
        }
        void NoofBombs(int i, int j)
        {
            int upi = i;
            int dni = i;
            int upj = j;
            int dnj = j;
            if (j - 1 >= 0 && j - 1 < length)
                dnj = j - 1;
            if (j + 1 >= 0 && j + 1 < length)
                upj = j + 1;
            if (i - 1 >= 0 && i - 1 < length)
                dni = i - 1;
            if (i + 1 > 0 && i+1 < length)
                upi = i + 1;
            for (int s = dni; s <= upi; s++)
                for (int t = dnj; t <= upj; t++)
                    if (MSArray[s, t] == 10&&MSArray[i,j]!=10)
                        MSArray[i, j]++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size((length + 6) * 20, (length + 6) * 20);
            this.label1.Size = new Size(50,30);
            label1.Text =labeltxt.ToString()+ "  Bombs!";
            label1.Location = new Point( (length + 1) * 20,30);
            this.Controls.Add(label1);
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                {
                    btn[i, j].Location = new Point(15 + j * 20, 15 + i * 20);
                    btn[i, j].Size = new Size(20, 20);
                    btn[i,j].Name=(i*length+j).ToString();
                    this.btn[i,j].MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
                    this.Controls.Add(btn[i, j]);
                }
        }

        private void _MouseDown(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            Button but = GetBut(b);
            int ind = Convert.ToInt32(but.Name);
            mouseHandler(e, ind, b);
        }
        Button GetBut(Button b)
        {
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                {
                    if (btn[i, j] == b)
                        return btn[i, j];
                }
            return null;
        }

        private void mouseHandler(EventArgs e, int ind, Button b)
        {
            int i = ind  / length;
            int j = ind  % length;
            MouseEventArgs me = (MouseEventArgs)e;
            if (!flag)
            {
                flag = true;
                MineSweper(i,j);
                if(me.Button==MouseButtons.Right)
                    label1.Text=(labeltxt--).ToString()+"  Bombs";
            }
            
            if (me.Button == MouseButtons.Right)
            {
                if (b.Image == null)
                {
                    b.Image = Image.FromFile("flag.jpg");
                    label1.Text = (labeltxt--).ToString()+"  Bombs!";
                }
                else { b.Image = null; label1.Text = (labeltxt++).ToString()+"  Bombs!"; }
                
            }
            else if (me.Button == MouseButtons.Left)
            {
                if (b.Image == null)
                {
                    bool close = false;
                    if (MSArray[i, j] == 10)
                    {
                        b.Image = Image.FromFile("bomb.jpg");
                        MessageBox.Show("You Loose!!");
                        close = true;
                    }
                    else
                    {
                        if (MSArray[i, j] == 0)
                        {
                            Stack<KeyValuePair<int, int>> stk = new Stack<KeyValuePair<int, int>>();
                            stk.Push(new KeyValuePair<int,int>(i,j));
                            btn[i, j].Enabled = false;
                            helpwin++;
                            while (stk.Count != 0)
                            {
                                KeyValuePair<int, int> kvp = stk.Pop();
                                int key = kvp.Key;
                                int val = kvp.Value;
                                btn[key, val].Enabled = false;
                                if (key + 1 < length && btn[key + 1, val].Enabled && MSArray[key + 1, val] == 0 && !stk.Contains(new KeyValuePair<int, int>(key + 1, val)))
                                {
                                    stk.Push(new KeyValuePair<int, int>(key + 1, val));
                                    btn[key + 1, val].Enabled = false; helpwin++;
                                }
                                else
                                    if (key + 1 < length && btn[key + 1, val].Enabled && MSArray[key + 1, val] != 10)
                                    {
                                        btn[key + 1, val].Enabled = false; helpwin++;
                                        btn[key + 1, val].Text = MSArray[key + 1, val].ToString();
                                    }
                                if (key - 1 >= 0 && btn[key - 1, val].Enabled && MSArray[key - 1, val] == 0 && !stk.Contains(new KeyValuePair<int, int>(key - 1, val)))
                                {
                                    btn[key - 1, val].Enabled = false; helpwin++;
                                    stk.Push(new KeyValuePair<int, int>(key - 1, val));
                                }
                                else
                                    if (key - 1 >= 0 && btn[key - 1, val].Enabled && MSArray[key - 1, val] != 10)
                                    {
                                        btn[key - 1, val].Enabled = false; helpwin++;
                                        btn[key - 1, val].Text = MSArray[key - 1, val].ToString();
                                    }
                                if (val + 1 < length && btn[key, val + 1].Enabled && MSArray[key, val + 1] == 0 && !stk.Contains(new KeyValuePair<int, int>(key, val + 1)))
                                {
                                    btn[key, val + 1].Enabled = false; helpwin++;
                                    stk.Push(new KeyValuePair<int, int>(key, val + 1));
                                }
                                else
                                    if (val + 1 < length && btn[key, val + 1].Enabled && MSArray[key, val + 1] != 10)
                                    {
                                        helpwin++;
                                        btn[key, val + 1].Enabled = false;
                                        btn[key, val + 1].Text = MSArray[key, val + 1].ToString();
                                    }
                                if (val - 1 >= 0 && btn[key, val - 1].Enabled && MSArray[key, val - 1] == 0 && !stk.Contains(new KeyValuePair<int, int>(key, val - 1)))
                                {
                                    btn[key, val - 1].Enabled = false;
                                    helpwin++;
                                    stk.Push(new KeyValuePair<int, int>(key, val - 1));
                                }
                                else
                                    if (val - 1 >= 0 && btn[key, val - 1].Enabled && MSArray[key, val - 1] != 10)
                                    {
                                        btn[key, val - 1].Enabled = false; helpwin++;
                                        btn[key, val - 1].Text = MSArray[key, val - 1].ToString();
                                    }
                                if (key + 1 < length && val + 1 < length && btn[key + 1, val + 1].Enabled && MSArray[key + 1, val + 1] == 0 && !stk.Contains(new KeyValuePair<int, int>(key + 1, val + 1)))
                                {
                                    btn[key + 1, val + 1].Enabled = false;
                                    stk.Push(new KeyValuePair<int, int>(key + 1, val + 1)); helpwin++;
                                }
                                else
                                    if (key + 1 < length && val + 1 < length && btn[key + 1, val + 1].Enabled && MSArray[key + 1, val + 1] != 10)
                                    {
                                        btn[key + 1, val + 1].Enabled = false;
                                        btn[key + 1, val + 1].Text = MSArray[key + 1, val + 1].ToString(); helpwin++;
                                    }
                                if (key - 1 >= 0 && val - 1 >= 0 && btn[key - 1, val - 1].Enabled && MSArray[key - 1, val - 1] != 10 && MSArray[key - 1, val - 1] == 0 && !stk.Contains(new KeyValuePair<int, int>(key - 1, val - 1)))
                                {
                                    btn[key - 1, val - 1].Enabled = false;
                                    helpwin++;
                                    stk.Push(new KeyValuePair<int, int>(key - 1, val - 1));
                                }
                                else
                                    if (key - 1 >= 0 && val - 1 >= 0 && btn[key - 1, val - 1].Enabled && MSArray[key - 1, val - 1] != 10)
                                    {
                                        btn[key - 1, val - 1].Enabled = false;
                                        btn[key - 1, val - 1].Text = MSArray[key - 1, val - 1].ToString(); helpwin++;
                                    }
                                if (key - 1 >= 0 && val + 1 < length && btn[key - 1, val + 1].Enabled && MSArray[key - 1, val + 1] == 0 && !stk.Contains(new KeyValuePair<int, int>(key - 1, val + 1)))
                                {
                                    btn[key - 1, val + 1].Enabled = false;
                                    stk.Push(new KeyValuePair<int, int>(key - 1, val + 1)); helpwin++;
                                }
                                else
                                    if (key - 1 >= 0 && val + 1 < length && btn[key - 1, val + 1].Enabled && MSArray[key - 1, val + 1] != 10)
                                    {
                                        btn[key - 1, val + 1].Enabled = false;
                                        btn[key - 1, val + 1].Text = MSArray[key - 1, val + 1].ToString(); helpwin++;
                                    }
                                if (key + 1 < length && val - 1 >= 0 && btn[key + 1, val - 1].Enabled && MSArray[key + 1, val - 1] == 0 && !stk.Contains(new KeyValuePair<int, int>(key + 1, val - 1)))
                                {
                                    btn[key + 1, val - 1].Enabled = false;
                                    helpwin++;
                                    stk.Push(new KeyValuePair<int, int>(key + 1, val - 1));
                                }
                                else
                                    if (key + 1 < length && val - 1 >= 0 && btn[key + 1, val - 1].Enabled && MSArray[key + 1, val - 1] != 10)
                                    {
                                        btn[key + 1, val - 1].Enabled = false; helpwin++;
                                        btn[key + 1, val - 1].Text = MSArray[key + 1, val - 1].ToString();
                                    }
                            }
                        }

                        else
                        {
                            b.Text = MSArray[i, j].ToString();
                            b.Enabled = false;
                            helpwin++;
                        }
                    }
                        if (helpwin == length * (length - 1) - 1)
                        {
                            MessageBox.Show("You Won!!");
                            close = true;
                        }
                        if (close)
                        {
                            Close();
                        }
                    
                }
            }
            
        }


    } 
}