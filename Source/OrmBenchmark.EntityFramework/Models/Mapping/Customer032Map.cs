using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer032Map : EntityTypeConfiguration<Customer032>
    {
        public Customer032Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer032ID);

            // Properties
            this.Property(t => t.Customer032ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer032");
            this.Property(t => t.Customer032ID).HasColumnName("Customer032ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
