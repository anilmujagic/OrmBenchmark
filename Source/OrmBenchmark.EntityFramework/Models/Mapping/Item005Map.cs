using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item005Map : EntityTypeConfiguration<Item005>
    {
        public Item005Map()
        {
            // Primary Key
            this.HasKey(t => t.Item005ID);

            // Properties
            this.Property(t => t.Item005ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item005");
            this.Property(t => t.Item005ID).HasColumnName("Item005ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
