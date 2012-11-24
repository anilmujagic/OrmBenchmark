using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer078Map : EntityTypeConfiguration<Customer078>
    {
        public Customer078Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer078ID);

            // Properties
            this.Property(t => t.Customer078ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer078");
            this.Property(t => t.Customer078ID).HasColumnName("Customer078ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
