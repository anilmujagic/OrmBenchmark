using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer019Map : EntityTypeConfiguration<Customer019>
    {
        public Customer019Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer019ID);

            // Properties
            this.Property(t => t.Customer019ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer019");
            this.Property(t => t.Customer019ID).HasColumnName("Customer019ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
