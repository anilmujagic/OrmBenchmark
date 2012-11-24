using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item046Map : EntityTypeConfiguration<Item046>
    {
        public Item046Map()
        {
            // Primary Key
            this.HasKey(t => t.Item046ID);

            // Properties
            this.Property(t => t.Item046ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item046");
            this.Property(t => t.Item046ID).HasColumnName("Item046ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
