using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer053Map : EntityTypeConfiguration<Customer053>
    {
        public Customer053Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer053ID);

            // Properties
            this.Property(t => t.Customer053ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer053");
            this.Property(t => t.Customer053ID).HasColumnName("Customer053ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
