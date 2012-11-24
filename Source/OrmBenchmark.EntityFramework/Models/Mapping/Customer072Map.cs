using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer072Map : EntityTypeConfiguration<Customer072>
    {
        public Customer072Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer072ID);

            // Properties
            this.Property(t => t.Customer072ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer072");
            this.Property(t => t.Customer072ID).HasColumnName("Customer072ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
