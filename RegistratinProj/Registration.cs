using System;

namespace RegistratinML
{
    public class Registration
    {
        public int RegisterNewUser(string username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || username.Length < 8 || username.Length > 30
                || password.Length < 8 || password.Length > 30)
                throw new ArgumentOutOfRangeException("Incorect input field");

            DataSource.storage.InsertNewUser(username, password);

            return 0;
        }
    }
}
