using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer029Map : EntityTypeConfiguration<Customer029>
    {
        public Customer029Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer029ID);

            // Properties
            this.Property(t => t.Customer029ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer029");
            this.Property(t => t.Customer029ID).HasColumnName("Customer029ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
