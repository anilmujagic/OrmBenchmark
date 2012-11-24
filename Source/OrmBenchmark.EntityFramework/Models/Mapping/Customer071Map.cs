using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer071Map : EntityTypeConfiguration<Customer071>
    {
        public Customer071Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer071ID);

            // Properties
            this.Property(t => t.Customer071ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer071");
            this.Property(t => t.Customer071ID).HasColumnName("Customer071ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
