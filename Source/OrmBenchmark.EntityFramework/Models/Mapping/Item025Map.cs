using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item025Map : EntityTypeConfiguration<Item025>
    {
        public Item025Map()
        {
            // Primary Key
            this.HasKey(t => t.Item025ID);

            // Properties
            this.Property(t => t.Item025ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item025");
            this.Property(t => t.Item025ID).HasColumnName("Item025ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
