using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item031Map : EntityTypeConfiguration<Item031>
    {
        public Item031Map()
        {
            // Primary Key
            this.HasKey(t => t.Item031ID);

            // Properties
            this.Property(t => t.Item031ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item031");
            this.Property(t => t.Item031ID).HasColumnName("Item031ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
