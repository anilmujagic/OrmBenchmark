using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer070Map : EntityTypeConfiguration<Customer070>
    {
        public Customer070Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer070ID);

            // Properties
            this.Property(t => t.Customer070ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer070");
            this.Property(t => t.Customer070ID).HasColumnName("Customer070ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
