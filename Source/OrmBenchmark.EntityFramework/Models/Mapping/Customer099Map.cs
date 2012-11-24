using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer099Map : EntityTypeConfiguration<Customer099>
    {
        public Customer099Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer099ID);

            // Properties
            this.Property(t => t.Customer099ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer099");
            this.Property(t => t.Customer099ID).HasColumnName("Customer099ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
