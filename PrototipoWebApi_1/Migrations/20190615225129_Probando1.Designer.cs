﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrototipoWebApi_1.Repositorios;

namespace PrototipoWebApi_1.Migrations
{
    [DbContext(typeof(RepositoryBase))]
    [Migration("20190615225129_Probando1")]
    partial class Probando1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrototipoWebApi_1.Modelos.Colaborador", b =>
                {
                    b.Property<int>("Col_I_Codigo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Col_B_Estado");

                    b.Property<string>("Col_C_Sexo")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasColumnType("char(1)");

                    b.Property<DateTime>("Col_D_Fecha_Nacimiento");

                    b.Property<string>("Col_V_Apellido_1")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Col_V_Apellido_2")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Col_V_Cedula")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Col_V_Nombre_1")
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Col_V_Nombre_2")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Dep_I_Codigo");

                    b.Property<int>("Pos_I_Codigo");

                    b.HasKey("Col_I_Codigo");

                    b.ToTable("Colaboradors");
                });

            modelBuilder.Entity("PrototipoWebApi_1.Modelos.Departamento", b =>
                {
                    b.Property<int>("Dep_I_Codigo");

                    b.Property<string>("Dep_V_Descripcion")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Dep_I_Codigo");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("PrototipoWebApi_1.Modelos.Posicion", b =>
                {
                    b.Property<int>("Pos_I_Codigo");

                    b.Property<string>("Pos_V_Descripcion");

                    b.HasKey("Pos_I_Codigo");

                    b.ToTable("Posicion");
                });

            modelBuilder.Entity("PrototipoWebApi_1.Repositorios.Cliente", b =>
                {
                    b.Property<int>("Cli_I_Codigo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cli_V_Apellido_1")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Cli_V_Apellido_2")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Cli_V_CedulaRnc")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Cli_V_Nombre_1")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Cli_V_Nombre_2")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Cli_V_Telefono")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Cli_V_email")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Pro_I_Codigo")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar(30)");

                    b.HasKey("Cli_I_Codigo");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PrototipoWebApi_1.Repositorios.Proyecto", b =>
                {
                    b.Property<int>("Pro_I_Codigo");

                    b.Property<string>("Pro_V_Descripcion")
                        .HasColumnType("varchar(60)");

                    b.HasKey("Pro_I_Codigo");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("PrototipoWebApi_1.Modelos.Departamento", b =>
                {
                    b.HasOne("PrototipoWebApi_1.Modelos.Colaborador")
                        .WithMany("Departamento")
                        .HasForeignKey("Dep_I_Codigo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrototipoWebApi_1.Modelos.Posicion", b =>
                {
                    b.HasOne("PrototipoWebApi_1.Modelos.Colaborador")
                        .WithMany("Pocisiones")
                        .HasForeignKey("Pos_I_Codigo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrototipoWebApi_1.Repositorios.Proyecto", b =>
                {
                    b.HasOne("PrototipoWebApi_1.Repositorios.Cliente")
                        .WithMany("Proyectos")
                        .HasForeignKey("Pro_I_Codigo")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
