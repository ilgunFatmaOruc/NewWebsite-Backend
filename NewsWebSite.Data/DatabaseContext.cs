using NewsWebSite.Data.Mappings;
using NewsWebSite.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Data
{
    public class DatabaseContext:DbContext
    {
        //@"Data Source=BK-LAB204-IS003;Initial Catalog=NewsWebSite;User ID=sa;Password=123"
        public DatabaseContext() : base(@"Data Source=USER-PC;Initial Catalog=NewsWebSite; Integrated Security=True;")
        {

        }

        public DbSet<Item> Item { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //modelBuilder.Configurations.Add(new ItemMapping());
            
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            //catch(DbEntityValidationException dbEntityValidationException)
            //{
            //    string validateError = string.Empty;
            //    foreach 
                
            //}
            catch (Exception exception)
            {
                var error = $"{exception}";
                throw exception;
            }
            
        }

        //internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
        //{
        //    public Configuration()
        //    {

        //    }
        //}

        
    }
}
