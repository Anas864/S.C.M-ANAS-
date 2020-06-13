using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;
using System.Data;

namespace S.C.M
{
    class Controller
    {

        // Data Fields
        SqlConnection conn;

        // NO CONSTRUCTUR (BUITL IN)


        //Method to Hide all buttons at First
        public void FirstApperance(Button btndashboard, Button btnclubs, Panel panelclubs, Button btnsearch,
                                   Button btnreport, Panel panelreport, Button btnupdate, Panel panelupdate)
        {
            btndashboard.Visible = false;
            btnclubs.Visible = false;
            panelclubs.Visible = false;
            btnsearch.Visible = false;
            btnreport.Visible = false;
            panelreport.Visible = false;
            btnupdate.Visible = false;
            panelupdate.Visible = false;
        }


        // Method to Connect to the Data Base
        public void Connect()
        {
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename ='|DataDirectory|\\S.C.M.mdf'; Integrated Security = True; Connect Timeout = 30");

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // Method to Check if the enterd fullname and username are beint used  
        public int CheckExistingFullName(string fullname,string username) 
        {
            int existing = 0;

            string checkSQL = "SELECT FULLNAME,USERNAME FROM USERS";
            Connect();

            SqlCommand cmd = new SqlCommand(checkSQL, conn);
            cmd.Parameters.AddWithValue("@FULLNAME", fullname);
            cmd.Parameters.AddWithValue("@USERNAME", username);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                if (dr[0].ToString().ToUpper() == fullname.ToUpper())
                {
                    existing = 1;
                }
                else if (dr[1].ToString().ToUpper() == username.ToUpper()) 
                {
                    existing = 2;
                }
            }

            conn.Close();
            return existing;
        }
        
        //Method(int) to Add new user to the tabel
        public int AddUser(string fullname, string username, string password, string role)
        {
            string insertSQL = "INSERT INTO USERS (FULLNAME, USERNAME, PASSWORD, ROLE)" +
                                         " VALUES (@fullname, @usrname, @pasword, @role)";
            //connect to DB
            Connect();

            //put data to the user class and then use it back
            User usr = new User(fullname, username, password, role);

            SqlCommand cmd = new SqlCommand(insertSQL, conn);
            cmd.Parameters.AddWithValue("@fullname", usr.Fullname);
            cmd.Parameters.AddWithValue("@usrname", usr.Username);
            cmd.Parameters.AddWithValue("@pasword", usr.Password);
            cmd.Parameters.AddWithValue("@role", usr.Role);

            // Execute and get feedback(int)
            int status = cmd.ExecuteNonQuery();

            conn.Close();
            return status;
        }

        //Method to add CLUB REPRESENTATIVE to CLUBREPS
        public void AddClubRep(string fullname, string password)
        {
            string insertsql = "INSERT INTO CLUBREPS (USERID, FULLNAME, CLUBREPTYPE) SELECT USERID, FULLNAME, ROLE FROM USERS WHERE FULLNAME=@fllname AND PASSWORD=@pssword; ";

            Connect();

            SqlCommand cmd = new SqlCommand(insertsql, conn);
            cmd.Parameters.AddWithValue("@fllname", fullname);
            cmd.Parameters.AddWithValue("@pssword", password);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // Method to Sign IN 
        public int signIN(string username, string password)
        {
            int status = 0;
            string sqlFind = "SELECT * FROM USERS WHERE USERNAME=@usrname AND PASSWORD = @pasword";

            Connect();

            SqlCommand cmd = new SqlCommand(sqlFind, conn);
            cmd.Parameters.AddWithValue("@usrname", username);
            cmd.Parameters.AddWithValue("@pasword", password);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                if (dr[4].Equals("Admin"))
                {
                    status = 1;
                }// this could be edited depedns on weither i want to change the idea of the the add user
                else if (dr[4].Equals("Club Representative"))
                {
                    status = 2;
                }
                else if (dr[4].Equals("Student"))
                {
                    status = 3;
                }
                else
                {
                    status = 0;
                }

            }

            conn.Close();
            return status;

        }

        // Method to add a new club to the club tabel
        public int AddClub(string clubname, DateTime clubdate, int clubtypeid, int presidant, int Vpresidant, int secretary, string clubstatus, string Desc)
        {
            string InserSQL = "INSERT INTO CLUBS(CLUBNAME, CLUBDATE, CLUBTYPEID, PRESIDENT,VPRESIDENT, SECRETARY, CLUBSTATUS, CLUBDESC) " +
                              "VALUES (@CLUBNAME, @CLUBDATE, @CLUBTYPEID,@PRESIDANT,@VPRESIDANT, @SECRETARY, @CLUBSTAUS,@DESCRIPTION )";

            Connect();

            SqlCommand cmd = new SqlCommand(InserSQL, conn);
            cmd.Parameters.AddWithValue("@CLUBNAME", clubname);
            cmd.Parameters.AddWithValue("@CLUBDATE", clubdate);
            cmd.Parameters.AddWithValue("@CLUBTYPEID", clubtypeid);
            cmd.Parameters.AddWithValue("@PRESIDANT", presidant);
            cmd.Parameters.AddWithValue("@VPRESIDANT", Vpresidant);
            cmd.Parameters.AddWithValue("@SECRETARY", secretary);
            cmd.Parameters.AddWithValue("@CLUBSTAUS", clubstatus);
            cmd.Parameters.AddWithValue("@DESCRIPTION", Desc);

            int status = cmd.ExecuteNonQuery();

            conn.Close();
            return status;

        }

        // Method to Update Presidant, Vpresidant, Secretary Data in CLUBS tabel
        public int AddPVS(int P, int V, int S, string clubname)
        {
            int status = 0;
            string UPDATEsql = "UPDATE CLUBS SET PRESIDENT=@PRESIDANT,VPRESIDENT=@VPRESIDANT,SECRETARY=@SECRETARY WHERE CLUBNAME=@CLUBNAME";

            Connect();

            SqlCommand cmd = new SqlCommand(UPDATEsql, conn);
            cmd.Parameters.AddWithValue("@PRESIDANT", P);
            cmd.Parameters.AddWithValue("@VPRESIDANT", V);
            cmd.Parameters.AddWithValue("@SECRETARY", S);
            cmd.Parameters.AddWithValue("@CLUBNAME", clubname);

            status = cmd.ExecuteNonQuery();

            conn.Close();
            return status;
        }

        // Method to Make Sure That there are No duplicate ClubNames
        public int CheckClubName(string clubname)
        {
            int status = 0;
            string CheckClubName = "SELECT CLUBNAME FROM CLUBS WHERE CLUBSTATUS = 'Active' ";

            Connect();

            SqlCommand cmd = new SqlCommand(CheckClubName, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                if (dr[0].ToString().ToUpper() == clubname.ToUpper()) 
                {
                    status = 1;
                }
            }
            conn.Close();
            return status;
        }

        //Method to check for only clubname
        public int CheckClubNameOnly(string clubname)
        {
            int status = 0;
            string CheckClubName = "SELECT * FROM CLUBS WHERE CLUBNAME=@CLUBNAME ";

            Connect();

            SqlCommand cmd = new SqlCommand(CheckClubName, conn);
            cmd.Parameters.AddWithValue("@CLUBNAME", clubname);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                status = 1;
            }

            conn.Close();
            return status;
        }

        // Method to Change Club Status in CLUBS ''

        public int ClubStatus(string clubname, string clubstatus) 
        {
            string sqlStatus = "UPDATE CLUBS SET CLUBSTATUS=@CLUBSTATUS WHERE CLUBNAME=@CLUBNAME;";

            Connect();

            SqlCommand cmd = new SqlCommand(sqlStatus,conn);
            cmd.Parameters.AddWithValue("@CLUBSTATUS", clubstatus);
            cmd.Parameters.AddWithValue("@CLUBNAME",clubname);

            int status = cmd.ExecuteNonQuery();

            conn.Close();
            return status;

        }

        //Method to search for a specifc club 
        public DataSet DisplayClubInfo(string clubname) 
        {
            string sqldisplay = "SELECT CLUBS.CLUBID, CLUBS.CLUBNAME, CLUBTYPE.CLUBTYPE, CLUBS.CLUBDESC, CLUBS.PRESIDENT, CLUBS.VPRESIDENT, CLUBS.SECRETARY, CLUBS.CLUBSTATUS FROM CLUBS INNER JOIN CLUBTYPE ON CLUBS.CLUBTYPEID = CLUBTYPE.CLUBTYPEID WHERE CLUBNAME=@CLUBNAME ";

            Connect();


            SqlDataAdapter da = new SqlDataAdapter(sqldisplay,conn);
            da.SelectCommand.Parameters.AddWithValue("@CLUBNAME", clubname);

            DataSet ds = new DataSet("CLUBS");

            da.Fill(ds, "CLUBS");

            return ds;
        }

        // 4/6/2020
        // Mehtod to Autocomplete  when entering a Club Name 
        public AutoCompleteStringCollection ClubNamesAutocomplete() 
        {
            string sqlList = "SELECT CLUBNAME FROM CLUBS WHERE CLUBSTATUS = 'Active'";

            Connect();

            SqlCommand cmd = new SqlCommand(sqlList,conn);
            AutoCompleteStringCollection ClubNames = new AutoCompleteStringCollection();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                ClubNames.Add(dr.GetString(0));
            }

            conn.Close();
            return ClubNames;
        }

        // This method Applies the ClubNamesAutocomplete method on the Specified TextBox
        public void AutoCompleter(TextBox txtClubName) 
        {
            txtClubName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtClubName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtClubName.AutoCompleteCustomSource = ClubNamesAutocomplete();
        }

        // Method To Retreive Info on the Club Description 

        public DataTable RetrieveClubInfo() 
        {
            string SqlRetrieve = "SELECT * FROM CLUBS WHERE CLUBSTATUS = 'Active' ";

            Connect();
            SqlCommand cmd = new SqlCommand(SqlRetrieve,conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();                                
            return dt;
        }

        // Method to Retrieve President name
        public SqlDataReader RetrievePresidentName(int PresidentID) 
        {
            string sqlSelect = "SELECT * FROM CLUBREPS WHERE USERID = @PRESIDENTID ";

            Connect();

            SqlCommand cmd = new SqlCommand(sqlSelect,conn);
            cmd.Parameters.AddWithValue("@PRESIDENTID",PresidentID);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            return dr; 

        }

        // Method to Add an Activity 
        public int AddActivity(string clubname,string activitytype, string activityname, DateTime activitydate, string description) 
        {
            string SQLinsert = "INSERT INTO ACTIVITIES VALUES(@CLUBNAME,@ACTIVITYTYPE,@ACTIVITYNAME,@ACTIVITYDATE,@DESCRIPTION)";

            Connect();

            SqlCommand cmd = new SqlCommand(SQLinsert, conn);
            cmd.Parameters.AddWithValue("@CLUBNAME",clubname);
            cmd.Parameters.AddWithValue("@ACTIVITYTYPE",activitytype);
            cmd.Parameters.AddWithValue("@ACTIVITYNAME",activityname);
            cmd.Parameters.AddWithValue("@ACTIVITYDATE",activitydate);
            cmd.Parameters.AddWithValue("@DESCRIPTION",description);

            int status = cmd.ExecuteNonQuery();

            conn.Close();
            return status;
        }

        // Method to Retrieve Activity Info 
        public DataTable RetrieveActivityInfo(string clubname) 
        {
            string SQL = "SELECT * FROM ACTIVITIES WHERE CLUBNAME=@CLUBNAME";
            Connect();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@CLUBNAME",clubname);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();
            return dt;


        }
        public SqlDataReader RetrieveActivityDescription(string clubname) 
        {
            string SQL = "SELECT * FROM ACTIVITIES WHERE CLUBNAME=@CLUBNAME";
            Connect();

            SqlCommand cmd = new SqlCommand(SQL,conn);
            cmd.Parameters.AddWithValue("@CLUBNAME", clubname);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            return dr;
        }
        // Mehtod to Add and Acheievment
        public int AddAchievement(int ActivityID,string winner, string participants)
        {
            string SQL = "INSERT INTO ACHIEVEMENTS VALUES(@ACTIVITYID,@WINNER,@PARTICIPANTS)";
            Connect();

            SqlCommand cmd = new SqlCommand(SQL,conn);
            cmd.Parameters.AddWithValue("@ACTIVITYID",ActivityID);
            cmd.Parameters.AddWithValue("@WINNER",winner);
            cmd.Parameters.AddWithValue("@PARTICIPANTS",participants);

            int status = cmd.ExecuteNonQuery();

            conn.Close();
            return status;
        }

        public int UpdateDesc(string clubname, string newDesc) 
        {
            string SQL = "UPDATE CLUBS SET CLUBDESC=@CLUBDESC WHERE CLUBNAME=@CLUBNAME;";

            Connect();

            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@CLUBDESC", newDesc);
            cmd.Parameters.AddWithValue("@CLUBNAME", clubname);

            int status = cmd.ExecuteNonQuery();

            conn.Close();
            return status;
        }
    }
}
