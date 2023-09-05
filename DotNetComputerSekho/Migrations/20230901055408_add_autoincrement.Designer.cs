﻿// <auto-generated />
using System;
using DotNetComputerSekho.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNetComputerSekho.Migrations
{
    [DbContext(typeof(AppDBcontext))]
    [Migration("20230901055408_add_autoincrement")]
    partial class add_autoincrement
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DotNetComputerSekho.Entities.Course", b =>
                {
                    b.Property<int>("course_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("course_id"));

                    b.Property<string>("age_grp_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("course_duration")
                        .HasColumnType("int");

                    b.Property<bool>("course_is_active")
                        .HasColumnType("bit");

                    b.Property<string>("course_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_syllabus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cover_photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("course_id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("DotNetComputerSekho.Entities.Enquiry", b =>
                {
                    b.Property<int>("enquiry_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("enquiry_id"));

                    b.Property<DateTime>("Follow_up_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("closure_reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enquirer_email_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enquirer_mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enquirer_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enquirer_query")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("enquiry_date")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("enquiry_processed_flag")
                        .HasColumnType("bit");

                    b.Property<string>("followup_msg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("staff_id")
                        .HasColumnType("int");

                    b.HasKey("enquiry_id");

                    b.ToTable("Enquiry");
                });

            modelBuilder.Entity("DotNetComputerSekho.Entities.Followup", b =>
                {
                    b.Property<int>("followup_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("followup_id"));

                    b.Property<int>("enquiry_id")
                        .HasColumnType("int");

                    b.Property<string>("followup_msg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("staff_id")
                        .HasColumnType("int");

                    b.HasKey("followup_id");

                    b.ToTable("Followup");
                });

            modelBuilder.Entity("DotNetComputerSekho.Entities.Placement", b =>
                {
                    b.Property<int>("placemetid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("placemetid"));

                    b.Property<int>("batchid")
                        .HasColumnType("int");

                    b.Property<string>("coursename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("placedstudents")
                        .HasColumnType("int");

                    b.Property<int>("total_student")
                        .HasColumnType("int");

                    b.HasKey("placemetid");

                    b.ToTable("Placement");
                });

            modelBuilder.Entity("DotNetComputerSekho.Entities.Staff", b =>
                {
                    b.Property<int>("staff_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("staff_id"));

                    b.Property<string>("photo_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("staff_isactive")
                        .HasColumnType("bit");

                    b.Property<string>("staff_mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("staff_id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("DotNetComputerSekho.Models.Batch", b =>
                {
                    b.Property<int>("batch_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("batch_id"));

                    b.Property<DateTime?>("batch_end_time")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("batch_fees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("batch_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("batch_start_time")
                        .HasColumnType("datetime2");

                    b.Property<int>("course_id")
                        .HasColumnType("int");

                    b.Property<int?>("course_id1")
                        .HasColumnType("int");

                    b.Property<DateTime?>("final_presentation_date")
                        .HasColumnType("datetime2");

                    b.HasKey("batch_id");

                    b.HasIndex("course_id1");

                    b.ToTable("Batch");
                });

            modelBuilder.Entity("DotNetComputerSekho.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("student_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("BatchId")
                        .HasColumnType("int")
                        .HasColumnName("batch_id");

                    b.Property<string>("StudentAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("student_address");

                    b.Property<DateTime>("StudentDob")
                        .HasColumnType("date")
                        .HasColumnName("student_dob");

                    b.Property<string>("StudentGender")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("student_gender");

                    b.Property<string>("StudentMobile")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("student_mobile");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("student_name");

                    b.Property<string>("StudentQualification")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("student_qualification");

                    b.HasKey("StudentId");

                    b.HasIndex("BatchId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DotNetComputerSekho.Models.Batch", b =>
                {
                    b.HasOne("DotNetComputerSekho.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("course_id1");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("DotNetComputerSekho.Models.Student", b =>
                {
                    b.HasOne("DotNetComputerSekho.Models.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batch");
                });
#pragma warning restore 612, 618
        }
    }
}
