using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer005Map : EntityTypeConfiguration<Customer005>
    {
        public Customer005Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer005ID);

            // Properties
            this.Property(t => t.Customer005ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer005");
            this.Property(t => t.Customer005ID).HasColumnName("Customer005ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
