using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer030Map : EntityTypeConfiguration<Customer030>
    {
        public Customer030Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer030ID);

            // Properties
            this.Property(t => t.Customer030ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer030");
            this.Property(t => t.Customer030ID).HasColumnName("Customer030ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
