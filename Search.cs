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
    public partial class Search : Form
    {
        Controller ctrl = new Controller();
        public Search()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClubName.Clear();
            txtClubName.Focus();
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtClubName.Text == "")
            {
                MessageBox.Show("Please enter a club name ", "Missing INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int feedback = ctrl.CheckClubName(txtClubName.Text);

                if (feedback == 0)
                {
                    MessageBox.Show("Club Name with the same name Does not Exist or Not active", "Invalid Club Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClubName.Clear();
                    txtClubName.Focus();
                }
                else
                {
                    dataGridView1.DataSource = ctrl.DisplayClubInfo(txtClubName.Text).Tables[0];
                }
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // AutoComplete when entering the ClubName
            ctrl.AutoCompleter(txtClubName);
        }

        private void txtClubName_Click(object sender, EventArgs e)
        {
            txtClubName.Clear();
            txtClubName.Font = new Font("Times New Roman", 12);
        }
    }
}
