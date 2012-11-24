using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer076Map : EntityTypeConfiguration<Customer076>
    {
        public Customer076Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer076ID);

            // Properties
            this.Property(t => t.Customer076ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer076");
            this.Property(t => t.Customer076ID).HasColumnName("Customer076ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
