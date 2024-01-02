﻿// <auto-generated />
using System;
using AppBooking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppBooking.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231223192010_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppBooking.Model.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BaggageWeight")
                        .HasColumnType("int");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("FlightId");

                    b.HasIndex("SeatId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("AppBooking.Model.Distance", b =>
                {
                    b.Property<int>("DistanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DepartureCity")
                        .HasColumnType("longtext");

                    b.Property<string>("DestinationCity")
                        .HasColumnType("longtext");

                    b.Property<double>("Miles")
                        .HasColumnType("double");

                    b.HasKey("DistanceId");

                    b.ToTable("Distances");

                    b.HasData(
                        new
                        {
                            DistanceId = 1,
                            DepartureCity = "HaNoi",
                            DestinationCity = "HCM",
                            Miles = 500.0
                        },
                        new
                        {
                            DistanceId = 2,
                            DepartureCity = "HaNoi",
                            DestinationCity = "VINH",
                            Miles = 300.0
                        },
                        new
                        {
                            DistanceId = 3,
                            DepartureCity = "HaNoi",
                            DestinationCity = "CanTho",
                            Miles = 700.0
                        },
                        new
                        {
                            DistanceId = 4,
                            DepartureCity = "HaNoi",
                            DestinationCity = "DaNang",
                            Miles = 400.0
                        },
                        new
                        {
                            DistanceId = 5,
                            DepartureCity = "HaNoi",
                            DestinationCity = "PhuQuoc",
                            Miles = 1000.0
                        },
                        new
                        {
                            DistanceId = 6,
                            DepartureCity = "HCM",
                            DestinationCity = "HaNoi",
                            Miles = 500.0
                        },
                        new
                        {
                            DistanceId = 7,
                            DepartureCity = "HCM",
                            DestinationCity = "VINH",
                            Miles = 800.0
                        },
                        new
                        {
                            DistanceId = 8,
                            DepartureCity = "HCM",
                            DestinationCity = "CanTho",
                            Miles = 200.0
                        },
                        new
                        {
                            DistanceId = 9,
                            DepartureCity = "HCM",
                            DestinationCity = "DaNang",
                            Miles = 600.0
                        },
                        new
                        {
                            DistanceId = 10,
                            DepartureCity = "HCM",
                            DestinationCity = "PhuQuoc",
                            Miles = 900.0
                        },
                        new
                        {
                            DistanceId = 11,
                            DepartureCity = "VINH",
                            DestinationCity = "HaNoi",
                            Miles = 300.0
                        },
                        new
                        {
                            DistanceId = 12,
                            DepartureCity = "VINH",
                            DestinationCity = "HCM",
                            Miles = 800.0
                        },
                        new
                        {
                            DistanceId = 13,
                            DepartureCity = "VINH",
                            DestinationCity = "CanTho",
                            Miles = 900.0
                        },
                        new
                        {
                            DistanceId = 14,
                            DepartureCity = "VINH",
                            DestinationCity = "DaNang",
                            Miles = 300.0
                        },
                        new
                        {
                            DistanceId = 15,
                            DepartureCity = "VINH",
                            DestinationCity = "PhuQuoc",
                            Miles = 1100.0
                        },
                        new
                        {
                            DistanceId = 16,
                            DepartureCity = "CanTho",
                            DestinationCity = "HaNoi",
                            Miles = 700.0
                        },
                        new
                        {
                            DistanceId = 17,
                            DepartureCity = "CanTho",
                            DestinationCity = "HCM",
                            Miles = 200.0
                        },
                        new
                        {
                            DistanceId = 18,
                            DepartureCity = "CanTho",
                            DestinationCity = "VINH",
                            Miles = 900.0
                        },
                        new
                        {
                            DistanceId = 19,
                            DepartureCity = "CanTho",
                            DestinationCity = "DaNang",
                            Miles = 800.0
                        },
                        new
                        {
                            DistanceId = 20,
                            DepartureCity = "CanTho",
                            DestinationCity = "PhuQuoc",
                            Miles = 600.0
                        },
                        new
                        {
                            DistanceId = 21,
                            DepartureCity = "DaNang",
                            DestinationCity = "HaNoi",
                            Miles = 400.0
                        },
                        new
                        {
                            DistanceId = 22,
                            DepartureCity = "DaNang",
                            DestinationCity = "HCM",
                            Miles = 600.0
                        },
                        new
                        {
                            DistanceId = 23,
                            DepartureCity = "DaNang",
                            DestinationCity = "VINH",
                            Miles = 300.0
                        },
                        new
                        {
                            DistanceId = 24,
                            DepartureCity = "DaNang",
                            DestinationCity = "CanTho",
                            Miles = 800.0
                        },
                        new
                        {
                            DistanceId = 25,
                            DepartureCity = "DaNang",
                            DestinationCity = "PhuQuoc",
                            Miles = 1200.0
                        },
                        new
                        {
                            DistanceId = 26,
                            DepartureCity = "PhuQuoc",
                            DestinationCity = "HaNoi",
                            Miles = 1000.0
                        },
                        new
                        {
                            DistanceId = 27,
                            DepartureCity = "PhuQuoc",
                            DestinationCity = "HCM",
                            Miles = 900.0
                        },
                        new
                        {
                            DistanceId = 28,
                            DepartureCity = "PhuQuoc",
                            DestinationCity = "VINH",
                            Miles = 1100.0
                        },
                        new
                        {
                            DistanceId = 29,
                            DepartureCity = "PhuQuoc",
                            DestinationCity = "CanTho",
                            Miles = 600.0
                        },
                        new
                        {
                            DistanceId = 30,
                            DepartureCity = "PhuQuoc",
                            DestinationCity = "DaNang",
                            Miles = 1200.0
                        });
                });

            modelBuilder.Entity("AppBooking.Model.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Airplane")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("FlightDistanceId")
                        .HasColumnType("int");

                    b.Property<string>("FlightNumber")
                        .HasColumnType("longtext");

                    b.HasKey("FlightId");

                    b.HasIndex("FlightDistanceId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AppBooking.Model.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("SeatClass")
                        .HasColumnType("longtext");

                    b.Property<string>("SeatNumber")
                        .HasColumnType("longtext");

                    b.HasKey("SeatId");

                    b.HasIndex("FlightId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("AppBooking.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.Property<double>("SkyMiles")
                        .HasColumnType("double");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Address = "123 Main St",
                            Age = 30,
                            Credit = 1000,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "$2a$11$ogmqYpgEUtgSGWaY9y7lPec4R17BRaFOcmAMvjybEZok5mi6J06zy",
                            PhoneNumber = "123-456-7890",
                            Role = "User",
                            Sex = "Male",
                            SkyMiles = 500.5
                        },
                        new
                        {
                            UserId = 2,
                            Address = "123 Main St",
                            Age = 30,
                            Credit = 1000,
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            Password = "$2a$11$EWlDAS1grWjqZmvVDYnEcuaTxQ2QCWZsgckAs.3zg/pFLipwjcR7S",
                            PhoneNumber = "123-456-7890",
                            Role = "Admin",
                            Sex = "Male",
                            SkyMiles = 500.5
                        });
                });

            modelBuilder.Entity("AppBooking.Model.Booking", b =>
                {
                    b.HasOne("AppBooking.Model.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppBooking.Model.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppBooking.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Seat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AppBooking.Model.Flight", b =>
                {
                    b.HasOne("AppBooking.Model.Distance", "FlightDistance")
                        .WithMany()
                        .HasForeignKey("FlightDistanceId");

                    b.Navigation("FlightDistance");
                });

            modelBuilder.Entity("AppBooking.Model.Seat", b =>
                {
                    b.HasOne("AppBooking.Model.Flight", "Flight")
                        .WithMany("Seats")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("AppBooking.Model.Flight", b =>
                {
                    b.Navigation("Seats");
                });
#pragma warning restore 612, 618
        }
    }
}