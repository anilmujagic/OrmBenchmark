using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item095Map : EntityTypeConfiguration<Item095>
    {
        public Item095Map()
        {
            // Primary Key
            this.HasKey(t => t.Item095ID);

            // Properties
            this.Property(t => t.Item095ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item095");
            this.Property(t => t.Item095ID).HasColumnName("Item095ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
