using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item082Map : EntityTypeConfiguration<Item082>
    {
        public Item082Map()
        {
            // Primary Key
            this.HasKey(t => t.Item082ID);

            // Properties
            this.Property(t => t.Item082ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item082");
            this.Property(t => t.Item082ID).HasColumnName("Item082ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
