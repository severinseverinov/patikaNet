using Microsoft.EntityFrameworkCore;
namespace LinQExample.DbOperations{
    public class LinQDbContext:DbContext{
        public DbSet<Student> Students{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseInMemoryDatabase(databaseName:"LinqDatabase");
        }

    }
}