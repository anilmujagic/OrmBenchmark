using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item085Map : EntityTypeConfiguration<Item085>
    {
        public Item085Map()
        {
            // Primary Key
            this.HasKey(t => t.Item085ID);

            // Properties
            this.Property(t => t.Item085ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item085");
            this.Property(t => t.Item085ID).HasColumnName("Item085ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
