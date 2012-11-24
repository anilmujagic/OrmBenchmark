using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer007Map : EntityTypeConfiguration<Customer007>
    {
        public Customer007Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer007ID);

            // Properties
            this.Property(t => t.Customer007ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer007");
            this.Property(t => t.Customer007ID).HasColumnName("Customer007ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
