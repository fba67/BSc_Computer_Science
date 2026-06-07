namespace MunicipalityDisplay
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zoneok = new System.Windows.Forms.Button();
            this.zonenum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MunicipalityEmps = new System.Windows.Forms.Button();
            this.mgrtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mgrok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zoneok
            // 
            this.zoneok.BackColor = System.Drawing.Color.Aquamarine;
            this.zoneok.Location = new System.Drawing.Point(150, 73);
            this.zoneok.Name = "zoneok";
            this.zoneok.Size = new System.Drawing.Size(75, 23);
            this.zoneok.TabIndex = 0;
            this.zoneok.Text = "تایید";
            this.zoneok.UseVisualStyleBackColor = false;
            this.zoneok.Click += new System.EventHandler(this.button1_Click);
            // 
            // zonenum
            // 
            this.zonenum.AutoSize = true;
            this.zonenum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.zonenum.Location = new System.Drawing.Point(135, 40);
            this.zonenum.Name = "zonenum";
            this.zonenum.Size = new System.Drawing.Size(213, 13);
            this.zonenum.TabIndex = 1;
            this.zonenum.Text = "لطفاَ شماره منطقۀ مورد نظر خود را وارد نمایید";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MunicipalityEmps
            // 
            this.MunicipalityEmps.BackColor = System.Drawing.Color.Aquamarine;
            this.MunicipalityEmps.Location = new System.Drawing.Point(111, 127);
            this.MunicipalityEmps.Name = "MunicipalityEmps";
            this.MunicipalityEmps.Size = new System.Drawing.Size(162, 23);
            this.MunicipalityEmps.TabIndex = 3;
            this.MunicipalityEmps.Text = "لیست تمام کارمندان شهرداری";
            this.MunicipalityEmps.UseVisualStyleBackColor = false;
            this.MunicipalityEmps.Click += new System.EventHandler(this.MunicipalityEmps_Click);
            // 
            // mgrtextBox
            // 
            this.mgrtextBox.Location = new System.Drawing.Point(73, 190);
            this.mgrtextBox.Name = "mgrtextBox";
            this.mgrtextBox.Size = new System.Drawing.Size(100, 20);
            this.mgrtextBox.TabIndex = 4;
            this.mgrtextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "جستجو براساس مدیر منطقه";
            // 
            // mgrok
            // 
            this.mgrok.BackColor = System.Drawing.Color.Aquamarine;
            this.mgrok.Location = new System.Drawing.Point(150, 226);
            this.mgrok.Name = "mgrok";
            this.mgrok.Size = new System.Drawing.Size(75, 23);
            this.mgrok.TabIndex = 6;
            this.mgrok.Text = "تایید";
            this.mgrok.UseVisualStyleBackColor = false;
            this.mgrok.Click += new System.EventHandler(this.mgrok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 304);
            this.Controls.Add(this.mgrok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mgrtextBox);
            this.Controls.Add(this.MunicipalityEmps);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zonenum);
            this.Controls.Add(this.zoneok);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "سیستم فضای سبز شهرداری";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zoneok;
        private System.Windows.Forms.Label zonenum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MunicipalityEmps;
        private System.Windows.Forms.TextBox mgrtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mgrok;
    }
}