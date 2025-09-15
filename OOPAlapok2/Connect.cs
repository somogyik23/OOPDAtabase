using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok2
{
    internal class Connect
    {
        private string Host;
        private string database;
        private string user;
        private string Password;    
    

    public Connect(string database, string user, string password)
        {
            this.Host = "localhost";
            this.database = database;
            this.user = user;
            this.Password = password;

            ConnectionString = $"Server={_host};Database={database};Uid={user};Pwd={password};";

            connectionStirng = new MySqlConnection(ConnectionString);
      
        }
    }
}
