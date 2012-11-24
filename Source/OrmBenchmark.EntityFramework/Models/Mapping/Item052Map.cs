using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item052Map : EntityTypeConfiguration<Item052>
    {
        public Item052Map()
        {
            // Primary Key
            this.HasKey(t => t.Item052ID);

            // Properties
            this.Property(t => t.Item052ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item052");
            this.Property(t => t.Item052ID).HasColumnName("Item052ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
