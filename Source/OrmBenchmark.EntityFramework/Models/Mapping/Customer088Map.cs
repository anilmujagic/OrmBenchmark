using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer088Map : EntityTypeConfiguration<Customer088>
    {
        public Customer088Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer088ID);

            // Properties
            this.Property(t => t.Customer088ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer088");
            this.Property(t => t.Customer088ID).HasColumnName("Customer088ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
