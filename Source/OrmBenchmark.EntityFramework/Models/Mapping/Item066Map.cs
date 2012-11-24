using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item066Map : EntityTypeConfiguration<Item066>
    {
        public Item066Map()
        {
            // Primary Key
            this.HasKey(t => t.Item066ID);

            // Properties
            this.Property(t => t.Item066ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item066");
            this.Property(t => t.Item066ID).HasColumnName("Item066ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
