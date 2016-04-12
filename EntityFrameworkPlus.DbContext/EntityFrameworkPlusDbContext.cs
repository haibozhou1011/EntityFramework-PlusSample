using System.Data.Entity;
using EntityFrameworkPlus.Mappings;
using EntityFrameworkPlus.Models;
using Z.EntityFramework.Plus;

namespace EntityFrameworkPlus.DbContext
{
    public class EntityFrameworkPlusDbContext : System.Data.Entity.DbContext
    {
        public EntityFrameworkPlusDbContext()
            : base("EntityFrameworkPlusConnection")
        {
        }
        public DbSet<AuditEntry> AuditEntries { get; set; }
        public DbSet<AuditEntryProperty> AuditEntryProperties { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<GoodsModel> Goodses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new GoodsMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
