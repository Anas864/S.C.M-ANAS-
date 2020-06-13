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
    public partial class AddNew : Form
    {
        Controller ctrl = new Controller();
        string Clubstatus = "Active";
        int NotUpdated = 99;
        public AddNew()
        {
            InitializeComponent();
        }


        private void AddNew_Load(object sender, EventArgs e)
        {
            cboClubType.Items.Add("Academic");
            cboClubType.Items.Add("Political");
            cboClubType.Items.Add("Media & Publication");
            cboClubType.Items.Add("Community Services");
            cboClubType.Items.Add("Theater & Arts");
            cboClubType.Items.Add("Cultural");
            cboClubType.Items.Add("Religious");
            cboClubType.Items.Add("Sports");
            cboClubType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClubType.SelectedIndex = -1;

            // control the date of adding a new club
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(7);
        }

        private void txtClubName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textPresidantID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textVicePresidantID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSecretaryID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtClubName.Text == "" || cboClubType.SelectedIndex == -1 || txtClubDesc.Text == ""
                || txtPresidantID.Text == "" || txtVicePresidantID.Text == "" || txtSecretaryID.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Info Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                //Check For Existing Club Name that is active
                int feedback = ctrl.CheckClubName(txtClubName.Text);

                if (feedback == 1)
                {
                    MessageBox.Show("Club Name with the same name already Exist", "Duplicate Club Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClubName.Clear();
                    txtClubName.Focus();
                }
                else
                {
                    int status = ctrl.AddClub(txtClubName.Text, dateTimePicker1.Value, cboClubType.SelectedIndex,
                                              NotUpdated, NotUpdated, NotUpdated, Clubstatus, txtClubDesc.Text);
                    
                    if (status == 1)
                    {
                        //Update the Positions of the P,V,S
                        ctrl.AddPVS(int.Parse(txtPresidantID.Text), int.Parse(txtVicePresidantID.Text),
                                    int.Parse(txtSecretaryID.Text), txtClubName.Text);

                        MessageBox.Show("Club Has been Added", "Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Club Has NOT been Added", "Addition FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("Are you sure you want to clear all fields ?", "Clear Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reply == DialogResult.Yes) 
            {
                txtClubName.Clear();
                cboClubType.SelectedIndex = -1;
                txtClubDesc.Clear();
                txtPresidantID.Clear();
                txtVicePresidantID.Clear();
                txtSecretaryID.Clear();
            }
        }

        private void txtClubName_Click(object sender, EventArgs e)
        {
            txtClubName.Clear();
            txtClubName.Font = new Font("Times New Roman", 12);
        }

        private void txtPresidantID_Click(object sender, EventArgs e)
        {
            txtPresidantID.Clear();
            txtPresidantID.Font = new Font("Times New Roman", 12);
        }

        private void txtVicePresidantID_Click(object sender, EventArgs e)
        {
            txtVicePresidantID.Clear();
            txtVicePresidantID.Font = new Font("Times New Roman", 12);
        }

        private void txtSecretaryID_Click(object sender, EventArgs e)
        {
            txtSecretaryID.Clear();
            txtSecretaryID.Font = new Font("Times New Roman", 12);
        }
    }
}
