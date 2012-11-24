using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item038Map : EntityTypeConfiguration<Item038>
    {
        public Item038Map()
        {
            // Primary Key
            this.HasKey(t => t.Item038ID);

            // Properties
            this.Property(t => t.Item038ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item038");
            this.Property(t => t.Item038ID).HasColumnName("Item038ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
