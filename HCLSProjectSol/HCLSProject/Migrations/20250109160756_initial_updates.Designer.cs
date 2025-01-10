﻿// <auto-generated />
using System;
using HCLSProject.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HCLSProject.Migrations
{
    [DbContext(typeof(HCLSDBContext))]
    [Migration("20250109160756_initial_updates")]
    partial class initial_updates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HCLSProject.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdminTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Proof")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.HasKey("AdminId");

                    b.HasIndex("AdminTypeId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("HCLSProject.Models.AdminTypes", b =>
                {
                    b.Property<int>("AdminTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminTypeId"));

                    b.Property<string>("AdminTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminTypeId");

                    b.ToTable("AdminTypes");
                });

            modelBuilder.Entity("HCLSProject.Models.Department", b =>
                {
                    b.Property<int>("DeptNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptNo"));

                    b.Property<string>("DName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptNo");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("HCLSProject.Models.DoctorDetails", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"));

                    b.Property<bool>("Assigned")
                        .HasColumnType("bit");

                    b.Property<int>("DocSpecId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Logged")
                        .HasColumnType("bit");

                    b.HasKey("EmpId");

                    b.HasIndex("DocSpecId");

                    b.ToTable("DoctorDetails");
                });

            modelBuilder.Entity("HCLSProject.Models.DoctorSpecialization", b =>
                {
                    b.Property<int>("DocSpecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocSpecId"));

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocSpecId");

                    b.ToTable("DoctorSpecialization");
                });

            modelBuilder.Entity("HCLSProject.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOJ")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptNo")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmpId");

                    b.HasIndex("DeptNo");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("HCLSProject.Models.HelperDetails", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"));

                    b.Property<bool>("Assigned")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Logged")
                        .HasColumnType("bit");

                    b.HasKey("EmpId");

                    b.ToTable("HelperDetails");
                });

            modelBuilder.Entity("HCLSProject.Models.LabDetails", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Logged")
                        .HasColumnType("bit");

                    b.HasKey("EmpId");

                    b.ToTable("LabDetails");
                });

            modelBuilder.Entity("HCLSProject.Models.ReceptionistDetails", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Logged")
                        .HasColumnType("bit");

                    b.HasKey("EmpId");

                    b.ToTable("ReceptionistDetails");
                });

            modelBuilder.Entity("HCLSProject.Models.Admin", b =>
                {
                    b.HasOne("HCLSProject.Models.AdminTypes", "AdminType")
                        .WithMany()
                        .HasForeignKey("AdminTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdminType");
                });

            modelBuilder.Entity("HCLSProject.Models.DoctorDetails", b =>
                {
                    b.HasOne("HCLSProject.Models.DoctorSpecialization", "DoctorSpecialization")
                        .WithMany()
                        .HasForeignKey("DocSpecId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoctorSpecialization");
                });

            modelBuilder.Entity("HCLSProject.Models.Employee", b =>
                {
                    b.HasOne("HCLSProject.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DeptNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
