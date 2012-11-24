using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer094Map : EntityTypeConfiguration<Customer094>
    {
        public Customer094Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer094ID);

            // Properties
            this.Property(t => t.Customer094ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer094");
            this.Property(t => t.Customer094ID).HasColumnName("Customer094ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
