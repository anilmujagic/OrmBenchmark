using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer098Map : EntityTypeConfiguration<Customer098>
    {
        public Customer098Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer098ID);

            // Properties
            this.Property(t => t.Customer098ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer098");
            this.Property(t => t.Customer098ID).HasColumnName("Customer098ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
