using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item037Map : EntityTypeConfiguration<Item037>
    {
        public Item037Map()
        {
            // Primary Key
            this.HasKey(t => t.Item037ID);

            // Properties
            this.Property(t => t.Item037ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item037");
            this.Property(t => t.Item037ID).HasColumnName("Item037ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
