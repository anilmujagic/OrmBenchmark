using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer100Map : EntityTypeConfiguration<Customer100>
    {
        public Customer100Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer100ID);

            // Properties
            this.Property(t => t.Customer100ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer100");
            this.Property(t => t.Customer100ID).HasColumnName("Customer100ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
