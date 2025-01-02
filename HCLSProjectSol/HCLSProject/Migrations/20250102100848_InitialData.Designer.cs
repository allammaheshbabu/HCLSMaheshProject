﻿// <auto-generated />
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
    [Migration("20250102100848_InitialData")]
    partial class InitialData
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

            modelBuilder.Entity("HCLSProject.Models.Admin", b =>
                {
                    b.HasOne("HCLSProject.Models.AdminTypes", "AdminType")
                        .WithMany()
                        .HasForeignKey("AdminTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdminType");
                });
#pragma warning restore 612, 618
        }
    }
}