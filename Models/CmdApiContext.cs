using Microsoft.EntityFrameworkCore;

namespace CmdApi.Models
{
    public class CmdApiContext : DbContext
    {
        public CmdApiContext(DbContextOptions<CmdApiContext> options) : base(options) {}

        public DbSet<Command> Commands { get; set; }
    }
}