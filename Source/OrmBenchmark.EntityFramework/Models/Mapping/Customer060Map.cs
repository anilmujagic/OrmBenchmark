using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer060Map : EntityTypeConfiguration<Customer060>
    {
        public Customer060Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer060ID);

            // Properties
            this.Property(t => t.Customer060ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer060");
            this.Property(t => t.Customer060ID).HasColumnName("Customer060ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
