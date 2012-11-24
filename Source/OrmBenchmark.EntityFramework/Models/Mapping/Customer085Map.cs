using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer085Map : EntityTypeConfiguration<Customer085>
    {
        public Customer085Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer085ID);

            // Properties
            this.Property(t => t.Customer085ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer085");
            this.Property(t => t.Customer085ID).HasColumnName("Customer085ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
