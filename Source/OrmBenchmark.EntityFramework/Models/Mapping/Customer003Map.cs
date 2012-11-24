using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer003Map : EntityTypeConfiguration<Customer003>
    {
        public Customer003Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer003ID);

            // Properties
            this.Property(t => t.Customer003ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer003");
            this.Property(t => t.Customer003ID).HasColumnName("Customer003ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
