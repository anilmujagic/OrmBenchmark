using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item083Map : EntityTypeConfiguration<Item083>
    {
        public Item083Map()
        {
            // Primary Key
            this.HasKey(t => t.Item083ID);

            // Properties
            this.Property(t => t.Item083ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item083");
            this.Property(t => t.Item083ID).HasColumnName("Item083ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
