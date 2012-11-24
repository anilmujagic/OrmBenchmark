using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer065Map : EntityTypeConfiguration<Customer065>
    {
        public Customer065Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer065ID);

            // Properties
            this.Property(t => t.Customer065ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer065");
            this.Property(t => t.Customer065ID).HasColumnName("Customer065ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
