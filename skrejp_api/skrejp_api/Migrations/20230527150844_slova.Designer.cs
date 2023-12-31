﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using skrejp_api.Data;

#nullable disable

namespace skrejp_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230527150844_slova")]
    partial class slova
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("skrejp_api.Model.Nekretnina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("cijena")
                        .HasColumnType("REAL");

                    b.Property<string>("naziv")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Nekretnina");
                });

            modelBuilder.Entity("skrejp_api.Model.Slike", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NekretninaID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("NekretninaID");

                    b.ToTable("Slike");
                });

            modelBuilder.Entity("skrejp_api.Model.Slike", b =>
                {
                    b.HasOne("skrejp_api.Model.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nekretnina");
                });
#pragma warning restore 612, 618
        }
    }
}
