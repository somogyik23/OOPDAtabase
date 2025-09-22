using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace OOPAlapok2.Services
{
    internal class TableBooks : ISqlStatements
    {
        public List<object> GetAllBooks()
        {
            List<object> result = new List<object>();

            Connect connect = new Connect("library");
            var connection = connect.GetConnection();

            string sql = "SELECT * FROM books";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    var book = new
                    {
                        Id = dr.GetInt32("id"),
                        Title = dr.GetString("title"),
                        Author = dr.GetString("author"),
                        Year = dr.GetInt32("releaseDate")
                    };

                    result.Add(book);
                }
            }

            return result;
        }
    }
}