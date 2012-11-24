using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer015Map : EntityTypeConfiguration<Customer015>
    {
        public Customer015Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer015ID);

            // Properties
            this.Property(t => t.Customer015ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer015");
            this.Property(t => t.Customer015ID).HasColumnName("Customer015ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
