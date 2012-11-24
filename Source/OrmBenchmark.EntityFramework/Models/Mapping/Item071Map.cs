using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item071Map : EntityTypeConfiguration<Item071>
    {
        public Item071Map()
        {
            // Primary Key
            this.HasKey(t => t.Item071ID);

            // Properties
            this.Property(t => t.Item071ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item071");
            this.Property(t => t.Item071ID).HasColumnName("Item071ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
