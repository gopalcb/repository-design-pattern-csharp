using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models;
using Repository.Pattern.Ef6;

namespace Data
{
    public partial class ApplicationContext : DataContext
    {
        static ApplicationContext()
        {
            Database.SetInitializer<ApplicationContext>(null);
        }

        public ApplicationContext()
             : base("Name=DefaultConnection")
        {
        }
		
        public DbSet<Student> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new StudentMap());

        }
    }
}
