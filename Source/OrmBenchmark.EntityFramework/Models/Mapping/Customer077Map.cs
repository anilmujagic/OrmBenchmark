using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer077Map : EntityTypeConfiguration<Customer077>
    {
        public Customer077Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer077ID);

            // Properties
            this.Property(t => t.Customer077ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer077");
            this.Property(t => t.Customer077ID).HasColumnName("Customer077ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
