using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item032Map : EntityTypeConfiguration<Item032>
    {
        public Item032Map()
        {
            // Primary Key
            this.HasKey(t => t.Item032ID);

            // Properties
            this.Property(t => t.Item032ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item032");
            this.Property(t => t.Item032ID).HasColumnName("Item032ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
