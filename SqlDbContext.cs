using System.Data.Entity;

namespace MVCwithWebAPI.Models
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("name=SqlConn")
        {
        }
        public DbSet<Contact> Contact { get; set; }
    }
}