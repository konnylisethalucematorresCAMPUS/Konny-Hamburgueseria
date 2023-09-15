using System.Security.Cryptography.X509Certificates;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class HamburguesaConfiguration : IEntityTypeConfiguration<Hamburguesa>
{
    public void Configure(EntityTypeBuilder<Hamburguesa> builder)
    {
        builder.ToTable ("Hamburguesa");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdHambuerguesa")
        .HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.Nombre)
        .HasColumnName("Nombre")
        .HasColumnType("varchar")
        .HasMaxLength(30)
        .IsRequired();


            builder.Property(p => p.IdCategoria)
            .HasColumnName("IdCategoria")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p => p.Categorias ) //Nombre de la tabla que esta mandando en plural
                .WithMany(p => p.Hamburguesas) //Nombre de la tabla que esta recibiendo pero en plural
                .HasForeignKey(p => p.IdCategoria); //Nombre de Id de la tabla


        builder.Property(p => p.Precio)
       .HasColumnName("Precio")
       .HasColumnType("varchar")
       .HasMaxLength(20)
       .IsRequired();


            builder.Property(p => p.IdChef)
            .HasColumnName("IdChef")
            .HasColumnType("int")
            .IsRequired();

            builder.HasOne(p =>p.Chefs)
                .WithMany(p => p.Hamburguesas)
                .HasForeignKey(p => p.IdChef);

       

       
    }
}
