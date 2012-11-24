using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer079Map : EntityTypeConfiguration<Customer079>
    {
        public Customer079Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer079ID);

            // Properties
            this.Property(t => t.Customer079ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer079");
            this.Property(t => t.Customer079ID).HasColumnName("Customer079ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}