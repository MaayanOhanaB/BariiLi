﻿// <auto-generated />
using System;
using BariiLi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BariiLi.Migrations
{
    [DbContext(typeof(BariiLiContext))]
    [Migration("20200907144402_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BariiLi.Models.AppointmentSystems", b =>
                {
                    b.Property<string>("typeOfPain")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MTId")
                        .HasColumnType("int");

                    b.Property<DateTime>("availabilityQueues")
                        .HasColumnType("datetime2");

                    b.Property<string>("medicalTeamMTId")
                        .HasColumnType("nvarchar(9)");

                    b.Property<int>("patientId")
                        .HasColumnType("int");

                    b.Property<string>("patientspatientId")
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("typeOfPain");

                    b.HasIndex("medicalTeamMTId");

                    b.HasIndex("patientspatientId");

                    b.ToTable("AppointmentSystems");
                });

            modelBuilder.Entity("BariiLi.Models.MedicalTeam", b =>
                {
                    b.Property<string>("MTId")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<DateTime>("availability")
                        .HasColumnType("datetime2");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("previousExprience")
                        .HasColumnType("int");

                    b.Property<string>("specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MTId");

                    b.ToTable("MedicalTeam");
                });

            modelBuilder.Entity("BariiLi.Models.Patients", b =>
                {
                    b.Property<string>("patientId")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typeOfPain")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("patientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("BariiLi.Models.AppointmentSystems", b =>
                {
                    b.HasOne("BariiLi.Models.MedicalTeam", "medicalTeam")
                        .WithMany("appointments")
                        .HasForeignKey("medicalTeamMTId");

                    b.HasOne("BariiLi.Models.Patients", "patients")
                        .WithMany("appointments")
                        .HasForeignKey("patientspatientId");
                });
#pragma warning restore 612, 618
        }
    }
}
