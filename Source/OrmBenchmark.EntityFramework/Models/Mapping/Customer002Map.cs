using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer002Map : EntityTypeConfiguration<Customer002>
    {
        public Customer002Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer002ID);

            // Properties
            this.Property(t => t.Customer002ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer002");
            this.Property(t => t.Customer002ID).HasColumnName("Customer002ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
