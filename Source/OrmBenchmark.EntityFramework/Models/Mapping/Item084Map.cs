using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item084Map : EntityTypeConfiguration<Item084>
    {
        public Item084Map()
        {
            // Primary Key
            this.HasKey(t => t.Item084ID);

            // Properties
            this.Property(t => t.Item084ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item084");
            this.Property(t => t.Item084ID).HasColumnName("Item084ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
