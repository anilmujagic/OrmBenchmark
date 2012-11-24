using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item068Map : EntityTypeConfiguration<Item068>
    {
        public Item068Map()
        {
            // Primary Key
            this.HasKey(t => t.Item068ID);

            // Properties
            this.Property(t => t.Item068ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item068");
            this.Property(t => t.Item068ID).HasColumnName("Item068ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
