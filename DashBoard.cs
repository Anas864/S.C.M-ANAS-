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
    public partial class DashBoard : Form
    {
        Controller ctrl = new Controller();
        public DashBoard()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            listClubs.DataSource = ctrl.RetrieveClubInfo();
            listClubs.DisplayMember = "CLUBNAME";
        }

        private void listClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl.RetrieveClubInfo();

            // Display Club Description According to the listClubs Selected Index
            lblDescription.Text = dt.Rows[listClubs.SelectedIndex].ItemArray[8].ToString();
            lblJoindate.Text = DateTime.Parse(dt.Rows[listClubs.SelectedIndex].ItemArray[2].ToString()).ToString("dd MMM yyy");

            

            // Get the President ID accordin to the listClubs Selected Index
            int PresidentID =int.Parse(dt.Rows[listClubs.SelectedIndex].ItemArray[4].ToString());

            
            //  Display the Presedent Name that is Retrieved From ClubReps
            SqlDataReader dr = ctrl.RetrievePresidentName(PresidentID);

            if (dr.HasRows)
            {
                lblPresident.Text = dr[1].ToString();
            }
            else 
            {
                lblPresident.Text = "None";
            }


            

            SqlDataReader drTwo = ctrl.RetrieveActivityDescription(dt.Rows[listClubs.SelectedIndex].ItemArray[1].ToString());
            if (drTwo.HasRows)
            {
                string ActivityType = drTwo[2].ToString();
                string ActivityName = drTwo[3].ToString();
                string Activitydate = drTwo[4].ToString();
                string Description = drTwo[5].ToString();

                lblActivities.Text = "Type :\t" + ActivityType + "\n" + "Name :\t" + ActivityName + "\n" + "Date :\t" + Activitydate + "\n" + "Desc :\t" + Description;
            }
            else { lblActivities.Text = "No Activites For Now"; }
            

        }
    }
}
