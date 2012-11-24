using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer097Map : EntityTypeConfiguration<Customer097>
    {
        public Customer097Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer097ID);

            // Properties
            this.Property(t => t.Customer097ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer097");
            this.Property(t => t.Customer097ID).HasColumnName("Customer097ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
