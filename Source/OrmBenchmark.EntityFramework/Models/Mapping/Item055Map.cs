using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item055Map : EntityTypeConfiguration<Item055>
    {
        public Item055Map()
        {
            // Primary Key
            this.HasKey(t => t.Item055ID);

            // Properties
            this.Property(t => t.Item055ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item055");
            this.Property(t => t.Item055ID).HasColumnName("Item055ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
