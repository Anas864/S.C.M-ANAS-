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
    public partial class SignIN : Form
    {
        Controller ctrl = new Controller();

        public SignIN()
        {
            InitializeComponent();
            ctrl.FirstApperance(buttonDashboard, btnClubs, panelClubs, btnSearch,
                                btnReports, panelReport, btnUpdateCR, panelUpdateCR);
        }

        // Method to hide other panels
        public void HideOtherpanels() 
        {
            panelClubs.Visible = false;
            panelReport.Visible = false;
            panelUpdateCR.Visible = false;

        }

        // Show Panel Method 
        public void ShowPanel(Panel Choosen)
        {
            //Decide wich panel to show
            if (Choosen.Visible == false)
            {
                HideOtherpanels();
                Choosen.Visible = true;
            }
            else { Choosen.Visible = false; }
        }

        //method that open forms
        private Form activeform = null;
        private void FormOpener(Form Choosen) 
        {
            if (activeform != null) 
            {
                activeform.Close();
            }
            activeform = Choosen;
            Choosen.TopLevel = false;
            Choosen.FormBorderStyle = FormBorderStyle.None;
            Choosen.Dock = DockStyle.Fill;
            panelThatOpenForms.Controls.Add(Choosen);
            panelThatOpenForms.Tag = Choosen;
            Choosen.BringToFront();
            Choosen.Show();
        }

        //Mthod that detemins the Admin View
        private void Adminview() 
        {
            panelReport.Visible = true;//to maintain pattern
            panelReport.Visible = false;
            btnReports.Visible = true;
            btnSearch.Visible = true;
            panelClubs.Visible = true; // to maintain pattern
            panelClubs.Visible = false;
            btnClubs.Visible = true;
            buttonDashboard.Visible = true;
        }

        //Method that determine the Club Rep view
        private void ClubRepview() 
        {
            panelUpdateCR.Visible = true;//to maintain pattern
            panelUpdateCR.Visible = false;
            btnUpdateCR.Visible = true;
            buttonDashboard.Visible = true;
        }

        //Method that determine the Normal Student view
        private void StudentView() 
        {
            buttonDashboard.Visible = true;
        }

        //Mthod to Disable the sign in form after signing in 
        private void AfterSignIN() 
        {
            label2.Location = new Point(211,240);
            pictureBox3.Location = new Point(382,228);
            
            label4.Visible = false;
            checkBox1.Visible = false;
            textPASSword.Visible = false;
            textUSERname.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            buttonCreate.Visible = false;
            buttonSignIn.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            FormOpener(new DashBoard());
        }

        private void btnClubs_Click(object sender, EventArgs e)
        {
            ShowPanel(panelClubs);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            FormOpener(new AddNew());
            // Go to the Add New From
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            FormOpener(new Update());
            //Go to the Update form
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            FormOpener(new ClubStatus());
            // Go to the Remove form
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            //Go to the Activate form
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            FormOpener(new Search());
            //Go to the Search form
        }

        private void butnReports_Click(object sender, EventArgs e)
        {
            ShowPanel(panelReport);
        }

        private void btnListReport_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            FormOpener(new Form1());
            // Go to the List Report Form
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            FormOpener(new Form2());
            //Go to the Activity Report
        }

        private void btnUpdateCR_Click(object sender, EventArgs e)
        {
            ShowPanel(panelUpdateCR);
        }

        private void btnWeeklyUpdate_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            FormOpener(new WeeklyUpdate());
            // Go to Weekly update Form
        }

        private void btnClubDescription_Click(object sender, EventArgs e)
        {
            HideOtherpanels();
            FormOpener(new DescUpdate());
            // Go to the Club Description Form
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For any issues or quiries please contact us on this E-amil (anasnassar988@gmail.com)","HELP",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application is desigen to orgnize clubs activites and to try to encourage students to engage with those activies. This hole project is done by (Anas Nassar TP057388)","ABOUT",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("Are You Sure Do You Want To Exit ?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (reply == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormOpener(new AddUser());
        }

        // Control the Password char property
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textPASSword.UseSystemPasswordChar = false;
            }
            else
            {
                textPASSword.UseSystemPasswordChar = true;
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            

            int status = ctrl.signIN(textUSERname.Text, textPASSword.Text);

            // Determine wich User just Signed In 

            if (status == 1)
            {
                MessageBox.Show("WELCOME " + textUSERname.Text);
                Adminview();
                AfterSignIN();
                FormOpener(new DashBoard());
            }
            else if (status == 2)
            {
                MessageBox.Show("WELCOME " + textUSERname.Text);
                ClubRepview();
                AfterSignIN();
                FormOpener(new DashBoard());
            }
            else if (status == 3) 
            {
                MessageBox.Show("WELCOME " + textUSERname.Text);
                StudentView();
                AfterSignIN();
                FormOpener(new DashBoard());
            }
            else
            {
                MessageBox.Show("INCORRECT USRNAME OR PASSWORD ", "INCORRECT", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        private void textUSERname_Click(object sender, EventArgs e)
        {
            textUSERname.Clear();
            textUSERname.Font = new Font("Times New Roman",12);
        }

        private void textPASSword_Click(object sender, EventArgs e)
        {
            textPASSword.UseSystemPasswordChar = true;
            textPASSword.Clear();
        }
    }
}
