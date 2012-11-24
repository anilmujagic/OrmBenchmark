using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer043Map : EntityTypeConfiguration<Customer043>
    {
        public Customer043Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer043ID);

            // Properties
            this.Property(t => t.Customer043ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer043");
            this.Property(t => t.Customer043ID).HasColumnName("Customer043ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
