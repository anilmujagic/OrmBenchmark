using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer037Map : EntityTypeConfiguration<Customer037>
    {
        public Customer037Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer037ID);

            // Properties
            this.Property(t => t.Customer037ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer037");
            this.Property(t => t.Customer037ID).HasColumnName("Customer037ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
