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
                            Icon = "https://localhost:7126/icons/categories/bathroom.svg",
                            Name = "Bathroom"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Bedroom tasks description",
                            Icon = "https://localhost:7126/icons/categories/bedroom.svg",
                            Name = "Bedroom"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dinning-room tasks description",
                            Icon = "https://localhost:7126/icons/categories/dinning-room.svg",
                            Name = "Dinning room"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Garage tasks description",
                            Icon = "https://localhost:7126/icons/categories/garage.svg",
                            Name = "Garage"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Garden tasks description",
                            Icon = "https://localhost:7126/icons/categories/garden.svg",
                            Name = "Garden"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Kitchen tasks description",
                            Icon = "https://localhost:7126/icons/categories/kitchen.svg",
                            Name = "Kitchen"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Living room tasks description",
                            Icon = "https://localhost:7126/icons/categories/living-room.svg",
                            Name = "Living room"
                        },
                        new
                        {
                            Id = 8,
                            Description = "office tasks description",
                            Icon = "https://localhost:7126/icons/categories/office-room.svg",
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
