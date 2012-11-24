using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer018Map : EntityTypeConfiguration<Customer018>
    {
        public Customer018Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer018ID);

            // Properties
            this.Property(t => t.Customer018ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer018");
            this.Property(t => t.Customer018ID).HasColumnName("Customer018ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
