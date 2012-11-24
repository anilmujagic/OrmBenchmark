using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item043Map : EntityTypeConfiguration<Item043>
    {
        public Item043Map()
        {
            // Primary Key
            this.HasKey(t => t.Item043ID);

            // Properties
            this.Property(t => t.Item043ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item043");
            this.Property(t => t.Item043ID).HasColumnName("Item043ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
