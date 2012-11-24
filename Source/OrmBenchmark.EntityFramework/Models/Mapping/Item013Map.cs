using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item013Map : EntityTypeConfiguration<Item013>
    {
        public Item013Map()
        {
            // Primary Key
            this.HasKey(t => t.Item013ID);

            // Properties
            this.Property(t => t.Item013ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item013");
            this.Property(t => t.Item013ID).HasColumnName("Item013ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
