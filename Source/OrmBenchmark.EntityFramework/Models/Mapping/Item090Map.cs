using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item090Map : EntityTypeConfiguration<Item090>
    {
        public Item090Map()
        {
            // Primary Key
            this.HasKey(t => t.Item090ID);

            // Properties
            this.Property(t => t.Item090ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item090");
            this.Property(t => t.Item090ID).HasColumnName("Item090ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
