using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer067Map : EntityTypeConfiguration<Customer067>
    {
        public Customer067Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer067ID);

            // Properties
            this.Property(t => t.Customer067ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer067");
            this.Property(t => t.Customer067ID).HasColumnName("Customer067ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
