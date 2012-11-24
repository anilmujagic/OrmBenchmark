using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item080Map : EntityTypeConfiguration<Item080>
    {
        public Item080Map()
        {
            // Primary Key
            this.HasKey(t => t.Item080ID);

            // Properties
            this.Property(t => t.Item080ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item080");
            this.Property(t => t.Item080ID).HasColumnName("Item080ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
