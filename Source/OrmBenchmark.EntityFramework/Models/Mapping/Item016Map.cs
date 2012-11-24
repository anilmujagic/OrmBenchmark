using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item016Map : EntityTypeConfiguration<Item016>
    {
        public Item016Map()
        {
            // Primary Key
            this.HasKey(t => t.Item016ID);

            // Properties
            this.Property(t => t.Item016ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item016");
            this.Property(t => t.Item016ID).HasColumnName("Item016ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
