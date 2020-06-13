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
    public partial class DescUpdate : Form
    {
        Controller ctrl = new Controller();
        public DescUpdate()
        {
            InitializeComponent();
        }

        private void DescUpdate_Load(object sender, EventArgs e)
        {
            listClubs.DataSource = ctrl.RetrieveClubInfo();
            listClubs.DisplayMember = "CLUBNAME";
        }

        private void listClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl.RetrieveClubInfo();
            lblCurrentDesc.Text = dt.Rows[listClubs.SelectedIndex].ItemArray[8].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl.RetrieveClubInfo();
            if (txtNewDesc.Text == "")
            {
                MessageBox.Show("Please Make Sure that you have filled ALL Fields", "Missing INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                int status = ctrl.UpdateDesc(dt.Rows[listClubs.SelectedIndex].ItemArray[1].ToString(),txtNewDesc.Text);

                if (status == 1)
                {
                    MessageBox.Show("Description Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Unable to Update Description ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewDesc.Text = "";
                    listClubs.SelectedIndex = 0;
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewDesc.Text = "";
            listClubs.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
