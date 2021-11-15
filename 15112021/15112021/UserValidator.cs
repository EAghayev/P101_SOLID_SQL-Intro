using System;
using System.Collections.Generic;
using System.Text;

namespace _15112021
{
    class UserValidator
    {
        public bool CheckUserName(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 5 || username.Length > 25)
                return false;

            return true;
        }

        public bool CheckPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8 || password.Length > 20)
                return false;

            return true;
        }
    }
}
