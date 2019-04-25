﻿// <auto-generated />
using System;
using LetsLearn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LetsLearn.Migrations
{
    [DbContext(typeof(ManagementContext))]
    [Migration("20190425155718_Medie")]
    partial class Medie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LetsLearn.Data.Grade", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Homework");

                    b.Property<string>("StudentId");

                    b.Property<int>("Value");

                    b.Property<int>("Week");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("LetsLearn.Data.Homework", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ansear1")
                        .IsRequired();

                    b.Property<string>("Ansear2")
                        .IsRequired();

                    b.Property<string>("Ansear3")
                        .IsRequired();

                    b.Property<string>("Clasa")
                        .IsRequired();

                    b.Property<string>("Container")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CorrectAnsear")
                        .IsRequired();

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.Property<int>("Week");

                    b.HasKey("Id");

                    b.ToTable("Homeworks");
                });

            modelBuilder.Entity("LetsLearn.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clasa");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Image")
                        .HasMaxLength(60);

                    b.Property<bool>("IsTeacher");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<float>("Medie");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
