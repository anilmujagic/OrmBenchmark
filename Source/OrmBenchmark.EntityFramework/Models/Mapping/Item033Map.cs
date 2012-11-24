using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item033Map : EntityTypeConfiguration<Item033>
    {
        public Item033Map()
        {
            // Primary Key
            this.HasKey(t => t.Item033ID);

            // Properties
            this.Property(t => t.Item033ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item033");
            this.Property(t => t.Item033ID).HasColumnName("Item033ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
