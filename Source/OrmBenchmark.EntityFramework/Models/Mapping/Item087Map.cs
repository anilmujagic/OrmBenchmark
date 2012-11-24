using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item087Map : EntityTypeConfiguration<Item087>
    {
        public Item087Map()
        {
            // Primary Key
            this.HasKey(t => t.Item087ID);

            // Properties
            this.Property(t => t.Item087ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item087");
            this.Property(t => t.Item087ID).HasColumnName("Item087ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
