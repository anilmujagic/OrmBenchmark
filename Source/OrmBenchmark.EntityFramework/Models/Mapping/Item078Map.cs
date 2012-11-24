using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item078Map : EntityTypeConfiguration<Item078>
    {
        public Item078Map()
        {
            // Primary Key
            this.HasKey(t => t.Item078ID);

            // Properties
            this.Property(t => t.Item078ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item078");
            this.Property(t => t.Item078ID).HasColumnName("Item078ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
