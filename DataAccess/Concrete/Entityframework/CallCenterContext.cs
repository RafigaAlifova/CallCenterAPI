using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Entityframework
{
    public class CallCenterContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Profession> Professions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
      optionsBuilder.UseSqlServer(@"server = (localdb)\mssqlLocaldb; Database = CallCenterDb; Trusted_connection=true"); // link
        }
    }
}
