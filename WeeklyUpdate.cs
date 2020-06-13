using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.C.M
{
    public partial class WeeklyUpdate : Form
    {
        Controller ctrl = new Controller();
        public WeeklyUpdate()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WeeklyUpdate_Load(object sender, EventArgs e)
        {
            // auto complete when typing
            ctrl.AutoCompleter(txtClubName);

            cboActivityType.Items.Add("Competition");
            cboActivityType.Items.Add("Tournaments");
            cboActivityType.Items.Add("Concert");
            cboActivityType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActivityType.SelectedIndex = -1;

        }

        private void txtActivityName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // control input of activity name 
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void txtWinners_KeyPress(object sender, KeyPressEventArgs e)
        {
            // control input of the winner name 
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void txtParticipants_KeyPress(object sender, KeyPressEventArgs e)
        {
            // control the input of participants names
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime activityDate = DateTime.Now;
            

            if (txtClubName.Text == "" || txtActivityName.Text == "" || txtDescription.Text == "" || txtWinners.Text == "" || txtParticipants.Text == "" || cboActivityType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Make Sure that you have filled ALL Fields", "Missing INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                int reply = ctrl.CheckClubNameOnly(txtClubName.Text);
                if (reply == 1)
                {
                    // add the activiyt to DB
                    int ActivityStatus = ctrl.AddActivity(txtClubName.Text, cboActivityType.Text, txtActivityName.Text, activityDate, txtDescription.Text);

                    // Retrieve Club INFO the we just Regesterd
                    DataTable dt = ctrl.RetrieveActivityInfo(txtClubName.Text);

                    // Retrieve Activity ID
                    int ActivityID = int.Parse(dt.Rows[0].ItemArray[0].ToString());

                    // add the achievments to the DB
                    int AchievementsStatus = ctrl.AddAchievement(ActivityID, txtWinners.Text, txtParticipants.Text);

                    if (ActivityStatus == 1 && AchievementsStatus == 1)
                    {
                        MessageBox.Show("Activity Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Add Activity ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtClubName.Clear();
                        cboActivityType.SelectedIndex = -1;
                        txtActivityName.Clear();
                        txtDescription.Clear();
                        txtWinners.Clear();
                        txtParticipants.Clear();
                        txtClubName.Focus();
                    }
                }
                else 
                {
                    MessageBox.Show("No Club Found with the same name ! ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClubName.Clear();
                    txtClubName.Focus();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("Are you sure you want to Clear Data", "Clear Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (reply == DialogResult.Yes) 
            {
                txtClubName.Clear();
                cboActivityType.SelectedIndex = -1;
                txtActivityName.Clear();
                txtDescription.Clear();
                txtWinners.Clear();
                txtParticipants.Clear();
                txtClubName.Focus();
            }
        }

        private void txtClubName_Click(object sender, EventArgs e)
        {
            txtClubName.Clear();
            txtClubName.Font = new Font("Times New Roman", 12);
        }

        private void txtActivityName_Click(object sender, EventArgs e)
        {
            txtActivityName.Clear();
            txtActivityName.Font = new Font("Times New Roman", 12);
        }

        private void txtWinners_Click(object sender, EventArgs e)
        {
            txtWinners.Clear();
            txtWinners.Font = new Font("Times New Roman", 12);
        }

        private void txtParticipants_Click(object sender, EventArgs e)
        {
            txtParticipants.Clear();
            txtParticipants.Font = new Font("Times New Roman", 12);
        }
    }
}
