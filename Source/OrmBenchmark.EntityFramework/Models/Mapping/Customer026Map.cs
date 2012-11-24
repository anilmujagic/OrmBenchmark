using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer026Map : EntityTypeConfiguration<Customer026>
    {
        public Customer026Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer026ID);

            // Properties
            this.Property(t => t.Customer026ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer026");
            this.Property(t => t.Customer026ID).HasColumnName("Customer026ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
