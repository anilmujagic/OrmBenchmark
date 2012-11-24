using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item002Map : EntityTypeConfiguration<Item002>
    {
        public Item002Map()
        {
            // Primary Key
            this.HasKey(t => t.Item002ID);

            // Properties
            this.Property(t => t.Item002ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item002");
            this.Property(t => t.Item002ID).HasColumnName("Item002ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
