using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item036Map : EntityTypeConfiguration<Item036>
    {
        public Item036Map()
        {
            // Primary Key
            this.HasKey(t => t.Item036ID);

            // Properties
            this.Property(t => t.Item036ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item036");
            this.Property(t => t.Item036ID).HasColumnName("Item036ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
