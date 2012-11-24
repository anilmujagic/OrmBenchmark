using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer035Map : EntityTypeConfiguration<Customer035>
    {
        public Customer035Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer035ID);

            // Properties
            this.Property(t => t.Customer035ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer035");
            this.Property(t => t.Customer035ID).HasColumnName("Customer035ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
