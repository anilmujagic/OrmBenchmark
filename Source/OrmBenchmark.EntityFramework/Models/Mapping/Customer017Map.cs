using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer017Map : EntityTypeConfiguration<Customer017>
    {
        public Customer017Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer017ID);

            // Properties
            this.Property(t => t.Customer017ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer017");
            this.Property(t => t.Customer017ID).HasColumnName("Customer017ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
