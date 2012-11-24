using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OrmBenchmark.EntityFramework.Models.Mapping
{
    public class Customer014Map : EntityTypeConfiguration<Customer014>
    {
        public Customer014Map()
        {
            // Primary Key
            this.HasKey(t => t.Customer014ID);

            // Properties
            this.Property(t => t.Customer014ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Customer014");
            this.Property(t => t.Customer014ID).HasColumnName("Customer014ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}
