using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item028Map : EntityTypeConfiguration<Item028>
    {
        public Item028Map()
        {
            // Primary Key
            this.HasKey(t => t.Item028ID);

            // Properties
            this.Property(t => t.Item028ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item028");
            this.Property(t => t.Item028ID).HasColumnName("Item028ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
