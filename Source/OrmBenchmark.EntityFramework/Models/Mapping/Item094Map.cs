using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item094Map : EntityTypeConfiguration<Item094>
    {
        public Item094Map()
        {
            // Primary Key
            this.HasKey(t => t.Item094ID);

            // Properties
            this.Property(t => t.Item094ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item094");
            this.Property(t => t.Item094ID).HasColumnName("Item094ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
