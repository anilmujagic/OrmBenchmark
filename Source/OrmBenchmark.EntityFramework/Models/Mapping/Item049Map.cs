using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item049Map : EntityTypeConfiguration<Item049>
    {
        public Item049Map()
        {
            // Primary Key
            this.HasKey(t => t.Item049ID);

            // Properties
            this.Property(t => t.Item049ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item049");
            this.Property(t => t.Item049ID).HasColumnName("Item049ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
