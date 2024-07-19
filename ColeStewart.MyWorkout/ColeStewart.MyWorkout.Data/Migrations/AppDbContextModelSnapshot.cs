﻿// <auto-generated />
using System;
using ColeStewart.MyWorkout.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ColeStewart.MyWorkout.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.Bracket", b =>
                {
                    b.Property<int>("BracketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BracketId"));

                    b.Property<string>("BracketName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("BracketId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("WorkoutSets");
                });

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExerciseId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.SetExercise", b =>
                {
                    b.Property<int>("SetExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SetExerciseId"));

                    b.Property<int>("BracketId")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int?>("Reps")
                        .HasColumnType("int");

                    b.Property<int?>("Time")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("SetExerciseId");

                    b.HasIndex("BracketId");

                    b.ToTable("SetExercises");
                });

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTimeOffset?>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.Widget", b =>
                {
                    b.Property<int>("WidgetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WidgetId"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("InventedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WidgetId");

                    b.ToTable("Widgets");
                });

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.Workout", b =>
                {
                    b.Property<int>("WorkoutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkoutId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkoutId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.Bracket", b =>
                {
                    b.HasOne("ColeStewart.MyWorkout.Data.Models.Workout", null)
                        .WithMany("Brackets")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.SetExercise", b =>
                {
                    b.HasOne("ColeStewart.MyWorkout.Data.Models.Bracket", null)
                        .WithMany("Exercise")
                        .HasForeignKey("BracketId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.Bracket", b =>
                {
                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("ColeStewart.MyWorkout.Data.Models.Workout", b =>
                {
                    b.Navigation("Brackets");
                });
#pragma warning restore 612, 618
        }
    }
}
