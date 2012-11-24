using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer028Map : EntityTypeConfiguration<Customer028>
    {
        public Customer028Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer028ID);

            // Properties
            this.Property(t => t.Customer028ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer028");
            this.Property(t => t.Customer028ID).HasColumnName("Customer028ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
