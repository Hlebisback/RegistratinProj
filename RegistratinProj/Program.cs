using System;

namespace RegistratinML
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource.storage = new LocalStorage();
            Registration reg = new Registration();
            reg.RegisterNewUser("NewUsername", "123456789");
        }
    }
}
