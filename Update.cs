using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.C.M
{
    public partial class Update : Form
    {

        Controller ctrl = new Controller();
        public Update()
        {
            InitializeComponent();
        }

        private void ClearFields() 
        {
            txtClubname.Clear();
            txtPresidant.Clear();
            txtVicePresident.Clear();
            txtSecretary.Clear();
            txtClubname.Focus();
        }

        // Control text input
        private void txtClubname_KeyPress(object sender, KeyPressEventArgs e)
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

        // Control text input
        private void txtVicePresident_KeyPress(object sender, KeyPressEventArgs e)
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

        // Control Text Input
        private void txtSecretary_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("Are you sure you want to clear info", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (reply == DialogResult.Yes)
            {
                ClearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPresidant.Text == "" || txtVicePresident.Text == "" || txtSecretary.Text == "")
            {
                MessageBox.Show("One or more input fields are empty", "Missing ingp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int feedback = ctrl.CheckClubName(txtClubname.Text);

                if (feedback == 0)
                {
                    MessageBox.Show("Club Name with the same name Does not Exist or Not active", "Invalid Club Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClubname.Clear();
                    txtClubname.Focus();
                }
                else
                {

                    int status = ctrl.AddPVS(int.Parse(txtPresidant.Text), int.Parse(txtVicePresident.Text),
                                int.Parse(txtSecretary.Text), txtClubname.Text);

                    if (status == 1)
                    {
                        MessageBox.Show("Club Representatives Positions Updated !");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update !");
                    }
                }
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            // AutoComplete when entering the ClubName
            ctrl.AutoCompleter(txtClubname);
        }

        private void txtClubname_Click(object sender, EventArgs e)
        {
            txtClubname.Clear();
            txtClubname.Font = new Font("Times New Roman", 12);
        }

        private void txtPresidant_Click(object sender, EventArgs e)
        {
            txtPresidant.Clear();
            txtPresidant.Font = new Font("Times New Roman", 12);
        }

        private void txtVicePresident_Click(object sender, EventArgs e)
        {
            txtVicePresident.Clear();
            txtVicePresident.Font = new Font("Times New Roman", 12);
        }

        private void txtSecretary_Click(object sender, EventArgs e)
        {
            txtSecretary.Clear();
            txtSecretary.Font = new Font("Times New Roman", 12);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
