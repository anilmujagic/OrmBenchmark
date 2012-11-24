using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item060Map : EntityTypeConfiguration<Item060>
    {
        public Item060Map()
        {
            // Primary Key
            this.HasKey(t => t.Item060ID);

            // Properties
            this.Property(t => t.Item060ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item060");
            this.Property(t => t.Item060ID).HasColumnName("Item060ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
