using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item004Map : EntityTypeConfiguration<Item004>
    {
        public Item004Map()
        {
            // Primary Key
            this.HasKey(t => t.Item004ID);

            // Properties
            this.Property(t => t.Item004ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item004");
            this.Property(t => t.Item004ID).HasColumnName("Item004ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
