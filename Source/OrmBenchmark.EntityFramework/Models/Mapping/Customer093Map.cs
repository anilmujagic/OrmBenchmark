using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer093Map : EntityTypeConfiguration<Customer093>
    {
        public Customer093Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer093ID);

            // Properties
            this.Property(t => t.Customer093ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer093");
            this.Property(t => t.Customer093ID).HasColumnName("Customer093ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
