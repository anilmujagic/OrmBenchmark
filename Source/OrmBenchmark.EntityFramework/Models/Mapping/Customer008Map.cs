using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer008Map : EntityTypeConfiguration<Customer008>
    {
        public Customer008Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer008ID);

            // Properties
            this.Property(t => t.Customer008ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer008");
            this.Property(t => t.Customer008ID).HasColumnName("Customer008ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
