using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item075Map : EntityTypeConfiguration<Item075>
    {
        public Item075Map()
        {
            // Primary Key
            this.HasKey(t => t.Item075ID);

            // Properties
            this.Property(t => t.Item075ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item075");
            this.Property(t => t.Item075ID).HasColumnName("Item075ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
