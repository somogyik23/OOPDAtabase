using System.Collections.Generic;

namespace OOPDatabase.Services
{
    internal interface ISqlStatements
    {
        List<object> GetAllBooks();
        object GetById(int id);
    }
}