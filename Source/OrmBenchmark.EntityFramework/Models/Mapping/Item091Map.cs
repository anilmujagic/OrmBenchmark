using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item091Map : EntityTypeConfiguration<Item091>
    {
        public Item091Map()
        {
            // Primary Key
            this.HasKey(t => t.Item091ID);

            // Properties
            this.Property(t => t.Item091ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item091");
            this.Property(t => t.Item091ID).HasColumnName("Item091ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
