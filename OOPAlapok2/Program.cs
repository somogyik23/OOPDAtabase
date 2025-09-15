using System;
using MySql.Data.MySqlClient;

namespace OOPAlapok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az adatbázis nevét: ");
            string database = Console.ReadLine();

            Console.Write("Felhasználónév: ");
            string username = Console.ReadLine();

            Console.Write("Jelszó: ");
            string password = ReadPassword();

            string connectionString = $"Server=localhost;Database={database};Uid={username};Pwd={password};";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Sikeres csatlakozás");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sikertelen csatlakozás: {ex.Message}");
            }
        }

        // Secure password input (does not show password on console)
        static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info;
            do
            {
                info = Console.ReadKey(true);
                if (info.Key != ConsoleKey.Enter)
                {
                    password += info.KeyChar;
                }
            } while (info.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return password;
        }
    }
}
