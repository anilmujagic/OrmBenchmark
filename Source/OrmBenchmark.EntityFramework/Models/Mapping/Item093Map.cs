using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item093Map : EntityTypeConfiguration<Item093>
    {
        public Item093Map()
        {
            // Primary Key
            this.HasKey(t => t.Item093ID);

            // Properties
            this.Property(t => t.Item093ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item093");
            this.Property(t => t.Item093ID).HasColumnName("Item093ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
