﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeguiAcademico.App.Persistencia;

namespace SeguiAcademico.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210917233051_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Historial", b =>
                {
                    b.Property<int>("HistorialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("InformeSeguimientoInformeId")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecomendacionAcademicaRecomendacionId")
                        .HasColumnType("int");

                    b.HasKey("HistorialId");

                    b.HasIndex("InformeSeguimientoInformeId");

                    b.HasIndex("RecomendacionAcademicaRecomendacionId");

                    b.ToTable("Historial");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Informe", b =>
                {
                    b.Property<int>("InformeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Asunto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Materia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InformeId");

                    b.ToTable("Informe");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Recomendacion", b =>
                {
                    b.Property<int>("RecomendacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EstadoAvance")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaestroEncargadoId")
                        .HasColumnType("int");

                    b.Property<string>("Materia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tematica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoActividad")
                        .HasColumnType("int");

                    b.HasKey("RecomendacionId");

                    b.HasIndex("MaestroEncargadoId");

                    b.ToTable("RecomendacionAcademica");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.AcudienteDesignado", b =>
                {
                    b.HasBaseType("SeguiAcademico.App.Dominio.Persona");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AcudienteDesignado");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("SeguiAcademico.App.Dominio.Persona");

                    b.Property<int?>("AcudienteDesignadoId")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Curso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistorialId")
                        .HasColumnType("int");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.Property<int?>("MaestroId")
                        .HasColumnType("int");

                    b.Property<string>("MateriasInscritas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TutorId")
                        .HasColumnType("int");

                    b.HasIndex("AcudienteDesignadoId");

                    b.HasIndex("HistorialId");

                    b.HasIndex("MaestroId");

                    b.HasIndex("TutorId");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Maestro", b =>
                {
                    b.HasBaseType("SeguiAcademico.App.Dominio.Persona");

                    b.Property<string>("CorreoInstitucional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CursoACargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Materia")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Maestro");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Tutor", b =>
                {
                    b.HasBaseType("SeguiAcademico.App.Dominio.Persona");

                    b.Property<string>("CorreoInstitucional")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tutor_CorreoInstitucional");

                    b.Property<int>("HorasLaborales")
                        .HasColumnType("int");

                    b.Property<string>("MateriaTutoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Tutor");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Historial", b =>
                {
                    b.HasOne("SeguiAcademico.App.Dominio.Informe", "InformeSeguimiento")
                        .WithMany()
                        .HasForeignKey("InformeSeguimientoInformeId");

                    b.HasOne("SeguiAcademico.App.Dominio.Recomendacion", "RecomendacionAcademica")
                        .WithMany()
                        .HasForeignKey("RecomendacionAcademicaRecomendacionId");

                    b.Navigation("InformeSeguimiento");

                    b.Navigation("RecomendacionAcademica");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Recomendacion", b =>
                {
                    b.HasOne("SeguiAcademico.App.Dominio.Maestro", "MaestroEncargado")
                        .WithMany()
                        .HasForeignKey("MaestroEncargadoId");

                    b.Navigation("MaestroEncargado");
                });

            modelBuilder.Entity("SeguiAcademico.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("SeguiAcademico.App.Dominio.AcudienteDesignado", "AcudienteDesignado")
                        .WithMany()
                        .HasForeignKey("AcudienteDesignadoId");

                    b.HasOne("SeguiAcademico.App.Dominio.Historial", "Historial")
                        .WithMany()
                        .HasForeignKey("HistorialId");

                    b.HasOne("SeguiAcademico.App.Dominio.Maestro", "Maestro")
                        .WithMany()
                        .HasForeignKey("MaestroId");

                    b.HasOne("SeguiAcademico.App.Dominio.Tutor", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId");

                    b.Navigation("AcudienteDesignado");

                    b.Navigation("Historial");

                    b.Navigation("Maestro");

                    b.Navigation("Tutor");
                });
#pragma warning restore 612, 618
        }
    }
}
