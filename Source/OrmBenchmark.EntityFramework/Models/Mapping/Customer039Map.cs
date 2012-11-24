using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer039Map : EntityTypeConfiguration<Customer039>
    {
        public Customer039Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer039ID);

            // Properties
            this.Property(t => t.Customer039ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer039");
            this.Property(t => t.Customer039ID).HasColumnName("Customer039ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
