using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item081Map : EntityTypeConfiguration<Item081>
    {
        public Item081Map()
        {
            // Primary Key
            this.HasKey(t => t.Item081ID);

            // Properties
            this.Property(t => t.Item081ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item081");
            this.Property(t => t.Item081ID).HasColumnName("Item081ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
