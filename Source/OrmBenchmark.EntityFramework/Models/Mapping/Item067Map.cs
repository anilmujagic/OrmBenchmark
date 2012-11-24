using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item067Map : EntityTypeConfiguration<Item067>
    {
        public Item067Map()
        {
            // Primary Key
            this.HasKey(t => t.Item067ID);

            // Properties
            this.Property(t => t.Item067ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item067");
            this.Property(t => t.Item067ID).HasColumnName("Item067ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
