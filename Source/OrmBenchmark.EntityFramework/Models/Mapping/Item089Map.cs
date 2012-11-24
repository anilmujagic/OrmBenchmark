using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item089Map : EntityTypeConfiguration<Item089>
    {
        public Item089Map()
        {
            // Primary Key
            this.HasKey(t => t.Item089ID);

            // Properties
            this.Property(t => t.Item089ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item089");
            this.Property(t => t.Item089ID).HasColumnName("Item089ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
