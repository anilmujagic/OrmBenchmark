using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item009Map : EntityTypeConfiguration<Item009>
    {
        public Item009Map()
        {
            // Primary Key
            this.HasKey(t => t.Item009ID);

            // Properties
            this.Property(t => t.Item009ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item009");
            this.Property(t => t.Item009ID).HasColumnName("Item009ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
