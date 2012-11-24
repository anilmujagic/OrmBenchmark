using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer092Map : EntityTypeConfiguration<Customer092>
    {
        public Customer092Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer092ID);

            // Properties
            this.Property(t => t.Customer092ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer092");
            this.Property(t => t.Customer092ID).HasColumnName("Customer092ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
