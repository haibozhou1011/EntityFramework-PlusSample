using System.Data.Entity.ModelConfiguration;
using EntityFrameworkPlus.Models;

namespace EntityFrameworkPlus.Mappings
{
    public class GoodsMap: EntityTypeConfiguration<GoodsModel>
    {
        public GoodsMap()
        {
            // Primary Key
            this.HasKey(t => t.GoodsGuid);

            // Properties
            this.Property(t => t.GoodsNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GoodsBrand)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Creator)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LastModifier)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Sample_Goods");
            this.Property(t => t.GoodsGuid).HasColumnName("GoodsGuid");
            this.Property(t => t.GoodsNo).HasColumnName("GoodsNo");
            this.Property(t => t.GoodsName).HasColumnName("GoodsName");
            this.Property(t => t.GoodsBrand).HasColumnName("GoodsBrand");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreateDateTime).HasColumnName("CreateDateTime");
            this.Property(t => t.LastModifier).HasColumnName("LastModifier");
            this.Property(t => t.LastModifiedDateTime).HasColumnName("LastModifiedDateTime");
        }
    }
}
