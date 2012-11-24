using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer027Map : EntityTypeConfiguration<Customer027>
    {
        public Customer027Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer027ID);

            // Properties
            this.Property(t => t.Customer027ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer027");
            this.Property(t => t.Customer027ID).HasColumnName("Customer027ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
