using System.Collections.Generic;
using System.Windows;
using TravelPal.Enums;
using TravelPal.Interfaces;

namespace TravelPal.Repos
{
    public static class UserManager
    {
        public static List<IUser> Users { get; set; } = new List<IUser>() { new Admin("admin", "password"), new User("user", "password", Country.Thailand) };
        public static IUser? SignedInUser { get; set; }



        public static bool AddUser(IUser user)
        {
            if (ValidateUsername(user.Username))
            {
                Users.Add(user);
                return true;
            }
            MessageBox.Show("That is not a valid username");
            return false;

        }

        public static void RemoveUser(IUser user)
        {

        }

        public static bool UpdateUsername(IUser user, string username)
        {
            return true;
        }

        private static bool ValidateUsername(string username)
        {
            foreach (var user in Users)
            {
                if (user.Username == username)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SignInUser(string username, string password)
        {
            return true;
        }






    }
}
