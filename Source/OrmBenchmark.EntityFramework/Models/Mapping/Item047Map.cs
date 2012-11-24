using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item047Map : EntityTypeConfiguration<Item047>
    {
        public Item047Map()
        {
            // Primary Key
            this.HasKey(t => t.Item047ID);

            // Properties
            this.Property(t => t.Item047ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item047");
            this.Property(t => t.Item047ID).HasColumnName("Item047ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
