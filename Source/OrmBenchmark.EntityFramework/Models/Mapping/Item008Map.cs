using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item008Map : EntityTypeConfiguration<Item008>
    {
        public Item008Map()
        {
            // Primary Key
            this.HasKey(t => t.Item008ID);

            // Properties
            this.Property(t => t.Item008ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item008");
            this.Property(t => t.Item008ID).HasColumnName("Item008ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
