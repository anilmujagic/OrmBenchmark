using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer001Map : EntityTypeConfiguration<Customer001>
    {
        public Customer001Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer001ID);

            // Properties
            this.Property(t => t.Customer001ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer001");
            this.Property(t => t.Customer001ID).HasColumnName("Customer001ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
