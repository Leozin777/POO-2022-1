using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TdeCrudAvancado.Model.Domain;

namespace TdeCrudAvancado.Types
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("client");

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .HasColumnName("name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80)
                .IsRequired();
            
            builder.Property(i => i.BirthDay)
                .HasColumnName("birthDay")
                .IsRequired();

            builder.Property(i => i.PhoneNumber)
                .HasColumnName("phoneNumber")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}