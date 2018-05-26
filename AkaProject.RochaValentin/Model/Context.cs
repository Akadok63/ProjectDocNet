using Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Context : DbContext
    {
        public Context() : base("name=DataBase")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<CommandProduct> CommandProducts { get; set; }
        public DbSet<LogProduct> LogProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Statut> Statuts { get; set; }

    }
}
