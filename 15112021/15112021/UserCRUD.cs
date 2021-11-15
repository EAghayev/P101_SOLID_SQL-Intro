using System;
using System.Collections.Generic;
using System.Text;

namespace _15112021
{
    class UserCRUD
    {
        public void Create(string pass, string name)
        {
            User user = new User
            {
                UserName = name,
                Password = pass
            };

            Data.Users.Add(user);
        }

        public void Delete(User user)
        {
            Data.Users.Remove(user);
        }

        public List<User> GetList()
        {
            return Data.Users;
        }

        public User Get(int index)
        {
            return Data.Users[index];
        }


    }
}
