using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item059Map : EntityTypeConfiguration<Item059>
    {
        public Item059Map()
        {
            // Primary Key
            this.HasKey(t => t.Item059ID);

            // Properties
            this.Property(t => t.Item059ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item059");
            this.Property(t => t.Item059ID).HasColumnName("Item059ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
