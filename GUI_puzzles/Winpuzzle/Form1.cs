using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace winpuzzle
{
    public partial class Form1 : Form
    {
        public Form1(int a)
        {
            InitializeComponent();
            length = a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button = new Button[length, length];
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                {
                    button[i, j] = new System.Windows.Forms.Button();

                    if (i == length - 1 && j == length - 1)
                    {
                        button[i, j].Text = "";
                        button[i, j].FlatStyle = FlatStyle.Flat;
                    }
                    else
                        button[i, j].Text = (i * length + j + 1).ToString();
                    this.button[i, j].Name = "button" + (i * length + j).ToString();
                    this.button[i, j].TabIndex = 0;
                    this.button[i, j].UseVisualStyleBackColor = true;
                    this.button[i, j].Size = new System.Drawing.Size(30, 30);
                    this.button[i, j].Location = new System.Drawing.Point(20 + 30 * j, 20 + 30 * i);
                    this.button[i, j].Click += new EventHandler(this.Button_Clicked);
                    this.Controls.Add(button[i, j]);
                }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            int x, y;
            Button empty = GetEmptyLoc();
            x = empty.Location.X;
            y = empty.Location.Y;
            Button btn = (Button)sender;
            int X = btn.Location.X;
            int Y = btn.Location.Y;
            if ((X - 30 == x && Y == y) || ((X + 30 == x) && (Y == y)) || (X == x && Y - 30 == y) || (X == x && Y + 30 == y))
            {
                Point btnpoint = new Point(x, y);
                Point emptypoint = new Point(X, Y);
                btn.Location = btnpoint;
                empty.Location = emptypoint;
            }
            if (IsCorrect())
                MessageBox.Show("Puzzle Solved!");
        }
        private Button GetEmptyLoc()
        {
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)

                    if (button[i, j].Text == "")
                        return button[i, j];
            return null;
        }

        Button getButton(int x, int y)
        {
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    if (button[i, j].Location.X == x && button[i, j].Location.Y == y)
                        return button[i, j];
            return null;
        }
        bool IsCorrect()
        {
            int cnt = 1;
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++, cnt++)
                {
                    int x = 20 + 30 * j;
                    int y = 20 + 30 * i;
                    Button b = getButton(x, y);
                    if (cnt != length * length && b.Text != cnt.ToString())
                        return false;
                }
            return true;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int cnt = 0, ind1 = 0;
            ArrayList rand = new ArrayList();
            while (cnt < length * length)
            {
                Random r = new Random();
                int ind = r.Next(length * length);
                if (!rand.Contains(ind))
                {
                    rand.Add(ind);
                    cnt++;
                }
            }

            for (int x = 0; x < length; x++)
                for (int y = 0; y < length; y++)
                {
                    if (!rand[ind1].Equals(0))
                    {
                        button[x, y].Text = rand[ind1++].ToString();
                        button[x, y].FlatStyle = FlatStyle.Standard;
                    }
                    else
                    {
                        ind1++;
                        button[x, y].Text = "";
                        button[x, y].FlatStyle = FlatStyle.Flat;
                    }

                }
        }
    }
}