using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item024Map : EntityTypeConfiguration<Item024>
    {
        public Item024Map()
        {
            // Primary Key
            this.HasKey(t => t.Item024ID);

            // Properties
            this.Property(t => t.Item024ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item024");
            this.Property(t => t.Item024ID).HasColumnName("Item024ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
