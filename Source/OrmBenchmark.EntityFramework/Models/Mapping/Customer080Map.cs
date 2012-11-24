using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer080Map : EntityTypeConfiguration<Customer080>
    {
        public Customer080Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer080ID);

            // Properties
            this.Property(t => t.Customer080ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer080");
            this.Property(t => t.Customer080ID).HasColumnName("Customer080ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
