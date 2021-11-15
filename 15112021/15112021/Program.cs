using System;

namespace _15112021
{
    class Program
    {
        static void Main(string[] args)
        {

            UserValidator userValidator = new UserValidator();

            Console.WriteLine("UserName daxil et!");
            string username = Console.ReadLine();

            if (!userValidator.CheckUserName(username))
            {
                Console.WriteLine("UserName deyeri yanlisdir!");
                return;
            }


            Console.WriteLine("Password daxil et:");
            string password = Console.ReadLine();

            if (!userValidator.CheckPassword(password))
            {
                Console.WriteLine("Password deyeri yanlisdir!");
                return;
            }

            UserCRUD userCRUD = new UserCRUD();

            userCRUD.Create(password, username);
            userCRUD.Create("test123456", "user1");
            userCRUD.Create("test123456", "user2");

            var data = userCRUD.Get(1);
            userCRUD.Delete(data);

            foreach (var item in userCRUD.GetList())
            {

                Console.WriteLine(item.UserName);
            }

        }
    }
}
