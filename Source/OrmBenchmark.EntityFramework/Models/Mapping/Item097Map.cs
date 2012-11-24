using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item097Map : EntityTypeConfiguration<Item097>
    {
        public Item097Map()
        {
            // Primary Key
            this.HasKey(t => t.Item097ID);

            // Properties
            this.Property(t => t.Item097ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item097");
            this.Property(t => t.Item097ID).HasColumnName("Item097ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
