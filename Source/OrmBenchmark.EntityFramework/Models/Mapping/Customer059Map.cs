using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer059Map : EntityTypeConfiguration<Customer059>
    {
        public Customer059Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer059ID);

            // Properties
            this.Property(t => t.Customer059ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer059");
            this.Property(t => t.Customer059ID).HasColumnName("Customer059ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
