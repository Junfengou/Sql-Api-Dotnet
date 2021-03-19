using Microsoft.EntityFrameworkCore;

namespace SpicyWebApi.Models
{
    public class CommandContext : DbContext
    {
        public DbSet<SqlCommands> SqlCommands { get; set; }



        public CommandContext(DbContextOptions<CommandContext> opt) : base(opt)
        {

        }
    }
}