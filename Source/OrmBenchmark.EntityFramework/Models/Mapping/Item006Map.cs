using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item006Map : EntityTypeConfiguration<Item006>
    {
        public Item006Map()
        {
            // Primary Key
            this.HasKey(t => t.Item006ID);

            // Properties
            this.Property(t => t.Item006ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item006");
            this.Property(t => t.Item006ID).HasColumnName("Item006ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
