﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RickAndMortyAPIApp.Infrastructure;

#nullable disable

namespace RickAndMortyAPIApp.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240318204704_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RickAndMortyAPIApp.Domain.Entities.CharacterEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Created")
                        .HasColumnType("text");

                    b.Property<string>("Episode")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Species")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<long>("SystemId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Characters", "public");
                });

            modelBuilder.Entity("RickAndMortyAPIApp.Domain.Entities.EpisodeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AirDate")
                        .HasColumnType("text");

                    b.Property<string>("Characters")
                        .HasColumnType("text");

                    b.Property<string>("Created")
                        .HasColumnType("text");

                    b.Property<string>("Episode")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("SystemId")
                        .HasColumnType("bigint");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Episodes", "public");
                });

            modelBuilder.Entity("RickAndMortyAPIApp.Domain.Entities.LocationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Created")
                        .HasColumnType("text");

                    b.Property<string>("Dimension")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Residents")
                        .HasColumnType("text");

                    b.Property<long>("SystemId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations", "public");
                });

            modelBuilder.Entity("RickAndMortyAPIApp.Domain.Entities.CharacterEntity", b =>
                {
                    b.OwnsOne("RickAndMortyAPIApp.Domain.SeedWork.NamedAPIResource", "Location", b1 =>
                        {
                            b1.Property<Guid>("CharacterEntityId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Name")
                                .HasColumnType("text");

                            b1.Property<string>("Url")
                                .HasColumnType("text");

                            b1.HasKey("CharacterEntityId");

                            b1.ToTable("Characters", "public");

                            b1.WithOwner()
                                .HasForeignKey("CharacterEntityId");
                        });

                    b.OwnsOne("RickAndMortyAPIApp.Domain.SeedWork.NamedAPIResource", "Origin", b1 =>
                        {
                            b1.Property<Guid>("CharacterEntityId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Name")
                                .HasColumnType("text");

                            b1.Property<string>("Url")
                                .HasColumnType("text");

                            b1.HasKey("CharacterEntityId");

                            b1.ToTable("Characters", "public");

                            b1.WithOwner()
                                .HasForeignKey("CharacterEntityId");
                        });

                    b.Navigation("Location");

                    b.Navigation("Origin");
                });
#pragma warning restore 612, 618
        }
    }
}
