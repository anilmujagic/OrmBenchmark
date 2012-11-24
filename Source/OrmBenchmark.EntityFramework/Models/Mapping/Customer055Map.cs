using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer055Map : EntityTypeConfiguration<Customer055>
    {
        public Customer055Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer055ID);

            // Properties
            this.Property(t => t.Customer055ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer055");
            this.Property(t => t.Customer055ID).HasColumnName("Customer055ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
