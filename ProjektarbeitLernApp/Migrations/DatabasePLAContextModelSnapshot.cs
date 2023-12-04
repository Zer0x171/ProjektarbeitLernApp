﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektarbeitLernApp.PLAContext;

#nullable disable

namespace ProjektarbeitLernApp.Migrations
{
    [DbContext(typeof(DatabasePLAContext))]
    partial class DatabasePLAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjektarbeitLernApp.Model.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ProjektarbeitLernApp.Model.LearnApp.ExamSimulation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("HasPassed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MultipleChoiceList")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sutdent_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ExamSimulation");
                });

            modelBuilder.Entity("ProjektarbeitLernApp.Model.LearnApp.LearnProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Stage")
                        .HasColumnType("int");

                    b.Property<int>("Student_Id")
                        .HasColumnType("int");

                    b.Property<bool>("WasShown")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("LearnProgress");
                });

            modelBuilder.Entity("ProjektarbeitLernApp.Model.LearnApp.MultipleChoiceSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MultipleChoiceSet");
                });
#pragma warning restore 612, 618
        }
    }
}
