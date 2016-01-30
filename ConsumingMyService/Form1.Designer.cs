namespace ConsumingMyService
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.UnametextBox = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.unameLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DevLstbutton2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EnterAccToklabel1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lsitOfDevotersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lsitOfDevotersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsitOfDevotersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsitOfDevotersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PasstextBox);
            this.panel1.Controls.Add(this.UnametextBox);
            this.panel1.Controls.Add(this.PassLbl);
            this.panel1.Controls.Add(this.unameLbl);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 101);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Access Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PasstextBox
            // 
            this.PasstextBox.Location = new System.Drawing.Point(400, 13);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.Size = new System.Drawing.Size(213, 20);
            this.PasstextBox.TabIndex = 3;
            // 
            // UnametextBox
            // 
            this.UnametextBox.Location = new System.Drawing.Point(91, 13);
            this.UnametextBox.Name = "UnametextBox";
            this.UnametextBox.Size = new System.Drawing.Size(198, 20);
            this.UnametextBox.TabIndex = 2;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.PassLbl.Location = new System.Drawing.Point(327, 13);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(53, 13);
            this.PassLbl.TabIndex = 1;
            this.PassLbl.Text = "Password";
            // 
            // unameLbl
            // 
            this.unameLbl.AutoSize = true;
            this.unameLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.unameLbl.Location = new System.Drawing.Point(7, 13);
            this.unameLbl.Name = "unameLbl";
            this.unameLbl.Size = new System.Drawing.Size(60, 13);
            this.unameLbl.TabIndex = 0;
            this.unameLbl.Text = "User Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(15, 172);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(445, 214);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // DevLstbutton2
            // 
            this.DevLstbutton2.BackColor = System.Drawing.Color.ForestGreen;
            this.DevLstbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DevLstbutton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DevLstbutton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DevLstbutton2.Location = new System.Drawing.Point(459, 20);
            this.DevLstbutton2.Name = "DevLstbutton2";
            this.DevLstbutton2.Size = new System.Drawing.Size(152, 43);
            this.DevLstbutton2.TabIndex = 2;
            this.DevLstbutton2.Text = "Get List Of Devotees";
            this.DevLstbutton2.UseVisualStyleBackColor = false;
            this.DevLstbutton2.Click += new System.EventHandler(this.DevLstbutton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.EnterAccToklabel1);
            this.panel2.Controls.Add(this.DevLstbutton2);
            this.panel2.Location = new System.Drawing.Point(5, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 292);
            this.panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 4;
            // 
            // EnterAccToklabel1
            // 
            this.EnterAccToklabel1.AutoSize = true;
            this.EnterAccToklabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.EnterAccToklabel1.Location = new System.Drawing.Point(10, 20);
            this.EnterAccToklabel1.Name = "EnterAccToklabel1";
            this.EnterAccToklabel1.Size = new System.Drawing.Size(104, 13);
            this.EnterAccToklabel1.TabIndex = 3;
            this.EnterAccToklabel1.Text = "Enter Access Token";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(152, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(302, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(459, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(436, 57);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 214);
            this.vScrollBar1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(457, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 112);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lsitOfDevotersBindingSource1
            // 
            this.lsitOfDevotersBindingSource1.DataSource = typeof(ConsumingMyService.LsitOfDevoters);
            // 
            // lsitOfDevotersBindingSource
            // 
            this.lsitOfDevotersBindingSource.DataSource = typeof(ConsumingMyService.LsitOfDevoters);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 418);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "API Call Application";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsitOfDevotersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsitOfDevotersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource lsitOfDevotersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lsitOfDevotersBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.TextBox UnametextBox;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Label unameLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button DevLstbutton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EnterAccToklabel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}

