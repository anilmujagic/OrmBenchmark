using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item064Map : EntityTypeConfiguration<Item064>
    {
        public Item064Map()
        {
            // Primary Key
            this.HasKey(t => t.Item064ID);

            // Properties
            this.Property(t => t.Item064ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item064");
            this.Property(t => t.Item064ID).HasColumnName("Item064ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
