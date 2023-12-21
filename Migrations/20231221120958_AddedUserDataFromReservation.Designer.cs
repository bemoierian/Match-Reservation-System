﻿// <auto-generated />
using System;
using MatchReservationSystem.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MatchReservationSystem.Migrations
{
    [DbContext(typeof(GlobalDbContext))]
    [Migration("20231221120958_AddedUserDataFromReservation")]
    partial class AddedUserDataFromReservation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MatchReservationSystem.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int?>("LineManOneId")
                        .HasColumnType("int");

                    b.Property<int?>("LineManTwoId")
                        .HasColumnType("int");

                    b.Property<int?>("MainRefereeId")
                        .HasColumnType("int");

                    b.Property<int?>("MatchVenueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("LineManOneId");

                    b.HasIndex("LineManTwoId");

                    b.HasIndex("MainRefereeId");

                    b.HasIndex("MatchVenueId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("MatchReservationSystem.Models.MatchVenue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MatchVenues");
                });

            modelBuilder.Entity("MatchReservationSystem.Models.Referee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RefereeType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Referees");
                });

            modelBuilder.Entity("MatchReservationSystem.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MatchId")
                        .HasColumnType("int");

                    b.Property<int?>("MatchVenueId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeatPosition")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("MatchVenueId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("MatchReservationSystem.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("MatchReservationSystem.Models.Match", b =>
                {
                    b.HasOne("MatchReservationSystem.Models.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId");

                    b.HasOne("MatchReservationSystem.Models.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId");

                    b.HasOne("MatchReservationSystem.Models.Referee", "LineManOne")
                        .WithMany()
                        .HasForeignKey("LineManOneId");

                    b.HasOne("MatchReservationSystem.Models.Referee", "LineManTwo")
                        .WithMany()
                        .HasForeignKey("LineManTwoId");

                    b.HasOne("MatchReservationSystem.Models.Referee", "MainReferee")
                        .WithMany()
                        .HasForeignKey("MainRefereeId");

                    b.HasOne("MatchReservationSystem.Models.MatchVenue", "MatchVenue")
                        .WithMany()
                        .HasForeignKey("MatchVenueId");

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");

                    b.Navigation("LineManOne");

                    b.Navigation("LineManTwo");

                    b.Navigation("MainReferee");

                    b.Navigation("MatchVenue");
                });

            modelBuilder.Entity("MatchReservationSystem.Models.Reservation", b =>
                {
                    b.HasOne("MatchReservationSystem.Models.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId");

                    b.HasOne("MatchReservationSystem.Models.MatchVenue", "MatchVenue")
                        .WithMany()
                        .HasForeignKey("MatchVenueId");

                    b.Navigation("Match");

                    b.Navigation("MatchVenue");
                });
#pragma warning restore 612, 618
        }
    }
}
