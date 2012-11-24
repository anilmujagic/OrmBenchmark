using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer006Map : EntityTypeConfiguration<Customer006>
    {
        public Customer006Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer006ID);

            // Properties
            this.Property(t => t.Customer006ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer006");
            this.Property(t => t.Customer006ID).HasColumnName("Customer006ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
