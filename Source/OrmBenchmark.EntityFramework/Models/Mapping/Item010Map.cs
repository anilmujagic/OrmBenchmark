using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item010Map : EntityTypeConfiguration<Item010>
    {
        public Item010Map()
        {
            // Primary Key
            this.HasKey(t => t.Item010ID);

            // Properties
            this.Property(t => t.Item010ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item010");
            this.Property(t => t.Item010ID).HasColumnName("Item010ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
