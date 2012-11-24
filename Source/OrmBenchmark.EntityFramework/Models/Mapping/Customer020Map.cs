using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer020Map : EntityTypeConfiguration<Customer020>
    {
        public Customer020Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer020ID);

            // Properties
            this.Property(t => t.Customer020ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer020");
            this.Property(t => t.Customer020ID).HasColumnName("Customer020ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
