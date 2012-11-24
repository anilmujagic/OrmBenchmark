using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item092Map : EntityTypeConfiguration<Item092>
    {
        public Item092Map()
        {
            // Primary Key
            this.HasKey(t => t.Item092ID);

            // Properties
            this.Property(t => t.Item092ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item092");
            this.Property(t => t.Item092ID).HasColumnName("Item092ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
