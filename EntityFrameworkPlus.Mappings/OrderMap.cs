using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EntityFrameworkPlus.Models;

namespace EntityFrameworkPlus.Mappings
{
    public class OrderMap : EntityTypeConfiguration<OrderModel>
    {
        public OrderMap()
        {
            this.HasKey(m => m.OrderGuid);

            this.Property(m => m.OrderGuid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.OrderNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(m => m.OrderCreator)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(m => m.OrderStatus)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(m => m.Description)
                .HasMaxLength(1000);

            this.Property(m => m.Creator)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(m => m.LastModifier)
             .HasMaxLength(15)
             .HasMaxLength(20);

            this.ToTable("Sample_Order");

            this.Property(m => m.OrderGuid).HasColumnName("OrderGuid");
            this.Property(m => m.OrderNo).HasColumnName("OrderNo");
            this.Property(m => m.OrderCreator).HasColumnName("OrderCreator");
            this.Property(m => m.OrderDateTime).HasColumnName("OrderDateTime");
            this.Property(m => m.OrderStatus).HasColumnName("OrderStatus");
            this.Property(m => m.Description).HasColumnName("Description");
            this.Property(m => m.Creator).HasColumnName("Creator");
            this.Property(m => m.CreateDateTime).HasColumnName("CreateDateTime");
            this.Property(m => m.LastModifier).HasColumnName("LastModifier");
            this.Property(m => m.LastModifiedDateTime).HasColumnName("LastModifiedDateTime");
        }
    }
}