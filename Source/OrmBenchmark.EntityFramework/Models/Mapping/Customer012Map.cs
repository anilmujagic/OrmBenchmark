using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer012Map : EntityTypeConfiguration<Customer012>
    {
        public Customer012Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer012ID);

            // Properties
            this.Property(t => t.Customer012ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer012");
            this.Property(t => t.Customer012ID).HasColumnName("Customer012ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
