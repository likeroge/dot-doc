﻿// <auto-generated />
using System;
using AtcAntarctic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AtcAntarctic.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250111114009_UpdateTransportNote1")]
    partial class UpdateTransportNote1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.21");

            modelBuilder.Entity("AtcAntarctic.Models.Place", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("AtcAntarctic.Models.TransportNote", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Ata")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Atd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("FromId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("FromId1")
                        .HasColumnType("INTEGER");

                    b.Property<short>("Pob")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rmk")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("ToId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ToId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehicleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FromId1");

                    b.HasIndex("ToId1");

                    b.ToTable("TransportNotes");
                });

            modelBuilder.Entity("AtcAntarctic.Models.Vehicle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("AtcAntarctic.Models.TransportNote", b =>
                {
                    b.HasOne("AtcAntarctic.Models.Place", "From")
                        .WithMany()
                        .HasForeignKey("FromId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AtcAntarctic.Models.Place", "To")
                        .WithMany()
                        .HasForeignKey("ToId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("From");

                    b.Navigation("To");
                });
#pragma warning restore 612, 618
        }
    }
}
