using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer087Map : EntityTypeConfiguration<Customer087>
    {
        public Customer087Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer087ID);

            // Properties
            this.Property(t => t.Customer087ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer087");
            this.Property(t => t.Customer087ID).HasColumnName("Customer087ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
