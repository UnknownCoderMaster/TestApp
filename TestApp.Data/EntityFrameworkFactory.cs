using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TestApp.Data
{
    public class EntityFrameworkFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder();

            optionBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestData;Trusted_Connection=True;");

            return new AppDbContext(optionBuilder.Options);
        }
    }
}
