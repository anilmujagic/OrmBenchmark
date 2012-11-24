using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item030Map : EntityTypeConfiguration<Item030>
    {
        public Item030Map()
        {
            // Primary Key
            this.HasKey(t => t.Item030ID);

            // Properties
            this.Property(t => t.Item030ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item030");
            this.Property(t => t.Item030ID).HasColumnName("Item030ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}