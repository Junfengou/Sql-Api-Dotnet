using System;
using System.Collections.Generic;
using System.Linq;
using SpicyWebApi.Models;

namespace SpicyWebApi.Data
{
    public class SqlCommandRepo : ICommandRepo
    {
        private readonly CommandContext _context;

        public SqlCommandRepo(CommandContext context)
        {
            _context = context;
        }

        public void CreateCommand(SqlCommands sql)
        {
            if (sql == null)
            {
                throw new ArgumentNullException();
            }

            _context.Add(sql);
        }

        public void DeleteCommand(SqlCommands sql)
        {
            if (sql == null)
            {
                throw new ArgumentNullException();
            }

            _context.Remove(sql);
        }

        public IEnumerable<SqlCommands> GetAllSqlCommands()
        {
            return _context.SqlCommands.ToList();
        }

        public SqlCommands GetCommandById(int id)
        {
            return _context.SqlCommands.FirstOrDefault(item => item.SqlCmdId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(SqlCommands sql)
        {
            // Nothing need to be done here since it's already taken care of by DbContext?
        }
    }
}