using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer081Map : EntityTypeConfiguration<Customer081>
    {
        public Customer081Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer081ID);

            // Properties
            this.Property(t => t.Customer081ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer081");
            this.Property(t => t.Customer081ID).HasColumnName("Customer081ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
