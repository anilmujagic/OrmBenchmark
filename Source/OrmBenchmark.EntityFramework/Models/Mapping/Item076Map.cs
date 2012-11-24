using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item076Map : EntityTypeConfiguration<Item076>
    {
        public Item076Map()
        {
            // Primary Key
            this.HasKey(t => t.Item076ID);

            // Properties
            this.Property(t => t.Item076ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item076");
            this.Property(t => t.Item076ID).HasColumnName("Item076ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
