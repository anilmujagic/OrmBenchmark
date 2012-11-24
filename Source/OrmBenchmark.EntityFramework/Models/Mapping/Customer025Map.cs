using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer025Map : EntityTypeConfiguration<Customer025>
    {
        public Customer025Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer025ID);

            // Properties
            this.Property(t => t.Customer025ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer025");
            this.Property(t => t.Customer025ID).HasColumnName("Customer025ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
