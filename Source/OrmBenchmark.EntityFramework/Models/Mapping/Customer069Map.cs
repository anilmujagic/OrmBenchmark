using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer069Map : EntityTypeConfiguration<Customer069>
    {
        public Customer069Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer069ID);

            // Properties
            this.Property(t => t.Customer069ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer069");
            this.Property(t => t.Customer069ID).HasColumnName("Customer069ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
