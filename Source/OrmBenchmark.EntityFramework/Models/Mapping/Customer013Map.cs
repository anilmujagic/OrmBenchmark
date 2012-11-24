using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer013Map : EntityTypeConfiguration<Customer013>
    {
        public Customer013Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer013ID);

            // Properties
            this.Property(t => t.Customer013ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer013");
            this.Property(t => t.Customer013ID).HasColumnName("Customer013ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
