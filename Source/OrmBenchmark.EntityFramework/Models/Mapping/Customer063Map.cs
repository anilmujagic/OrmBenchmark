using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer063Map : EntityTypeConfiguration<Customer063>
    {
        public Customer063Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer063ID);

            // Properties
            this.Property(t => t.Customer063ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer063");
            this.Property(t => t.Customer063ID).HasColumnName("Customer063ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
