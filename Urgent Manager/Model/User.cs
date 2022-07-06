using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgent_Manager.Model
{
    public class User
    {
        private string username;
        private string password;
        private string role;
        private string leadPrep;
        private bool isUpdated;
        
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string LeadPrep
        {
            get { return leadPrep; }
            set { leadPrep = value; }
        }
        public bool IsUpdated
        {
            get { return isUpdated; }
            set { isUpdated = value; }
        }
    }
}
