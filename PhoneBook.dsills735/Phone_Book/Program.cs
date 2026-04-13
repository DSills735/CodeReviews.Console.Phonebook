using Microsoft.Extensions.Configuration;
using Phone_Book.Context;
using Phone_Book.Menus;

namespace Phone_Book
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ContactContext.ConnectionString = config.GetConnectionString("PhoneBook")!;

            MainMenu.HomeScreen();
        }
    }
}