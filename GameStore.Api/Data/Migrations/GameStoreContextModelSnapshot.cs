﻿// <auto-generated />
using System;
using GameStore.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameStore.Api.Data.Migrations
{
    [DbContext(typeof(GameStoreContext))]
    partial class GameStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("GameStore.Api.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameStore.Api.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6920),
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6939),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6942),
                            Name = "RPG"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6943),
                            Name = "Simulation"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 3, 12, 10, 17, 17, 905, DateTimeKind.Local).AddTicks(6944),
                            Name = "Strategy"
                        });
                });

            modelBuilder.Entity("GameStore.Api.Entities.Game", b =>
                {
                    b.HasOne("GameStore.Api.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
