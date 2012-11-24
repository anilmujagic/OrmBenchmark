using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item012Map : EntityTypeConfiguration<Item012>
    {
        public Item012Map()
        {
            // Primary Key
            this.HasKey(t => t.Item012ID);

            // Properties
            this.Property(t => t.Item012ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item012");
            this.Property(t => t.Item012ID).HasColumnName("Item012ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
