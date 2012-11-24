using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer033Map : EntityTypeConfiguration<Customer033>
    {
        public Customer033Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer033ID);

            // Properties
            this.Property(t => t.Customer033ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer033");
            this.Property(t => t.Customer033ID).HasColumnName("Customer033ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
