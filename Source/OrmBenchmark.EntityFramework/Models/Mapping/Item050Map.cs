using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Item050Map : EntityTypeConfiguration<Item050>
    {
        public Item050Map()
        {
            // Primary Key
            this.HasKey(t => t.Item050ID);

            // Properties
            this.Property(t => t.Item050ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Item050");
            this.Property(t => t.Item050ID).HasColumnName("Item050ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
