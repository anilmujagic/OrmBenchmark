using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item099Map : EntityTypeConfiguration<Item099>
    {
        public Item099Map()
        {
            // Primary Key
            this.HasKey(t => t.Item099ID);

            // Properties
            this.Property(t => t.Item099ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item099");
            this.Property(t => t.Item099ID).HasColumnName("Item099ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
