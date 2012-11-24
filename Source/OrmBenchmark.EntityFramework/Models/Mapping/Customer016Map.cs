using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer016Map : EntityTypeConfiguration<Customer016>
    {
        public Customer016Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer016ID);

            // Properties
            this.Property(t => t.Customer016ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer016");
            this.Property(t => t.Customer016ID).HasColumnName("Customer016ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
