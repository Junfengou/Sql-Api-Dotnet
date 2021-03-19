using System.Collections.Generic;
using SpicyWebApi.Models;

namespace SpicyWebApi.Data
{
    public interface ICommandRepo
    {
        IEnumerable<SqlCommands> GetAllSqlCommands();

        SqlCommands GetCommandById(int id);

        void CreateCommand(SqlCommands sql);

        void UpdateCommand(SqlCommands sql);

        void DeleteCommand(SqlCommands sql);

        bool SaveChanges();

    }
}