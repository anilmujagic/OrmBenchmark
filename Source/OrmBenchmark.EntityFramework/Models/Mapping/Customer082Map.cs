using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer082Map : EntityTypeConfiguration<Customer082>
    {
        public Customer082Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer082ID);

            // Properties
            this.Property(t => t.Customer082ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer082");
            this.Property(t => t.Customer082ID).HasColumnName("Customer082ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
