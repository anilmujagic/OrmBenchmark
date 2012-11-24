using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item069Map : EntityTypeConfiguration<Item069>
    {
        public Item069Map()
        {
            // Primary Key
            this.HasKey(t => t.Item069ID);

            // Properties
            this.Property(t => t.Item069ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item069");
            this.Property(t => t.Item069ID).HasColumnName("Item069ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
