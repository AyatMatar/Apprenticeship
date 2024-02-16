﻿// <auto-generated />
using System;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231127050315_editReportlog")]
    partial class editReportlog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProject.Data.Entites.Apprenticeship", b =>
                {
                    b.Property<int>("apprenticeshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("apprenticeshipId"), 1L, 1);

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("studentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("teamleaderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("universitySupervisorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("apprenticeshipId");

                    b.HasIndex("studentId");

                    b.HasIndex("teamleaderId");

                    b.HasIndex("universitySupervisorId");

                    b.ToTable("apprenticeships");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.ApprenticeshipsObjectives", b =>
                {
                    b.Property<int>("objectiveId")
                        .HasColumnType("int");

                    b.Property<int>("apprenticeshipId")
                        .HasColumnType("int");

                    b.HasKey("objectiveId", "apprenticeshipId");

                    b.HasIndex("apprenticeshipId");

                    b.ToTable("apprenticeshipsObjectives");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Assignment", b =>
                {
                    b.Property<int>("assignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("assignmentId"), 1L, 1);

                    b.Property<int>("apprenticeshipId")
                        .HasColumnType("int");

                    b.Property<string>("assignmentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("assignmentNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("assignmentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("assignmentId");

                    b.HasIndex("apprenticeshipId");

                    b.ToTable("assignments");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.AssignmentObjectives", b =>
                {
                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<int>("objectivesId")
                        .HasColumnType("int");

                    b.HasKey("assignmentId", "objectivesId");

                    b.HasIndex("objectivesId");

                    b.ToTable("assignmentObjectives");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Company", b =>
                {
                    b.Property<int>("companyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("companyId"), 1L, 1);

                    b.Property<string>("companyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("companyId");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Objective", b =>
                {
                    b.Property<int>("objectiveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectiveId"), 1L, 1);

                    b.Property<string>("objectivecName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("objectiveId");

                    b.ToTable("objectives");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.ObjectivesSkills", b =>
                {
                    b.Property<int>("ObjectivecId")
                        .HasColumnType("int");

                    b.Property<int>("skillId")
                        .HasColumnType("int");

                    b.HasKey("ObjectivecId", "skillId");

                    b.HasIndex("skillId");

                    b.ToTable("objectivesSkills");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("National_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("thirdName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Report", b =>
                {
                    b.Property<int>("reportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reportId"), 1L, 1);

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<string>("reportDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reportNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("reportStatusId")
                        .HasColumnType("int");

                    b.HasKey("reportId");

                    b.HasIndex("assignmentId");

                    b.HasIndex("reportStatusId");

                    b.ToTable("reports");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.ReportLog", b =>
                {
                    b.Property<int>("reportLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reportLogId"), 1L, 1);

                    b.Property<DateTime?>("reportDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("reportDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("reportId")
                        .HasColumnType("int");

                    b.Property<string>("reportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reportNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("reportStatusId")
                        .HasColumnType("int");

                    b.HasKey("reportLogId");

                    b.HasIndex("reportId");

                    b.HasIndex("reportStatusId");

                    b.ToTable("reportLogs");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.ReportStatus", b =>
                {
                    b.Property<int>("reportStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reportStatusId"), 1L, 1);

                    b.Property<string>("statusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("reportStatusId");

                    b.ToTable("reportStatuses");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Skill", b =>
                {
                    b.Property<int>("skillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("skillId"), 1L, 1);

                    b.Property<string>("skillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("skillId");

                    b.ToTable("skills");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.University", b =>
                {
                    b.Property<int>("universityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("universityId"), 1L, 1);

                    b.Property<string>("universityAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("universityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("universityId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Student", b =>
                {
                    b.HasBaseType("FinalProject.Data.Entites.Person");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.Property<string>("major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("number_universtity")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("UniversityId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Teamleader", b =>
                {
                    b.HasBaseType("FinalProject.Data.Entites.Person");

                    b.Property<int>("companyId")
                        .HasColumnType("int");

                    b.Property<string>("department")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("companyId");

                    b.HasDiscriminator().HasValue("Teamleader");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.UniversitySupervisor", b =>
                {
                    b.HasBaseType("FinalProject.Data.Entites.Person");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int")
                        .HasColumnName("UniversitySupervisor_UniversityId");

                    b.Property<string>("field_work")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("UniversityId");

                    b.HasDiscriminator().HasValue("UniversitySupervisor");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Apprenticeship", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Student", "student")
                        .WithMany("apprenticeships")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Data.Entites.Teamleader", "teamleader")
                        .WithMany("apprenticeships")
                        .HasForeignKey("teamleaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Data.Entites.UniversitySupervisor", "UniversitySupervisor")
                        .WithMany("apprenticeships")
                        .HasForeignKey("universitySupervisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UniversitySupervisor");

                    b.Navigation("student");

                    b.Navigation("teamleader");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.ApprenticeshipsObjectives", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Apprenticeship", "apprenticeship")
                        .WithMany("apprenticeshipsObjectives")
                        .HasForeignKey("apprenticeshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Data.Entites.Objective", "objective")
                        .WithMany("apprenticeshipsObjectives")
                        .HasForeignKey("objectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("apprenticeship");

                    b.Navigation("objective");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Assignment", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Apprenticeship", "apprenticeship")
                        .WithMany("assignments")
                        .HasForeignKey("apprenticeshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("apprenticeship");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.AssignmentObjectives", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Assignment", "assignment")
                        .WithMany("assignmentObjectives")
                        .HasForeignKey("assignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Data.Entites.Objective", "objectives")
                        .WithMany("assignmentObjectives")
                        .HasForeignKey("objectivesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("assignment");

                    b.Navigation("objectives");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.ObjectivesSkills", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Objective", "Objectivec")
                        .WithMany("objectivesSkills")
                        .HasForeignKey("ObjectivecId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Data.Entites.Skill", "skill")
                        .WithMany()
                        .HasForeignKey("skillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objectivec");

                    b.Navigation("skill");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Report", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Assignment", "assignment")
                        .WithMany("reports")
                        .HasForeignKey("assignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Data.Entites.ReportStatus", "reportStatus")
                        .WithMany("reports")
                        .HasForeignKey("reportStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("assignment");

                    b.Navigation("reportStatus");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.ReportLog", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Report", "report")
                        .WithMany()
                        .HasForeignKey("reportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Data.Entites.ReportStatus", "ReportStatus")
                        .WithMany()
                        .HasForeignKey("reportStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReportStatus");

                    b.Navigation("report");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Data.Entites.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Student", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.University", "University")
                        .WithMany("student")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Teamleader", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.Company", "company")
                        .WithMany("teamleaders")
                        .HasForeignKey("companyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("company");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.UniversitySupervisor", b =>
                {
                    b.HasOne("FinalProject.Data.Entites.University", "University")
                        .WithMany("UniversitySupervisor")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Apprenticeship", b =>
                {
                    b.Navigation("apprenticeshipsObjectives");

                    b.Navigation("assignments");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Assignment", b =>
                {
                    b.Navigation("assignmentObjectives");

                    b.Navigation("reports");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Company", b =>
                {
                    b.Navigation("teamleaders");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Objective", b =>
                {
                    b.Navigation("apprenticeshipsObjectives");

                    b.Navigation("assignmentObjectives");

                    b.Navigation("objectivesSkills");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.ReportStatus", b =>
                {
                    b.Navigation("reports");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.University", b =>
                {
                    b.Navigation("UniversitySupervisor");

                    b.Navigation("student");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Student", b =>
                {
                    b.Navigation("apprenticeships");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.Teamleader", b =>
                {
                    b.Navigation("apprenticeships");
                });

            modelBuilder.Entity("FinalProject.Data.Entites.UniversitySupervisor", b =>
                {
                    b.Navigation("apprenticeships");
                });
#pragma warning restore 612, 618
        }
    }
}
