using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item040Map : EntityTypeConfiguration<Item040>
    {
        public Item040Map()
        {
            // Primary Key
            this.HasKey(t => t.Item040ID);

            // Properties
            this.Property(t => t.Item040ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item040");
            this.Property(t => t.Item040ID).HasColumnName("Item040ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
