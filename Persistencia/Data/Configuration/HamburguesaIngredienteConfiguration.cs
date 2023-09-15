using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class HamburguesaIngredienteConfiguration : IEntityTypeConfiguration<HamburguesaIngrediente>
{
    public void Configure(EntityTypeBuilder<HamburguesaIngrediente> builder)
    {
        builder.ToTable("HamburguesaIngrediente");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("HamburguesaIngrediente")
        .HasColumnType("int")
        .IsRequired();

            builder.Property(p => p.IdHamburguesa)
            .HasColumnName("IdHamburguesa")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p =>p.Hamburguesas)
                .WithMany(p => p.HamburguesasIngredientes)
                .HasForeignKey(p => p.IdHamburguesa);
                    
          builder.Property(p => p.IdIngrediente)
            .HasColumnName("IdIngrediente")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p =>p.Ingredientes)
                .WithMany(p => p.HamburguesasIngredientes)
                .HasForeignKey(p => p.IdIngrediente);
    }
}
