using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item023Map : EntityTypeConfiguration<Item023>
    {
        public Item023Map()
        {
            // Primary Key
            this.HasKey(t => t.Item023ID);

            // Properties
            this.Property(t => t.Item023ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item023");
            this.Property(t => t.Item023ID).HasColumnName("Item023ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
