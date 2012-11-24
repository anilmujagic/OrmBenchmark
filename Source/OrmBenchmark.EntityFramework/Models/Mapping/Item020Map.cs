using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item020Map : EntityTypeConfiguration<Item020>
    {
        public Item020Map()
        {
            // Primary Key
            this.HasKey(t => t.Item020ID);

            // Properties
            this.Property(t => t.Item020ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item020");
            this.Property(t => t.Item020ID).HasColumnName("Item020ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
