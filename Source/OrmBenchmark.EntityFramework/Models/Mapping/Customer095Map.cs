using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer095Map : EntityTypeConfiguration<Customer095>
    {
        public Customer095Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer095ID);

            // Properties
            this.Property(t => t.Customer095ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer095");
            this.Property(t => t.Customer095ID).HasColumnName("Customer095ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
