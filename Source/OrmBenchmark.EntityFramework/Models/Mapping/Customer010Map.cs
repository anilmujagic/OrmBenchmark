using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer010Map : EntityTypeConfiguration<Customer010>
    {
        public Customer010Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer010ID);

            // Properties
            this.Property(t => t.Customer010ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer010");
            this.Property(t => t.Customer010ID).HasColumnName("Customer010ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
