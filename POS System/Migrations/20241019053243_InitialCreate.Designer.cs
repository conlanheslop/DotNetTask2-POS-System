﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POS_System;

#nullable disable

namespace POS_System.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241019053243_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("POS_System.POSUser", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserType")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Name = "Jane Doe",
                            Password = "password",
                            UserType = 0
                        },
                        new
                        {
                            UserID = 2,
                            Name = "John Doe",
                            Password = "password",
                            UserType = 1
                        },
                        new
                        {
                            UserID = 3,
                            Name = "Ronald McDonald",
                            Password = "password",
                            UserType = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}