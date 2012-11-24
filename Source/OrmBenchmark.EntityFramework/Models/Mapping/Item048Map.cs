using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item048Map : EntityTypeConfiguration<Item048>
    {
        public Item048Map()
        {
            // Primary Key
            this.HasKey(t => t.Item048ID);

            // Properties
            this.Property(t => t.Item048ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item048");
            this.Property(t => t.Item048ID).HasColumnName("Item048ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
