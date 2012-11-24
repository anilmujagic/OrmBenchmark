using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer074Map : EntityTypeConfiguration<Customer074>
    {
        public Customer074Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer074ID);

            // Properties
            this.Property(t => t.Customer074ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer074");
            this.Property(t => t.Customer074ID).HasColumnName("Customer074ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
