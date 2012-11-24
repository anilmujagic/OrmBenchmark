using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item072Map : EntityTypeConfiguration<Item072>
    {
        public Item072Map()
        {
            // Primary Key
            this.HasKey(t => t.Item072ID);

            // Properties
            this.Property(t => t.Item072ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item072");
            this.Property(t => t.Item072ID).HasColumnName("Item072ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
