using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer068Map : EntityTypeConfiguration<Customer068>
    {
        public Customer068Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer068ID);

            // Properties
            this.Property(t => t.Customer068ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer068");
            this.Property(t => t.Customer068ID).HasColumnName("Customer068ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
