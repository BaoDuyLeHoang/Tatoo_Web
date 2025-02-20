﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(TatooWebContext))]
    [Migration("20231019034454_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.DataAccess.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Role")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.ArtWork", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArtistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Size")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<TimeSpan?>("Time")
                        .HasColumnType("time");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("ArtWork", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("StudioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudioId");

                    b.ToTable("Artist", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArtWorkId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArtistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid?>("EquipmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("StudioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ArtWorkId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("StudioId");

                    b.ToTable("Booking", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.Discount", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("StudioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudioId");

                    b.ToTable("Discount", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.Equipment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Position")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("StudioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudioId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntityId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Source")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Image", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.Scheduling", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("StartTime")
                        .HasColumnType("time");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.ToTable("Scheduling", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.Studio", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("StudioEmail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("StudioPhone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Studio", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.VipMember", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StudioId");

                    b.ToTable("VipMember", (string)null);
                });

            modelBuilder.Entity("DataAccess.DataAccess.ArtWork", b =>
                {
                    b.HasOne("DataAccess.DataAccess.Artist", "Artist")
                        .WithMany("ArtWorks")
                        .HasForeignKey("ArtistId")
                        .HasConstraintName("FK_ArtWork_Artist");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Artist", b =>
                {
                    b.HasOne("DataAccess.DataAccess.Studio", "Studio")
                        .WithMany("Artists")
                        .HasForeignKey("StudioId")
                        .HasConstraintName("FK_Artist_Studio");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Booking", b =>
                {
                    b.HasOne("DataAccess.DataAccess.ArtWork", "ArtWork")
                        .WithMany("Bookings")
                        .HasForeignKey("ArtWorkId")
                        .HasConstraintName("FK_Booking_ArtWork");

                    b.HasOne("DataAccess.DataAccess.Artist", "Artist")
                        .WithMany("Bookings")
                        .HasForeignKey("ArtistId")
                        .HasConstraintName("FK_Booking_Artist");

                    b.HasOne("DataAccess.DataAccess.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Booking_Customer");

                    b.HasOne("DataAccess.DataAccess.Equipment", "Equipment")
                        .WithMany("Bookings")
                        .HasForeignKey("EquipmentId")
                        .HasConstraintName("FK_Booking_Equipment");

                    b.HasOne("DataAccess.DataAccess.Studio", "Studio")
                        .WithMany("Bookings")
                        .HasForeignKey("StudioId")
                        .HasConstraintName("FK_Booking_Studio");

                    b.Navigation("ArtWork");

                    b.Navigation("Artist");

                    b.Navigation("Customer");

                    b.Navigation("Equipment");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Customer", b =>
                {
                    b.HasOne("DataAccess.DataAccess.Account", "Account")
                        .WithMany("Customers")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_Customer_Account");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Discount", b =>
                {
                    b.HasOne("DataAccess.DataAccess.Studio", "Studio")
                        .WithMany("Discounts")
                        .HasForeignKey("StudioId")
                        .HasConstraintName("FK_Discount_Studio");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Equipment", b =>
                {
                    b.HasOne("DataAccess.DataAccess.Studio", "Studio")
                        .WithMany("Equipment")
                        .HasForeignKey("StudioId")
                        .HasConstraintName("FK_Equipment_Studio");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Scheduling", b =>
                {
                    b.HasOne("DataAccess.DataAccess.Booking", "Booking")
                        .WithMany("Schedulings")
                        .HasForeignKey("BookingId")
                        .HasConstraintName("FK_Scheduling_Booking");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Studio", b =>
                {
                    b.HasOne("DataAccess.DataAccess.Account", "Account")
                        .WithMany("Studios")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_Studio_Account");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("DataAccess.DataAccess.VipMember", b =>
                {
                    b.HasOne("DataAccess.DataAccess.Customer", "Customer")
                        .WithMany("VipMembers")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_VipMember_Customer");

                    b.HasOne("DataAccess.DataAccess.Studio", "Studio")
                        .WithMany("VipMembers")
                        .HasForeignKey("StudioId")
                        .HasConstraintName("FK_VipMember_Studio");

                    b.Navigation("Customer");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Account", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Studios");
                });

            modelBuilder.Entity("DataAccess.DataAccess.ArtWork", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Artist", b =>
                {
                    b.Navigation("ArtWorks");

                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Booking", b =>
                {
                    b.Navigation("Schedulings");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Customer", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("VipMembers");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Equipment", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DataAccess.DataAccess.Studio", b =>
                {
                    b.Navigation("Artists");

                    b.Navigation("Bookings");

                    b.Navigation("Discounts");

                    b.Navigation("Equipment");

                    b.Navigation("VipMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
