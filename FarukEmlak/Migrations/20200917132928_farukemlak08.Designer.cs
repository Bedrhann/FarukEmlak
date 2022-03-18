﻿// <auto-generated />
using System;
using FarukEmlak.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FarukEmlak.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200917132928_farukemlak08")]
    partial class farukemlak08
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FarukEmlak.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("FarukEmlak.Models.Kiralik", b =>
                {
                    b.Property<int>("KiralikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Binakat")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Binayas")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Bulunkat")
                        .HasColumnType("tinyint");

                    b.Property<string>("Cephe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Kira")
                        .HasColumnType("smallint");

                    b.Property<string>("Mahalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("MetreKare")
                        .HasColumnType("tinyint");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<string>("Odasay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("İlanTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("KiralikID");

                    b.HasIndex("MusteriID");

                    b.ToTable("Kiraliks");
                });

            modelBuilder.Entity("FarukEmlak.Models.Musteri", b =>
                {
                    b.Property<int>("MusteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusteriID");

                    b.ToTable("Musteris");
                });

            modelBuilder.Entity("FarukEmlak.Models.Satilik", b =>
                {
                    b.Property<int>("SatilikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Binakat")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Binayas")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Bulunkat")
                        .HasColumnType("tinyint");

                    b.Property<string>("Cephe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mahalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("MetreKare")
                        .HasColumnType("tinyint");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<string>("Odasay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("İlanTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("SatilikID");

                    b.HasIndex("MusteriID");

                    b.ToTable("Satiliks");
                });

            modelBuilder.Entity("FarukEmlak.Models.Kiralik", b =>
                {
                    b.HasOne("FarukEmlak.Models.Musteri", "Musteri")
                        .WithMany("Kiraliks")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarukEmlak.Models.Satilik", b =>
                {
                    b.HasOne("FarukEmlak.Models.Musteri", "Musteri")
                        .WithMany("Satiliks")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
