using OOPDatabase.Services;
using System;

namespace OOPDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISqlStatements sqlStatements = new TableBooks();

            /*Feladat1
            foreach (var item in sqlStatements.GetAllRecords())
            {
                var book = item.GetType().GetProperties();
                Console.WriteLine($"{book[0].Name} = {book[0].GetValue(item)}, {book[1].Name} = {book[1].GetValue(item)}");
            }*/

            //Feladat2
            Console.Write("Kérem a rejord id-t: ");

            var item = sqlStatements.GetById(int.Parse(Console.ReadLine()));

            var book = item.GetType().GetProperties();

            Console.WriteLine($"{book[1].Name} = {book[1].GetValue(item)}");




        }
    }
}