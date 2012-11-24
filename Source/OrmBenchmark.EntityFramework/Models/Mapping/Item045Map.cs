using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item045Map : EntityTypeConfiguration<Item045>
    {
        public Item045Map()
        {
            // Primary Key
            this.HasKey(t => t.Item045ID);

            // Properties
            this.Property(t => t.Item045ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item045");
            this.Property(t => t.Item045ID).HasColumnName("Item045ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
