using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer021Map : EntityTypeConfiguration<Customer021>
    {
        public Customer021Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer021ID);

            // Properties
            this.Property(t => t.Customer021ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer021");
            this.Property(t => t.Customer021ID).HasColumnName("Customer021ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
