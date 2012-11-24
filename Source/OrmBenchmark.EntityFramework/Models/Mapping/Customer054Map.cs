using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer054Map : EntityTypeConfiguration<Customer054>
    {
        public Customer054Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer054ID);

            // Properties
            this.Property(t => t.Customer054ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer054");
            this.Property(t => t.Customer054ID).HasColumnName("Customer054ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
