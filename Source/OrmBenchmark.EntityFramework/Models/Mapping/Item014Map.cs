using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item014Map : EntityTypeConfiguration<Item014>
    {
        public Item014Map()
        {
            // Primary Key
            this.HasKey(t => t.Item014ID);

            // Properties
            this.Property(t => t.Item014ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item014");
            this.Property(t => t.Item014ID).HasColumnName("Item014ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
