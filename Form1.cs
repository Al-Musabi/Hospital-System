using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pataints_Managment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void RegisterPatain()
        {
            
            ListViewItem Item = new ListViewItem(txtName.Text.Trim());

            Item.SubItems.Add(txtAge.Text.Trim());
            Item.SubItems.Add(MastxtDate.Text);
            Item.SubItems.Add(MastxtPhone.Text);

            if (RbMale.Checked)
            {
                Item.ImageIndex = 0;
                Item.SubItems.Add(RbMale.Text);
            }
            else
            {
                Item.ImageIndex = 1;
                Item.SubItems.Add(RbFemale.Text);
            }

            listView1.Items.Add(Item);
            
        }
        void ResetLabel(Label Labels)
        {
            Labels.Text = "";
        }

        void ResetAllInfo()
        {
            txtAge.Clear();
            txtName.Clear();
            MastxtDate.Clear();
            MastxtPhone.Clear();

            ResetLabel(lalName);
            ResetLabel(lalAge);
            ResetLabel(lalDate);
            ResetLabel(lalPhone);
            ResetLabel(lalSex);

        }
        void showInfoInIdCard()
        {
            lalName.Text = txtName.Text;
            lalAge.Text = txtAge.Text;
            lalDate.Text = MastxtDate.Text;
            lalPhone.Text = MastxtPhone.Text;
            if (RbMale.Checked)
                lalSex.Text = RbMale.Text;
            else
                lalSex.Text = RbFemale.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text))
                return;

            showInfoInIdCard();

            if(MessageBox.Show("Are You sure ?","Add Patinet",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                RegisterPatain();
            }

            ResetAllInfo();
        }

        void DeleteItem()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
                MessageBox.Show("You have to select Item first", "Wrong", MessageBoxButtons.OK);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            ValidateErrors(txtName, e);
        }
        void ValidateErrors(Control control, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(control, "You Must Enter Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(control, "");
            }
        }
        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            ValidateErrors(txtAge, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
            
        }
    }
}
