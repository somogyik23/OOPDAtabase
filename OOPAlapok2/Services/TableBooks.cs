﻿using MySql.Data.MySqlClient;
using OOPAlapok2.Services;
using OOPAlapok2;
using System.Collections.Generic;

namespace OOPDatabase.Services
{
    internal class TableBooks : ISqlStatements
    {
        public List<object> GetAllBooks()
        {
            List<object> result = new List<object>();

            Connect conn = new Connect("library");

            conn.Connection.Open();

            string sql = "SELECT * FROM books";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            //dr.Read();

            while (dr.Read())
            {
                var book = new
                {
                    Id = dr.GetInt32("id"),
                    Title = dr.GetString("title"),
                    Author = dr.GetString("author"),
                    Release = dr.GetDateTime("releaseDate")
                };

                result.Add(book);
            }

            conn.Connection.Close();

            return result;
        }

        public object GetById(int id)
        {
            Connect conn = new Connect("library");

            conn.Connection.Open();

            string sql = "SELECT * FROM books WHERE id = @id ";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);
            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            var book = new
            {
                Id = dr.GetInt32("id"),
                Title = dr.GetString("title"),
                Author = dr.GetString("author"),
                Release = dr.GetDateTime("releaseDate")

            };

            conn.Connection.Close();

            return book;
        }
    }
}