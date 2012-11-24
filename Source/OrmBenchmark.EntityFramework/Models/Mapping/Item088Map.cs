using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item088Map : EntityTypeConfiguration<Item088>
    {
        public Item088Map()
        {
            // Primary Key
            this.HasKey(t => t.Item088ID);

            // Properties
            this.Property(t => t.Item088ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item088");
            this.Property(t => t.Item088ID).HasColumnName("Item088ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
