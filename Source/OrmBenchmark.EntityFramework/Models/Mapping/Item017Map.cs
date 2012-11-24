using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item017Map : EntityTypeConfiguration<Item017>
    {
        public Item017Map()
        {
            // Primary Key
            this.HasKey(t => t.Item017ID);

            // Properties
            this.Property(t => t.Item017ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item017");
            this.Property(t => t.Item017ID).HasColumnName("Item017ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
