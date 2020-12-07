using System.Collections.Generic;

namespace RegistratinML
{
    public class LocalStorage : Storage
    {
        private struct User
        {
            public User(string x, string y)
            {
                username = x;
                password = y;
            }

            public string username { get; }
            public string password { get; }
        }

        private static List<User> users = new List<User>() { new User("usr1", "1234"), new User("usr2", "5678") };
        public override void InsertNewUser(string username, string password)
        {
            users.Add(new User(username, password));
        }
    }
}
