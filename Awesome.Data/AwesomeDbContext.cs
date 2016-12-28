using Awesome.Data.SampleData;
using Awesome.Model;
using System;
//using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awesome.Data
{
    public class AwesomeDbContext : DbContext
    {
        public AwesomeDbContext() : base(nameOrConnectionString: "DefaultConnection") { }

        public DbSet<ClassUnit> Classunits { get; set; }

        //invoke this to seed default values for the 1st run
        //comment the intializer code in production
        static AwesomeDbContext()
        {
            Database.SetInitializer(new AwesomeDatabaseInitializer());
        }

        //setting EF Convetions
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
