using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer083Map : EntityTypeConfiguration<Customer083>
    {
        public Customer083Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer083ID);

            // Properties
            this.Property(t => t.Customer083ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer083");
            this.Property(t => t.Customer083ID).HasColumnName("Customer083ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
