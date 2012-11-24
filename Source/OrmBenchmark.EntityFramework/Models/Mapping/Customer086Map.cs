using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer086Map : EntityTypeConfiguration<Customer086>
    {
        public Customer086Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer086ID);

            // Properties
            this.Property(t => t.Customer086ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer086");
            this.Property(t => t.Customer086ID).HasColumnName("Customer086ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
