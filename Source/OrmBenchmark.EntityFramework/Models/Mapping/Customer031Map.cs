using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer031Map : EntityTypeConfiguration<Customer031>
    {
        public Customer031Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer031ID);

            // Properties
            this.Property(t => t.Customer031ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer031");
            this.Property(t => t.Customer031ID).HasColumnName("Customer031ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
