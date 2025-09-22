using System;
using MySql.Data.MySqlClient;

namespace OOPAlapok2
{
    internal class Connect
    {
        private string Host;
        private string database;
        private string user;
        private string Password;
        private string ConnectionString;
        private MySqlConnection connectionString;

        public Connect(string database, string user, string password)
        {
            this.Host = "localhost";
            this.database = database;
            this.user = "root";
            this.Password = "";

            ConnectionString = $"Server={Host};Database={database};Uid={user};Pwd={password};SslMode=None";
            connectionString = new MySqlConnection(ConnectionString);

            try
            {
                connectionString.Open();
                Console.WriteLine("Sikeres csatlakozás");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sikertelen csatlakozás: {ex.Message}");
            }
        }
    }
}