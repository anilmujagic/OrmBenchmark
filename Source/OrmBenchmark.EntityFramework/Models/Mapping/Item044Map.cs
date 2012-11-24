using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item044Map : EntityTypeConfiguration<Item044>
    {
        public Item044Map()
        {
            // Primary Key
            this.HasKey(t => t.Item044ID);

            // Properties
            this.Property(t => t.Item044ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item044");
            this.Property(t => t.Item044ID).HasColumnName("Item044ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
