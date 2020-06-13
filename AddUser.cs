using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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
    public partial class AddUser : Form
    {
        Controller ctrl = new Controller();
        public AddUser()
        {
            InitializeComponent();
        }
        //Method to Clear Text Fields 
        public void ClearInfo()
        {
            txtFullname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cboRole.SelectedIndex = -1;
            txtFullname.Focus();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("Club Representative");
            cboRole.Items.Add("Student");
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.SelectedIndex = -1;
        }

        private void txtFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("Are You Sure Do You Want To Clear ?", "Clear Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (reply == DialogResult.Yes)
            {
                ClearInfo();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtFullname.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || cboRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields", "Info Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                

                //check for existing 
                int existing = ctrl.CheckExistingFullName(txtFullname.Text, txtUsername.Text);
                if (existing == 1)
                {
                    MessageBox.Show("User with the same name exist !");
                    txtFullname.Clear();
                    txtFullname.Focus();
                    return;
                }
                else if (existing == 2) 
                {
                    MessageBox.Show("User with the same UserName exists !");
                    txtUsername.Clear();
                    txtUsername.Focus();
                    return;
                }
                else
                {
                    int status = ctrl.AddUser(txtFullname.Text, txtUsername.Text, txtPassword.Text, cboRole.Text);

                    if (status == 1)
                    {
                        if (cboRole.SelectedIndex == 1)
                        {
                            ctrl.AddClubRep(txtFullname.Text, txtPassword.Text);
                            //MessageBox.Show("You have Registered Successfully Please, Sign IN", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Close();
                        }

                        MessageBox.Show("You have Registered Successfully Please, Sign IN", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable To Register Successfully", "Faliure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtFullname_Click(object sender, EventArgs e)
        {
            txtFullname.Clear();
            txtFullname.Font = new Font("Times New Roman",12);
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtUsername.Font = new Font("Times New Roman", 12);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Font = new Font("Times New Roman", 12);
        }
    }
}
