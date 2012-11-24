using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer073Map : EntityTypeConfiguration<Customer073>
    {
        public Customer073Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer073ID);

            // Properties
            this.Property(t => t.Customer073ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer073");
            this.Property(t => t.Customer073ID).HasColumnName("Customer073ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
