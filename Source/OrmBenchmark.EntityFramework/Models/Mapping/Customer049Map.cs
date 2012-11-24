using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer049Map : EntityTypeConfiguration<Customer049>
    {
        public Customer049Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer049ID);

            // Properties
            this.Property(t => t.Customer049ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer049");
            this.Property(t => t.Customer049ID).HasColumnName("Customer049ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
