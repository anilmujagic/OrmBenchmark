using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer045Map : EntityTypeConfiguration<Customer045>
    {
        public Customer045Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer045ID);

            // Properties
            this.Property(t => t.Customer045ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer045");
            this.Property(t => t.Customer045ID).HasColumnName("Customer045ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
