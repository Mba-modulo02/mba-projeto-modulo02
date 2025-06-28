using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration() { 
            
        }

        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(c => c.Endereco)
                .IsRequired()
                .HasMaxLength(200);


        }
    }
}
