using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item035Map : EntityTypeConfiguration<Item035>
    {
        public Item035Map()
        {
            // Primary Key
            this.HasKey(t => t.Item035ID);

            // Properties
            this.Property(t => t.Item035ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item035");
            this.Property(t => t.Item035ID).HasColumnName("Item035ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
