using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item001Map : EntityTypeConfiguration<Item001>
    {
        public Item001Map()
        {
            // Primary Key
            this.HasKey(t => t.Item001ID);

            // Properties
            this.Property(t => t.Item001ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item001");
            this.Property(t => t.Item001ID).HasColumnName("Item001ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
