using Microsoft.EntityFrameworkCore;
using static SignalRApiForSql.DAL.Visitors;

namespace SignalRApiForSql.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
