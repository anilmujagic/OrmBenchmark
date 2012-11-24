using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item051Map : EntityTypeConfiguration<Item051>
    {
        public Item051Map()
        {
            // Primary Key
            this.HasKey(t => t.Item051ID);

            // Properties
            this.Property(t => t.Item051ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item051");
            this.Property(t => t.Item051ID).HasColumnName("Item051ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
