﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TFG.HomeWorks.Infrastructure.Persistance;

#nullable disable

namespace TFG.HomeWorks.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.HouseAggregate.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Houses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Dirección de mi casa 1",
                            Description = "Descripción de mi casa 1",
                            IsAdmin = false,
                            Name = "Mi Casa 1",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Dirección de mi casa 2",
                            Description = "Descripción de mi casa 2",
                            IsAdmin = false,
                            Name = "Mi Casa 2",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Dirección de mi casa 3",
                            Description = "Descripción de mi casa 3",
                            IsAdmin = false,
                            Name = "Mi Casa 3",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Dirección de mi casa 4",
                            Description = "Descripción de mi casa 4",
                            IsAdmin = false,
                            Name = "Mi Casa 4",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Dirección de mi casa 5",
                            Description = "Descripción de mi casa 5",
                            IsAdmin = false,
                            Name = "Mi Casa 5",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Dirección de mi casa 6",
                            Description = "Descripción de mi casa 6",
                            IsAdmin = false,
                            Name = "Mi Casa 6",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Dirección de mi casa 7",
                            Description = "Descripción de mi casa 7",
                            IsAdmin = false,
                            Name = "Mi Casa 7",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Dirección de mi casa 8",
                            Description = "Descripción de mi casa 8",
                            IsAdmin = false,
                            Name = "Mi Casa 8",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Dirección de mi casa 9",
                            Description = "Descripción de mi casa 9",
                            IsAdmin = false,
                            Name = "Mi Casa 9",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 10,
                            Address = "Dirección de mi casa 10",
                            Description = "Descripción de mi casa 10",
                            IsAdmin = false,
                            Name = "Mi Casa 10",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 11,
                            Address = "Dirección de mi casa 11",
                            Description = "Descripción de mi casa 11",
                            IsAdmin = false,
                            Name = "Mi Casa 11",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 12,
                            Address = "Dirección de mi casa 12",
                            Description = "Descripción de mi casa 12",
                            IsAdmin = false,
                            Name = "Mi Casa 12",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 13,
                            Address = "Dirección de mi casa 13",
                            Description = "Descripción de mi casa 13",
                            IsAdmin = false,
                            Name = "Mi Casa 13",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 14,
                            Address = "Dirección de mi casa 14",
                            Description = "Descripción de mi casa 14",
                            IsAdmin = false,
                            Name = "Mi Casa 14",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 15,
                            Address = "Dirección de mi casa 15",
                            Description = "Descripción de mi casa 15",
                            IsAdmin = false,
                            Name = "Mi Casa 15",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 16,
                            Address = "Dirección de mi casa 16",
                            Description = "Descripción de mi casa 16",
                            IsAdmin = false,
                            Name = "Mi Casa 16",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 17,
                            Address = "Dirección de mi casa 17",
                            Description = "Descripción de mi casa 17",
                            IsAdmin = false,
                            Name = "Mi Casa 17",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 18,
                            Address = "Dirección de mi casa 18",
                            Description = "Descripción de mi casa 18",
                            IsAdmin = false,
                            Name = "Mi Casa 18",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 19,
                            Address = "Dirección de mi casa 19",
                            Description = "Descripción de mi casa 19",
                            IsAdmin = false,
                            Name = "Mi Casa 19",
                            ProfileImage = "uploads/default.jpg"
                        },
                        new
                        {
                            Id = 20,
                            Address = "Dirección de mi casa 20",
                            Description = "Descripción de mi casa 20",
                            IsAdmin = false,
                            Name = "Mi Casa 20",
                            ProfileImage = "uploads/default.jpg"
                        });
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.HouseAggregate.HouseMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HouseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("HouseId", "UserId")
                        .IsUnique();

                    b.ToTable("HouseMembers");
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.TaskAggregate.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Bathroom tasks description",
                            Icon = "http://localhost:5153/icons/categories/bathroom.svg",
                            Name = "Bathroom"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Bedroom tasks description",
                            Icon = "http://localhost:5153/icons/categories/bedroom.svg",
                            Name = "Bedroom"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dinning-room tasks description",
                            Icon = "http://localhost:5153/icons/categories/dinning-room.svg",
                            Name = "Dinning room"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Garage tasks description",
                            Icon = "http://localhost:5153/icons/categories/garage.svg",
                            Name = "Garage"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Garden tasks description",
                            Icon = "http://localhost:5153/icons/categories/garden.svg",
                            Name = "Garden"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Kitchen tasks description",
                            Icon = "http://localhost:5153/icons/categories/kitchen.svg",
                            Name = "Kitchen"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Living room tasks description",
                            Icon = "http://localhost:5153/icons/categories/living-room.svg",
                            Name = "Living room"
                        },
                        new
                        {
                            Id = 8,
                            Description = "office tasks description",
                            Icon = "http://localhost:5153/icons/categories/office-room.svg",
                            Name = "Office"
                        });
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.TaskAggregate.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AssignedBy")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("AssignedTo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DeadlineDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("HouseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("HouseId");

                    b.ToTable("Tasks", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario1",
                            CategoryId = 3,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2708),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2760),
                            Description = "Descripción de la Tarea 1",
                            HouseId = 1,
                            Name = "Tarea 1",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 2,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario2",
                            CategoryId = 2,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2774),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2776),
                            Description = "Descripción de la Tarea 2",
                            HouseId = 2,
                            Name = "Tarea 2",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 3,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario3",
                            CategoryId = 2,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2782),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2784),
                            Description = "Descripción de la Tarea 3",
                            HouseId = 3,
                            Name = "Tarea 3",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 4,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario4",
                            CategoryId = 2,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2790),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2792),
                            Description = "Descripción de la Tarea 4",
                            HouseId = 4,
                            Name = "Tarea 4",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 5,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario5",
                            CategoryId = 7,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2798),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2800),
                            Description = "Descripción de la Tarea 5",
                            HouseId = 5,
                            Name = "Tarea 5",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 6,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario6",
                            CategoryId = 5,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2807),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2809),
                            Description = "Descripción de la Tarea 6",
                            HouseId = 6,
                            Name = "Tarea 6",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 7,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario7",
                            CategoryId = 1,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2815),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2817),
                            Description = "Descripción de la Tarea 7",
                            HouseId = 7,
                            Name = "Tarea 7",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 8,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario8",
                            CategoryId = 3,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2822),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2824),
                            Description = "Descripción de la Tarea 8",
                            HouseId = 8,
                            Name = "Tarea 8",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 9,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario9",
                            CategoryId = 6,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2830),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2832),
                            Description = "Descripción de la Tarea 9",
                            HouseId = 9,
                            Name = "Tarea 9",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 10,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario10",
                            CategoryId = 4,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2840),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2843),
                            Description = "Descripción de la Tarea 10",
                            HouseId = 10,
                            Name = "Tarea 10",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 11,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario11",
                            CategoryId = 7,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2848),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2850),
                            Description = "Descripción de la Tarea 11",
                            HouseId = 11,
                            Name = "Tarea 11",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 12,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario12",
                            CategoryId = 1,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2856),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2858),
                            Description = "Descripción de la Tarea 12",
                            HouseId = 12,
                            Name = "Tarea 12",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 13,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario13",
                            CategoryId = 4,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2863),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2866),
                            Description = "Descripción de la Tarea 13",
                            HouseId = 13,
                            Name = "Tarea 13",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 14,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario14",
                            CategoryId = 3,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2871),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2873),
                            Description = "Descripción de la Tarea 14",
                            HouseId = 14,
                            Name = "Tarea 14",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 15,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario15",
                            CategoryId = 5,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2878),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2881),
                            Description = "Descripción de la Tarea 15",
                            HouseId = 15,
                            Name = "Tarea 15",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 16,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario16",
                            CategoryId = 4,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2886),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2888),
                            Description = "Descripción de la Tarea 16",
                            HouseId = 16,
                            Name = "Tarea 16",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 17,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario17",
                            CategoryId = 1,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2893),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2895),
                            Description = "Descripción de la Tarea 17",
                            HouseId = 17,
                            Name = "Tarea 17",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 18,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario18",
                            CategoryId = 3,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2902),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2904),
                            Description = "Descripción de la Tarea 18",
                            HouseId = 18,
                            Name = "Tarea 18",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 19,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario19",
                            CategoryId = 2,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2910),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2912),
                            Description = "Descripción de la Tarea 19",
                            HouseId = 19,
                            Name = "Tarea 19",
                            State = "NEW"
                        },
                        new
                        {
                            Id = 20,
                            AssignedBy = "Ángel",
                            AssignedTo = "Usuario20",
                            CategoryId = 4,
                            CreationDate = new DateTime(2024, 6, 15, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2917),
                            DeadlineDate = new DateTime(2024, 9, 13, 15, 3, 6, 661, DateTimeKind.Local).AddTicks(2919),
                            Description = "Descripción de la Tarea 20",
                            HouseId = 20,
                            Name = "Tarea 20",
                            State = "NEW"
                        });
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.UserAggregate.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.UserAggregate.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName1")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastName2")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.WeatherForecast", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreateDate");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Summary")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Summary");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int")
                        .HasColumnName("TemperatureC");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time(6)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecast", "dbo");
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.HouseAggregate.HouseMember", b =>
                {
                    b.HasOne("TFG.HomeWorks.Domain.Entities.HouseAggregate.House", "House")
                        .WithMany("Members")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFG.HomeWorks.Domain.Entities.UserAggregate.User", "User")
                        .WithMany("HouseMembers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.TaskAggregate.Task", b =>
                {
                    b.HasOne("TFG.HomeWorks.Domain.Entities.TaskAggregate.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TFG.HomeWorks.Domain.Entities.HouseAggregate.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("House");
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.UserAggregate.User", b =>
                {
                    b.HasOne("TFG.HomeWorks.Domain.Entities.UserAggregate.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.HouseAggregate.House", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.UserAggregate.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TFG.HomeWorks.Domain.Entities.UserAggregate.User", b =>
                {
                    b.Navigation("HouseMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
