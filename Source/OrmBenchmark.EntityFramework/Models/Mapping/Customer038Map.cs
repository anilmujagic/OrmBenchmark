using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer038Map : EntityTypeConfiguration<Customer038>
    {
        public Customer038Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer038ID);

            // Properties
            this.Property(t => t.Customer038ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer038");
            this.Property(t => t.Customer038ID).HasColumnName("Customer038ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
