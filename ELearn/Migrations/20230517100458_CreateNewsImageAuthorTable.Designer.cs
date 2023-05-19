﻿// <auto-generated />
using System;
using ELearn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ELearn.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230517100458_CreateNewsImageAuthorTable")]
    partial class CreateNewsImageAuthorTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ELearn.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3089),
                            Name = "Mark Smith",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3104),
                            Name = "James S. Morrison",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3106),
                            Name = "Julia Williams",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("ELearn.Models.Choose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Choose");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3538),
                            Description = "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam.",
                            SoftDeleted = false,
                            Title = "Mauris vehicula nisi congue ?"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3540),
                            Description = "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam.",
                            SoftDeleted = false,
                            Title = "Mauris vehicula nisi congue ?"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3541),
                            Description = "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam.",
                            SoftDeleted = false,
                            Title = "Mauris vehicula nisi congue ?"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3542),
                            Description = "Suspendisse tincidunt magna eget massa hendrerit efficitur. Ut euismod pellentesque imperdiet. Cras laoreet gravida lectus, at viverra lorem venenatis in. Aenean id varius quam.",
                            SoftDeleted = false,
                            Title = "Mauris vehicula nisi congue ?"
                        });
                });

            modelBuilder.Entity("ELearn.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3333),
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Price = 35m,
                            SoftDeleted = false,
                            Title = "Online Literature Course"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 3,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3338),
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Price = 35m,
                            SoftDeleted = false,
                            Title = "Online Literature Course"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3340),
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Price = 35m,
                            SoftDeleted = false,
                            Title = "Online Literature Course"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 3,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3341),
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Price = 35m,
                            SoftDeleted = false,
                            Title = "Online Literature Course"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 2,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3342),
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Price = 35m,
                            SoftDeleted = false,
                            Title = "Online Literature Course"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3344),
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Price = 35m,
                            SoftDeleted = false,
                            Title = "Online Literature Course"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 3,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3345),
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Price = 35m,
                            SoftDeleted = false,
                            Title = "Online Literature Course"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 2,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3346),
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Price = 35m,
                            SoftDeleted = false,
                            Title = "Online Literature Course"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3348),
                            Description = "Maecenas rutrum viverra sapien sed ferm entum. Morbi tempor odio eget lacus tempus pulvinar.",
                            Price = 35m,
                            SoftDeleted = false,
                            Title = "Online Literature Course"
                        });
                });

            modelBuilder.Entity("ELearn.Models.CourseImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3452),
                            Image = "course_1.jpg",
                            IsMain = true,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3454),
                            Image = "course_2.jpg",
                            IsMain = true,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3456),
                            Image = "course_3.jpg",
                            IsMain = true,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 4,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3457),
                            Image = "course_4.jpg",
                            IsMain = true,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 5,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3459),
                            Image = "course_5.jpg",
                            IsMain = true,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 6,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3460),
                            Image = "course_6.jpg",
                            IsMain = true,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 7,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3461),
                            Image = "course_7.jpg",
                            IsMain = true,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 8,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3462),
                            Image = "course_8.jpg",
                            IsMain = true,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 9,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3463),
                            Image = "course_9.jpg",
                            IsMain = true,
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("ELearn.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3563),
                            Description = "Location: Online Platform",
                            SoftDeleted = false,
                            Title = "New Marketing Course Release"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3565),
                            Description = "Location: Online Platform",
                            SoftDeleted = false,
                            Title = "Students Art Workshop"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3566),
                            Description = "Location: Online Platform",
                            SoftDeleted = false,
                            Title = "Launch Party for a new Platform"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3568),
                            Description = "Location: Online Platform",
                            SoftDeleted = false,
                            Title = "New Marketing Course"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3569),
                            Description = "Location: Online Platform",
                            SoftDeleted = false,
                            Title = "New Marketing Course"
                        });
                });

            modelBuilder.Entity("ELearn.Models.Milestone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Milestone");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 1548,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3515),
                            Logo = "milestone_1.svg",
                            SoftDeleted = false,
                            Title = "online Course"
                        },
                        new
                        {
                            Id = 2,
                            Count = 7286,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3517),
                            Logo = "milestone_2.svg",
                            SoftDeleted = false,
                            Title = "Students"
                        },
                        new
                        {
                            Id = 3,
                            Count = 257,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3519),
                            Logo = "milestone_3.svg",
                            SoftDeleted = false,
                            Title = "Teachers"
                        },
                        new
                        {
                            Id = 4,
                            Count = 39,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3520),
                            Logo = "milestone_4.svg",
                            SoftDeleted = false,
                            Title = "Countries"
                        });
                });

            modelBuilder.Entity("ELearn.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NewsAuthorId")
                        .HasColumnType("int");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NewsAuthorId");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3601),
                            NewsAuthorId = 1,
                            SoftDeleted = false,
                            Title = "Why Choose online education?"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3603),
                            NewsAuthorId = 1,
                            SoftDeleted = false,
                            Title = "Books, Kindle or tablet?"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3605),
                            NewsAuthorId = 1,
                            SoftDeleted = false,
                            Title = "Why Choose online education?"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3606),
                            NewsAuthorId = 1,
                            SoftDeleted = false,
                            Title = "Books, Kindle or tablet?"
                        });
                });

            modelBuilder.Entity("ELearn.Models.NewsAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("NewsAuthors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3586),
                            FullName = "Willam Smith",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("ELearn.Models.NewsImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3623),
                            Image = "news_1.jpg",
                            NewsId = 1,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3625),
                            Image = "news_2.jpg",
                            NewsId = 2,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3626),
                            Image = "news_3.jpg",
                            NewsId = 3,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3627),
                            Image = "news_4.jpg",
                            NewsId = 4,
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("ELearn.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Slider");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 5, 17, 14, 4, 58, 111, DateTimeKind.Local).AddTicks(3488),
                            Description = "Maecenas rutrum viverra sapien sed fermentum. Morbi tempor odio eget lacus tempus pulvinar. Praesent vel nisl fermentum, gravida augue ut, fermentum ipsum.",
                            Image = "index.jpg",
                            Logo = "logo.png",
                            SoftDeleted = false,
                            Title = "Complete Online Courses"
                        });
                });

            modelBuilder.Entity("ELearn.Models.Course", b =>
                {
                    b.HasOne("ELearn.Models.Author", "Author")
                        .WithMany("Courses")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ELearn.Models.CourseImage", b =>
                {
                    b.HasOne("ELearn.Models.Course", "Course")
                        .WithMany("CourseImages")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ELearn.Models.News", b =>
                {
                    b.HasOne("ELearn.Models.NewsAuthor", "NewsAuthor")
                        .WithMany("News")
                        .HasForeignKey("NewsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NewsAuthor");
                });

            modelBuilder.Entity("ELearn.Models.NewsImage", b =>
                {
                    b.HasOne("ELearn.Models.News", "News")
                        .WithMany("NewsImages")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");
                });

            modelBuilder.Entity("ELearn.Models.Author", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ELearn.Models.Course", b =>
                {
                    b.Navigation("CourseImages");
                });

            modelBuilder.Entity("ELearn.Models.News", b =>
                {
                    b.Navigation("NewsImages");
                });

            modelBuilder.Entity("ELearn.Models.NewsAuthor", b =>
                {
                    b.Navigation("News");
                });
#pragma warning restore 612, 618
        }
    }
}