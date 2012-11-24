using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item100Map : EntityTypeConfiguration<Item100>
    {
        public Item100Map()
        {
            // Primary Key
            this.HasKey(t => t.Item100ID);

            // Properties
            this.Property(t => t.Item100ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item100");
            this.Property(t => t.Item100ID).HasColumnName("Item100ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
