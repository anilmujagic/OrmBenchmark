using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer058Map : EntityTypeConfiguration<Customer058>
    {
        public Customer058Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer058ID);

            // Properties
            this.Property(t => t.Customer058ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer058");
            this.Property(t => t.Customer058ID).HasColumnName("Customer058ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
