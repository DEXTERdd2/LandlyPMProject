﻿// <auto-generated />
using System;
using Landly.LandlyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Landly.Migrations
{
    [DbContext(typeof(Landly_Db_Context))]
    [Migration("20241116232440_All_Tables")]
    partial class All_Tables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Landly.Models.Tb_BlackHat", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tb_BlackHat");
                });

            modelBuilder.Entity("Landly.Models.Tb_Domains", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("Id"));

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tb_Domains");
                });

            modelBuilder.Entity("Landly.Models.Tb_SubDomains", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("BlackHatId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DomainId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("datetime2");

                    b.Property<long?>("WhiteHatId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BlackHatId");

                    b.HasIndex("DomainId");

                    b.HasIndex("WhiteHatId");

                    b.ToTable("Tb_SubDomains");
                });

            modelBuilder.Entity("Landly.Models.Tb_Users", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tb_Users");
                });

            modelBuilder.Entity("Landly.Models.Tb_WhiteHat", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("Id"));

                    b.Property<DateTime?>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tb_WhiteHat");
                });

            modelBuilder.Entity("Landly.Models.Tb_SubDomains", b =>
                {
                    b.HasOne("Landly.Models.Tb_BlackHat", "BlackHat")
                        .WithMany()
                        .HasForeignKey("BlackHatId");

                    b.HasOne("Landly.Models.Tb_Domains", "DomainsId")
                        .WithMany()
                        .HasForeignKey("DomainId");

                    b.HasOne("Landly.Models.Tb_WhiteHat", "WhiteHat")
                        .WithMany()
                        .HasForeignKey("WhiteHatId");

                    b.Navigation("BlackHat");

                    b.Navigation("DomainsId");

                    b.Navigation("WhiteHat");
                });
#pragma warning restore 612, 618
        }
    }
}
