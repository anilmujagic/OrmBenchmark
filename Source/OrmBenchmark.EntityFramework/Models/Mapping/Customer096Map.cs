using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer096Map : EntityTypeConfiguration<Customer096>
    {
        public Customer096Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer096ID);

            // Properties
            this.Property(t => t.Customer096ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer096");
            this.Property(t => t.Customer096ID).HasColumnName("Customer096ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
