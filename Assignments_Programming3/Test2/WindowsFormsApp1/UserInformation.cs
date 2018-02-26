using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class UserInformation
    {
        private string userID;
        private string password;

        public UserInformation(string userID, string password)
        {
            this.userID = userID;
            this.password = password;
        }

        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
    }
}
