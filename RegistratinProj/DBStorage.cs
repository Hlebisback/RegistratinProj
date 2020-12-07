
namespace RegistratinML
{
    public class DBStorage : Storage
    {
        public override void InsertNewUser(string username, string password)
        {
            string query = $"INSERT INTO Users (Username, Password) VALUES ('{username}', '{password}')";
        }
    }
}
