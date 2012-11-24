using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer048Map : EntityTypeConfiguration<Customer048>
    {
        public Customer048Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer048ID);

            // Properties
            this.Property(t => t.Customer048ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer048");
            this.Property(t => t.Customer048ID).HasColumnName("Customer048ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
