using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item029Map : EntityTypeConfiguration<Item029>
    {
        public Item029Map()
        {
            // Primary Key
            this.HasKey(t => t.Item029ID);

            // Properties
            this.Property(t => t.Item029ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item029");
            this.Property(t => t.Item029ID).HasColumnName("Item029ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
