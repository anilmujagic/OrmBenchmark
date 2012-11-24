using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item062Map : EntityTypeConfiguration<Item062>
    {
        public Item062Map()
        {
            // Primary Key
            this.HasKey(t => t.Item062ID);

            // Properties
            this.Property(t => t.Item062ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item062");
            this.Property(t => t.Item062ID).HasColumnName("Item062ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
