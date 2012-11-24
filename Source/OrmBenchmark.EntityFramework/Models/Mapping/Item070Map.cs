using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item070Map : EntityTypeConfiguration<Item070>
    {
        public Item070Map()
        {
            // Primary Key
            this.HasKey(t => t.Item070ID);

            // Properties
            this.Property(t => t.Item070ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item070");
            this.Property(t => t.Item070ID).HasColumnName("Item070ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
