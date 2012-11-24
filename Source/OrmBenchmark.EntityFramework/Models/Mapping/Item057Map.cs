using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item057Map : EntityTypeConfiguration<Item057>
    {
        public Item057Map()
        {
            // Primary Key
            this.HasKey(t => t.Item057ID);

            // Properties
            this.Property(t => t.Item057ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item057");
            this.Property(t => t.Item057ID).HasColumnName("Item057ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
