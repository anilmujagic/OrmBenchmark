using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer075Map : EntityTypeConfiguration<Customer075>
    {
        public Customer075Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer075ID);

            // Properties
            this.Property(t => t.Customer075ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer075");
            this.Property(t => t.Customer075ID).HasColumnName("Customer075ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
