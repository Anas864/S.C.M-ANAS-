using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.C.M
{
    public partial class ClubStatus : Form
    {
        Controller ctrl = new Controller();
        public ClubStatus()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("Are you sure you want to Cancel", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (reply == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox1.Focus();
            }
        }
        private void ClubStatus_Load(object sender, EventArgs e)
        {
            // AutoComplete when entering the ClubName
            ctrl.AutoCompleter(textBox1);

            radioActive.Checked = true;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string clubstatus = "";


            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a club name ", "Missing INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radioActive.Checked)
                {
                    clubstatus = "Active";
                }
                else if (radioRemoved.Checked)
                {
                    clubstatus = "Removed";
                }

                int feedback = ctrl.CheckClubNameOnly(textBox1.Text);

                if (feedback == 0)
                {
                    MessageBox.Show("Club not found or Not Active", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    int status = ctrl.ClubStatus(textBox1.Text, clubstatus);

                    if (status == 1)
                    {
                        MessageBox.Show("Club status Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("Faile to Update Club status", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Font = new Font("Times New Roman", 12);
        }
    }
}

