﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using skrejp_api.Data;

#nullable disable

namespace skrejp_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("skrejp_api.Model.Nekretnina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("alarm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("balkon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blindirana_vrata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("broj_soba")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cijena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("datum_objave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detaljan_opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("garaza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("godina_izgradnje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("internet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isKoristeno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isNovogradnja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kablovska_tv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kanalizacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("klima")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("kvadratura")
                        .HasColumnType("int");

                    b.Property<string>("kvadratura_balkona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lokacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nedavno_adaptiran")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opremljenost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ostava_spajz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primarna_orjentacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sprat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("struja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefonski_prikljucak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tip_akcije")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tip_nekretnine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uknjizeno_zk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("video_nadzor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("voda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrsta_grijanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrsta_poda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Nekretnina");
                });

            modelBuilder.Entity("skrejp_api.Model.Slike", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("nekretninaID")
                        .HasColumnType("int");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("nekretninaID");

                    b.ToTable("Slike");
                });

            modelBuilder.Entity("skrejp_api.Model.Slike", b =>
                {
                    b.HasOne("skrejp_api.Model.Nekretnina", "nekretnina")
                        .WithMany()
                        .HasForeignKey("nekretninaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("nekretnina");
                });
#pragma warning restore 612, 618
        }
    }
}