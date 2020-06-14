﻿// <auto-generated />
using System;
using Control.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Control.Migrations
{
    [DbContext(typeof(ControlContext))]
    partial class ControlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Control.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Control.Models.ApiKey", b =>
                {
                    b.Property<short>("ApiKeyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key");

                    b.HasKey("ApiKeyId");

                    b.ToTable("ApiKeys");
                });

            modelBuilder.Entity("Control.Models.Attendance", b =>
                {
                    b.Property<short>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<short>("StudentId");

                    b.HasKey("AttendanceId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("Control.Models.Course", b =>
                {
                    b.Property<short>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Control.Models.Event", b =>
                {
                    b.Property<short>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<DateTime>("EventDate");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(550);

                    b.Property<string>("Url");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Control.Models.Student", b =>
                {
                    b.Property<short>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Age");

                    b.Property<string>("FutureCareerChoice")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<byte>("GceALevels");

                    b.Property<byte>("GceOLevels");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("School")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasMaxLength(17);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("YearOfAttendance");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Control.Models.Teach", b =>
                {
                    b.Property<short>("TeachId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("CourseId");

                    b.Property<DateTime>("year");

                    b.HasKey("TeachId");

                    b.ToTable("Teaches");
                });

            modelBuilder.Entity("Control.Models.TestScore", b =>
                {
                    b.Property<int>("TestScoreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasMaxLength(1000);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("StudentId");

                    b.Property<float>("StudentScore");

                    b.HasKey("TestScoreId");

                    b.ToTable("TestScores");
                });

            modelBuilder.Entity("Control.Models.Tutor", b =>
                {
                    b.Property<short>("TutorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasMaxLength(7);

                    b.Property<short?>("TeachId");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.Property<string>("TutorName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("TutorId");

                    b.HasIndex("TeachId");

                    b.ToTable("Tutors");
                });

            modelBuilder.Entity("Control.Models.Tutor", b =>
                {
                    b.HasOne("Control.Models.Teach")
                        .WithMany("Tutors")
                        .HasForeignKey("TeachId");
                });
#pragma warning restore 612, 618
        }
    }
}
