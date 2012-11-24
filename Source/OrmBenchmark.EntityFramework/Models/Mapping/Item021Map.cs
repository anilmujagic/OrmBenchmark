using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item021Map : EntityTypeConfiguration<Item021>
    {
        public Item021Map()
        {
            // Primary Key
            this.HasKey(t => t.Item021ID);

            // Properties
            this.Property(t => t.Item021ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item021");
            this.Property(t => t.Item021ID).HasColumnName("Item021ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
