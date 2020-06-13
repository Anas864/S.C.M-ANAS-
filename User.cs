using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.C.M
{
    class User
    {
        // DataFields
        private string fullname;
        private string username;
        private string password;
        private string role;

        // Constucter
        public User(string fullname, string username, string password, string role)
        {
            //set the coming info 
            this.fullname = fullname;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        //Properties 
        public string Fullname { get => fullname; set => fullname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
