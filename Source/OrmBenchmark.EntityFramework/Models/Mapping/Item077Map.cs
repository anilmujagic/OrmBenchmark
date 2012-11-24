using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item077Map : EntityTypeConfiguration<Item077>
    {
        public Item077Map()
        {
            // Primary Key
            this.HasKey(t => t.Item077ID);

            // Properties
            this.Property(t => t.Item077ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item077");
            this.Property(t => t.Item077ID).HasColumnName("Item077ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
