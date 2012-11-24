using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item011Map : EntityTypeConfiguration<Item011>
    {
        public Item011Map()
        {
            // Primary Key
            this.HasKey(t => t.Item011ID);

            // Properties
            this.Property(t => t.Item011ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item011");
            this.Property(t => t.Item011ID).HasColumnName("Item011ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
