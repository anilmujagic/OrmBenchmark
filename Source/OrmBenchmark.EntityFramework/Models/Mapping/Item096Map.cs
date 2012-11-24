using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item096Map : EntityTypeConfiguration<Item096>
    {
        public Item096Map()
        {
            // Primary Key
            this.HasKey(t => t.Item096ID);

            // Properties
            this.Property(t => t.Item096ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item096");
            this.Property(t => t.Item096ID).HasColumnName("Item096ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
