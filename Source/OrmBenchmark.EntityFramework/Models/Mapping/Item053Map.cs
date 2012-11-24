using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item053Map : EntityTypeConfiguration<Item053>
    {
        public Item053Map()
        {
            // Primary Key
            this.HasKey(t => t.Item053ID);

            // Properties
            this.Property(t => t.Item053ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item053");
            this.Property(t => t.Item053ID).HasColumnName("Item053ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
