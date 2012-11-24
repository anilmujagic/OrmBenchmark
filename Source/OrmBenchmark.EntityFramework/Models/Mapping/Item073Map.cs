using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item073Map : EntityTypeConfiguration<Item073>
    {
        public Item073Map()
        {
            // Primary Key
            this.HasKey(t => t.Item073ID);

            // Properties
            this.Property(t => t.Item073ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item073");
            this.Property(t => t.Item073ID).HasColumnName("Item073ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}