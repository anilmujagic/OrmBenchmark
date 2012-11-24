using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item026Map : EntityTypeConfiguration<Item026>
    {
        public Item026Map()
        {
            // Primary Key
            this.HasKey(t => t.Item026ID);

            // Properties
            this.Property(t => t.Item026ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item026");
            this.Property(t => t.Item026ID).HasColumnName("Item026ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
