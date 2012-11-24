using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item061Map : EntityTypeConfiguration<Item061>
    {
        public Item061Map()
        {
            // Primary Key
            this.HasKey(t => t.Item061ID);

            // Properties
            this.Property(t => t.Item061ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item061");
            this.Property(t => t.Item061ID).HasColumnName("Item061ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
