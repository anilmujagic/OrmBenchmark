using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item019Map : EntityTypeConfiguration<Item019>
    {
        public Item019Map()
        {
            // Primary Key
            this.HasKey(t => t.Item019ID);

            // Properties
            this.Property(t => t.Item019ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item019");
            this.Property(t => t.Item019ID).HasColumnName("Item019ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
