using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item098Map : EntityTypeConfiguration<Item098>
    {
        public Item098Map()
        {
            // Primary Key
            this.HasKey(t => t.Item098ID);

            // Properties
            this.Property(t => t.Item098ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item098");
            this.Property(t => t.Item098ID).HasColumnName("Item098ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
