using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item018Map : EntityTypeConfiguration<Item018>
    {
        public Item018Map()
        {
            // Primary Key
            this.HasKey(t => t.Item018ID);

            // Properties
            this.Property(t => t.Item018ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item018");
            this.Property(t => t.Item018ID).HasColumnName("Item018ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
