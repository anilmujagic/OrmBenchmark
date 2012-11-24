using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer062Map : EntityTypeConfiguration<Customer062>
    {
        public Customer062Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer062ID);

            // Properties
            this.Property(t => t.Customer062ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer062");
            this.Property(t => t.Customer062ID).HasColumnName("Customer062ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
