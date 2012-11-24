using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer051Map : EntityTypeConfiguration<Customer051>
    {
        public Customer051Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer051ID);

            // Properties
            this.Property(t => t.Customer051ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer051");
            this.Property(t => t.Customer051ID).HasColumnName("Customer051ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
