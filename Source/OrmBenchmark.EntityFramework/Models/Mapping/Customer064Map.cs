using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer064Map : EntityTypeConfiguration<Customer064>
    {
        public Customer064Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer064ID);

            // Properties
            this.Property(t => t.Customer064ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer064");
            this.Property(t => t.Customer064ID).HasColumnName("Customer064ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
