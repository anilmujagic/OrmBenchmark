using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer047Map : EntityTypeConfiguration<Customer047>
    {
        public Customer047Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer047ID);

            // Properties
            this.Property(t => t.Customer047ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer047");
            this.Property(t => t.Customer047ID).HasColumnName("Customer047ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
