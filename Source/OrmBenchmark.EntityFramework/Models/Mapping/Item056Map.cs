using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item056Map : EntityTypeConfiguration<Item056>
    {
        public Item056Map()
        {
            // Primary Key
            this.HasKey(t => t.Item056ID);

            // Properties
            this.Property(t => t.Item056ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item056");
            this.Property(t => t.Item056ID).HasColumnName("Item056ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
