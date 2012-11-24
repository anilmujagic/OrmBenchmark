using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item063Map : EntityTypeConfiguration<Item063>
    {
        public Item063Map()
        {
            // Primary Key
            this.HasKey(t => t.Item063ID);

            // Properties
            this.Property(t => t.Item063ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item063");
            this.Property(t => t.Item063ID).HasColumnName("Item063ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
