using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item042Map : EntityTypeConfiguration<Item042>
    {
        public Item042Map()
        {
            // Primary Key
            this.HasKey(t => t.Item042ID);

            // Properties
            this.Property(t => t.Item042ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item042");
            this.Property(t => t.Item042ID).HasColumnName("Item042ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
