using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item015Map : EntityTypeConfiguration<Item015>
    {
        public Item015Map()
        {
            // Primary Key
            this.HasKey(t => t.Item015ID);

            // Properties
            this.Property(t => t.Item015ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item015");
            this.Property(t => t.Item015ID).HasColumnName("Item015ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
