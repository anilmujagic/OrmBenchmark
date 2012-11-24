using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer050Map : EntityTypeConfiguration<Customer050>
    {
        public Customer050Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer050ID);

            // Properties
            this.Property(t => t.Customer050ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer050");
            this.Property(t => t.Customer050ID).HasColumnName("Customer050ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
