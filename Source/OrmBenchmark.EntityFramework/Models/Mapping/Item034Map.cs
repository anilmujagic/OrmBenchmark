using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item034Map : EntityTypeConfiguration<Item034>
    {
        public Item034Map()
        {
            // Primary Key
            this.HasKey(t => t.Item034ID);

            // Properties
            this.Property(t => t.Item034ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item034");
            this.Property(t => t.Item034ID).HasColumnName("Item034ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
