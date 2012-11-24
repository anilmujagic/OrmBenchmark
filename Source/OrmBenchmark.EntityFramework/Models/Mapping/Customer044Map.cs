using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer044Map : EntityTypeConfiguration<Customer044>
    {
        public Customer044Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer044ID);

            // Properties
            this.Property(t => t.Customer044ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer044");
            this.Property(t => t.Customer044ID).HasColumnName("Customer044ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
