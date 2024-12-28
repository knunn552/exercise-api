﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exercise_api.ExerciseContext;

#nullable disable

namespace exercise_api.Migrations
{
    [DbContext(typeof(ExerciseDbContext))]
    [Migration("20241215220026_AddedMoreWorkouts")]
    partial class AddedMoreWorkouts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("exercise_api.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExerciseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkoutType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExerciseId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            ExerciseId = 1,
                            ExerciseType = "Primary",
                            Name = "Chin Ups",
                            VideoUrl = "https://www.youtube.com/watch?v=8mryJ3w2S78",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 2,
                            ExerciseType = "Primary",
                            Name = "Behind Neck Pull Ups",
                            VideoUrl = "https://www.youtube.com/watch?v=EAJJQjF2j6s#:~:text=Behind%20the%20Neck%20Pull%2DUp,Maintain%20a%20hollow%20body%20position.",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 3,
                            ExerciseType = "Primary",
                            Name = "Barbell Curls",
                            VideoUrl = "https://www.youtube.com/watch?v=N5x5M1x1Gd0",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 4,
                            ExerciseType = "Primary",
                            Name = "Behind Neck Overhead Press",
                            VideoUrl = "https://www.youtube.com/watch?v=7c2ITqTmv_Y&t=1s",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 5,
                            ExerciseType = "Primary",
                            Name = "Landmine Clean Press",
                            VideoUrl = "https://www.youtube.com/watch?v=bZRXZZXOEdQ",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 6,
                            ExerciseType = "Primary",
                            Name = "Landmine Rotational Press",
                            VideoUrl = "https://www.youtube.com/watch?v=ONDeomDVlbE",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 7,
                            ExerciseType = "Primary",
                            Name = "Landmine Rotations",
                            VideoUrl = "https://www.youtube.com/watch?v=e5DP6961WEk",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 8,
                            ExerciseType = "Primary",
                            Name = "Overhead Squats",
                            VideoUrl = "https://www.youtube.com/watch?v=RD_vUnqwqqI",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 9,
                            ExerciseType = "Primary",
                            Name = "Front Lunges",
                            VideoUrl = "https://www.youtube.com/watch?v=g8-Ge9S0aUw",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 10,
                            ExerciseType = "Primary",
                            Name = "Side Lunges",
                            VideoUrl = "https://www.youtube.com/watch?v=gwWv7aPcD88",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 11,
                            ExerciseType = "Accessory",
                            Name = "Kettlebell Hip Flexion",
                            VideoUrl = "https://www.youtube.com/watch?v=v7ACdKPXMf8",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 12,
                            ExerciseType = "Secondary",
                            Name = "Calf Raises",
                            VideoUrl = "https://www.youtube.com/watch?v=s6L9ZvN-04I",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 13,
                            ExerciseType = "Accessory",
                            Name = "Side Kick",
                            VideoUrl = "https://www.youtube.com/watch?v=isfOg50BElc",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 14,
                            ExerciseType = "Accessory",
                            Name = "Banded Overhead Rotations",
                            VideoUrl = "https://www.youtube.com/watch?v=YdN2Nz9vuRY",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 17,
                            ExerciseType = "Accessory",
                            Name = "Banded Pull Apart",
                            VideoUrl = "https://www.youtube.com/watch?v=MnDpmNYUjbc",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 18,
                            ExerciseType = "Accessory",
                            Name = "Banded Chest Flys",
                            VideoUrl = "https://www.youtube.com/watch?v=sVMWoS0OhsI",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 20,
                            ExerciseType = "Accessory",
                            Name = "Prone Swimmers",
                            VideoUrl = "https://www.youtube.com/watch?v=JeMxj4ORbtM",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 21,
                            ExerciseType = "Primary",
                            Name = "Bench Press",
                            VideoUrl = "https://www.youtube.com/watch?v=SCVCLChPQFY",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 22,
                            ExerciseType = "Primary",
                            Name = "Overhead Press",
                            VideoUrl = "https://www.youtube.com/watch?v=cGnhixvC8uA",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 23,
                            ExerciseType = "Primary",
                            Name = "Pull-Ups",
                            VideoUrl = "https://www.youtube.com/watch?v=aAggnpPyR6E",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 24,
                            ExerciseType = "Secondary",
                            Name = "Dumbbell Rows",
                            VideoUrl = "https://www.youtube.com/watch?v=6gvmcqr226U",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 25,
                            ExerciseType = "Secondary",
                            Name = "Incline Bench Press",
                            VideoUrl = "https://www.youtube.com/watch?v=2jFFCy8JBU8",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 26,
                            ExerciseType = "Secondary",
                            Name = "Dips",
                            VideoUrl = "https://www.youtube.com/watch?v=cFG8gJlC-D0",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 27,
                            ExerciseType = "Accessory",
                            Name = "Lateral Raises",
                            VideoUrl = "https://www.youtube.com/watch?v=OuG1smZTsQQ",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 28,
                            ExerciseType = "Accessory",
                            Name = "Reverse Tricep Pushups",
                            VideoUrl = "https://www.youtube.com/watch?v=5oMnUzy_hQ8&t=12s",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 30,
                            ExerciseType = "Primary",
                            Name = "Back Squat",
                            VideoUrl = "https://www.youtube.com/watch?v=Rvy12jFLBFo",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 31,
                            ExerciseType = "Primary",
                            Name = "Deadlift",
                            VideoUrl = "https://www.youtube.com/watch?v=AweC3UaM14o",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 33,
                            ExerciseType = "Secondary",
                            Name = "Bulgarian Split Squat",
                            VideoUrl = "https://www.youtube.com/watch?v=vgn7bSXkgkA",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 34,
                            ExerciseType = "Secondary",
                            Name = "Romanian Deadlift",
                            VideoUrl = "https://www.youtube.com/watch?v=GZAKFRNtxLY&t=6s",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 35,
                            ExerciseType = "Secondary",
                            Name = "Step-Ups",
                            VideoUrl = "https://www.youtube.com/watch?v=9ZknEYboBOQ",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 37,
                            ExerciseType = "Secondary",
                            Name = "Glute Ham Raises",
                            VideoUrl = "https://www.youtube.com/watch?v=m0AIU1dCVkU",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 38,
                            ExerciseType = "Primary",
                            Name = "Front Loaded Forward Lunges",
                            VideoUrl = "https://www.youtube.com/watch?v=JGQidbn14GI",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 39,
                            ExerciseType = "Secondary",
                            Name = "Dumbbell Lunges",
                            VideoUrl = "https://www.youtube.com/watch?v=h4N6Ic-3LJI",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 40,
                            ExerciseType = "Primary",
                            Name = "Overhead Front Lunges",
                            VideoUrl = "https://www.youtube.com/watch?v=m6MczOv_Ayg",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 41,
                            ExerciseType = "Accessory",
                            Name = "Banded Front Monster Walks",
                            VideoUrl = "https://www.youtube.com/watch?v=mWlgcUfCsTo",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 42,
                            ExerciseType = "Accessory",
                            Name = "Banded Lateral Walks",
                            VideoUrl = "https://www.youtube.com/watch?v=owcmPqkhAO4",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 43,
                            ExerciseType = "Accessory",
                            Name = "Banded Adductor Pulls",
                            VideoUrl = "https://www.youtube.com/watch?v=YXSxxzKHYdg",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 44,
                            ExerciseType = "Primary",
                            Name = "Leg Press",
                            VideoUrl = "https://www.youtube.com/watch?v=NHcaiGLhEK8",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 45,
                            ExerciseType = "Secondary",
                            Name = "Goblet Squat",
                            VideoUrl = "https://www.youtube.com/watch?v=JxhPHvR88rw",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 46,
                            ExerciseType = "Secondary",
                            Name = "Close Grip Bench Press",
                            VideoUrl = "https://www.youtube.com/watch?v=DzA2xZhDGeo",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 47,
                            ExerciseType = "Secondary",
                            Name = "Reverse Grip Bench Press",
                            VideoUrl = "https://www.youtube.com/watch?v=_y5VJGlk32I",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 48,
                            ExerciseType = "Primary",
                            Name = "Barbell Rows",
                            VideoUrl = "https://www.youtube.com/watch?v=bm0_q9bR_HA",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 49,
                            ExerciseType = "Secondary",
                            Name = "Reverse Barbell Rows",
                            VideoUrl = "https://www.youtube.com/watch?v=cZvQNvTUUu0",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 50,
                            ExerciseType = "Primary",
                            Name = "Front Squat",
                            VideoUrl = "https://www.youtube.com/watch?v=CE0uSrr4SYQ",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            ExerciseId = 51,
                            ExerciseType = "Secondary",
                            Name = "Reverse Grip RDL",
                            VideoUrl = "https://www.youtube.com/watch?v=ZPHLuDKJFls",
                            WorkoutType = "LowerBodyStrength"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
