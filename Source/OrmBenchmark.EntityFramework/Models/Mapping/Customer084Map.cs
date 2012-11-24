using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer084Map : EntityTypeConfiguration<Customer084>
    {
        public Customer084Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer084ID);

            // Properties
            this.Property(t => t.Customer084ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer084");
            this.Property(t => t.Customer084ID).HasColumnName("Customer084ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
