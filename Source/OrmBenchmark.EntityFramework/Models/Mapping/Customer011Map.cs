using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer011Map : EntityTypeConfiguration<Customer011>
    {
        public Customer011Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer011ID);

            // Properties
            this.Property(t => t.Customer011ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer011");
            this.Property(t => t.Customer011ID).HasColumnName("Customer011ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}