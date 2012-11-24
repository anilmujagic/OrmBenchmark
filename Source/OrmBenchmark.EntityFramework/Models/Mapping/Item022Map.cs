using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item022Map : EntityTypeConfiguration<Item022>
    {
        public Item022Map()
        {
            // Primary Key
            this.HasKey(t => t.Item022ID);

            // Properties
            this.Property(t => t.Item022ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item022");
            this.Property(t => t.Item022ID).HasColumnName("Item022ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
