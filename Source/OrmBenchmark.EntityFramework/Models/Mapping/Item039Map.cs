using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item039Map : EntityTypeConfiguration<Item039>
    {
        public Item039Map()
        {
            // Primary Key
            this.HasKey(t => t.Item039ID);

            // Properties
            this.Property(t => t.Item039ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item039");
            this.Property(t => t.Item039ID).HasColumnName("Item039ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
