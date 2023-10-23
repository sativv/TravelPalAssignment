using System.Collections.Generic;
using TravelPal.Interfaces;

namespace TravelPal.Repos
{
    class UserManager
    {
        public List<IUser> Users { get; set; }
        public IUser signedInUser { get; set; }



        public bool AddUser()
        {
            return true;
        }

        public void RemoveUser(IUser user)
        {

        }

        public bool UpdateUsername(IUser user, string username)
        {
            return true;
        }

        private bool ValidateUsername(string username)
        {
            return true;
        }

        public bool SignInUser(string username, string password)
        {
            return true;
        }
    }
}
