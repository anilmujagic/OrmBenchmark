using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer023Map : EntityTypeConfiguration<Customer023>
    {
        public Customer023Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer023ID);

            // Properties
            this.Property(t => t.Customer023ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer023");
            this.Property(t => t.Customer023ID).HasColumnName("Customer023ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
