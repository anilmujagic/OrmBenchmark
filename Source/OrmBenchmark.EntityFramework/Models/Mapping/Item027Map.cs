using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item027Map : EntityTypeConfiguration<Item027>
    {
        public Item027Map()
        {
            // Primary Key
            this.HasKey(t => t.Item027ID);

            // Properties
            this.Property(t => t.Item027ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item027");
            this.Property(t => t.Item027ID).HasColumnName("Item027ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
