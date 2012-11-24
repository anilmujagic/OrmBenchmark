using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer042Map : EntityTypeConfiguration<Customer042>
    {
        public Customer042Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer042ID);

            // Properties
            this.Property(t => t.Customer042ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer042");
            this.Property(t => t.Customer042ID).HasColumnName("Customer042ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
