namespace Pataints_Managment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.MastxtDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MastxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.RbMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lalSex = new System.Windows.Forms.Label();
            this.lalAge = new System.Windows.Forms.Label();
            this.lalDate = new System.Windows.Forms.Label();
            this.lalPhone = new System.Windows.Forms.Label();
            this.lalName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.MastxtDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MastxtPhone);
            this.groupBox1.Controls.Add(this.RbFemale);
            this.groupBox1.Controls.Add(this.RbMale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(29, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pataint Info";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(355, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 54);
            this.button2.TabIndex = 12;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(355, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(133, 78);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(145, 35);
            this.txtAge.TabIndex = 9;
            this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtAge_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 25);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 35);
            this.txtName.TabIndex = 8;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // MastxtDate
            // 
            this.MastxtDate.BeepOnError = true;
            this.MastxtDate.Location = new System.Drawing.Point(133, 135);
            this.MastxtDate.Mask = "00/00/0000";
            this.MastxtDate.Name = "MastxtDate";
            this.MastxtDate.Size = new System.Drawing.Size(145, 26);
            this.MastxtDate.TabIndex = 7;
            this.MastxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(24, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date";
            // 
            // MastxtPhone
            // 
            this.MastxtPhone.BeepOnError = true;
            this.MastxtPhone.Location = new System.Drawing.Point(133, 187);
            this.MastxtPhone.Mask = "000-000-000";
            this.MastxtPhone.Name = "MastxtPhone";
            this.MastxtPhone.Size = new System.Drawing.Size(145, 26);
            this.MastxtPhone.TabIndex = 5;
            // 
            // RbFemale
            // 
            this.RbFemale.AutoSize = true;
            this.RbFemale.Location = new System.Drawing.Point(218, 247);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(85, 24);
            this.RbFemale.TabIndex = 4;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = true;
            // 
            // RbMale
            // 
            this.RbMale.AutoSize = true;
            this.RbMale.Checked = true;
            this.RbMale.Location = new System.Drawing.Point(93, 247);
            this.RbMale.Name = "RbMale";
            this.RbMale.Size = new System.Drawing.Size(66, 24);
            this.RbMale.TabIndex = 3;
            this.RbMale.TabStop = true;
            this.RbMale.Text = "Male";
            this.RbMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(28, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(425, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Managment System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 55);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lalSex);
            this.groupBox2.Controls.Add(this.lalAge);
            this.groupBox2.Controls.Add(this.lalDate);
            this.groupBox2.Controls.Add(this.lalPhone);
            this.groupBox2.Controls.Add(this.lalName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(29, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ID Card";
            // 
            // lalSex
            // 
            this.lalSex.AutoSize = true;
            this.lalSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lalSex.Location = new System.Drawing.Point(409, 44);
            this.lalSex.Name = "lalSex";
            this.lalSex.Size = new System.Drawing.Size(0, 25);
            this.lalSex.TabIndex = 16;
            // 
            // lalAge
            // 
            this.lalAge.AutoSize = true;
            this.lalAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lalAge.Location = new System.Drawing.Point(409, 117);
            this.lalAge.Name = "lalAge";
            this.lalAge.Size = new System.Drawing.Size(0, 25);
            this.lalAge.TabIndex = 15;
            // 
            // lalDate
            // 
            this.lalDate.AutoSize = true;
            this.lalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lalDate.Location = new System.Drawing.Point(157, 226);
            this.lalDate.Name = "lalDate";
            this.lalDate.Size = new System.Drawing.Size(0, 25);
            this.lalDate.TabIndex = 14;
            // 
            // lalPhone
            // 
            this.lalPhone.AutoSize = true;
            this.lalPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lalPhone.Location = new System.Drawing.Point(157, 135);
            this.lalPhone.Name = "lalPhone";
            this.lalPhone.Size = new System.Drawing.Size(0, 25);
            this.lalPhone.TabIndex = 13;
            // 
            // lalName
            // 
            this.lalName.AutoSize = true;
            this.lalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lalName.Location = new System.Drawing.Point(157, 44);
            this.lalName.Name = "lalName";
            this.lalName.Size = new System.Drawing.Size(0, 25);
            this.lalName.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(311, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Sex :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(55, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(311, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Age :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(55, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(55, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Name :";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(565, 132);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(642, 552);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Age";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone";
            this.columnHeader4.Width = 156;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sex";
            this.columnHeader5.Width = 76;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Male.png");
            this.imageList2.Images.SetKeyName(1, "Female.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Male.png");
            this.imageList1.Images.SetKeyName(1, "Female.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 56);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pataints_Managment.Properties.Resources.Human;
            this.pictureBox1.Location = new System.Drawing.Point(343, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::Pataints_Managment.Properties.Resources.update;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Pataints_Managment.Properties.Resources.page_delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1239, 770);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hospital Managment System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox MastxtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MastxtPhone;
        private System.Windows.Forms.RadioButton RbFemale;
        private System.Windows.Forms.RadioButton RbMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lalSex;
        private System.Windows.Forms.Label lalAge;
        private System.Windows.Forms.Label lalDate;
        private System.Windows.Forms.Label lalPhone;
        private System.Windows.Forms.Label lalName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

