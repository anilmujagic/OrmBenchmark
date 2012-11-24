using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer034Map : EntityTypeConfiguration<Customer034>
    {
        public Customer034Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer034ID);

            // Properties
            this.Property(t => t.Customer034ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer034");
            this.Property(t => t.Customer034ID).HasColumnName("Customer034ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
