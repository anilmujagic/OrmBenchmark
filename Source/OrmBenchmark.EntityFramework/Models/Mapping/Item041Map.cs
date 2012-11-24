using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item041Map : EntityTypeConfiguration<Item041>
    {
        public Item041Map()
        {
            // Primary Key
            this.HasKey(t => t.Item041ID);

            // Properties
            this.Property(t => t.Item041ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item041");
            this.Property(t => t.Item041ID).HasColumnName("Item041ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
