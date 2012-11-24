using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item054Map : EntityTypeConfiguration<Item054>
    {
        public Item054Map()
        {
            // Primary Key
            this.HasKey(t => t.Item054ID);

            // Properties
            this.Property(t => t.Item054ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item054");
            this.Property(t => t.Item054ID).HasColumnName("Item054ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
