using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WorkoutManagingService.Data.Entities;
using WorkoutManagingService.Data.Seed;

namespace WorkoutManagingService.Data
{
    public class WorkoutManagingServiceContext : DbContext
    {
        public WorkoutManagingServiceContext(DbContextOptions<WorkoutManagingServiceContext> options)
           : base(options)
        {
        }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<ExerciseExecution> ExerciseExecutions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users", "Security");

                entity.HasKey(r => r.Id)
                    .HasName("PK_Users");

                entity.Property(r => r.Id)
                    .HasMaxLength(100);

                entity.Property(r => r.Username)
                    .HasMaxLength(100)
                    .IsRequired(true);

                entity.HasMany(r => r.Workouts)
                    .WithOne(r => r.User)
                    .HasForeignKey(r => r.UserId)
                    .HasConstraintName("FK_Workouts_Users")
                    .IsRequired();

            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.ToTable("Workout", "Workout");

                entity.HasKey(r => r.Id)
                    .HasName("PK_Workout");

                entity.Property(r => r.UserId)
                    .HasMaxLength(100);

                entity.HasIndex(r => r.UserId)
                    .HasName("IX_Workout_UserId");

                entity.HasIndex(r => r.Created)
                    .HasName("IX_Workout_Created");

                entity.HasIndex(r => r.Executed)
                    .HasName("IX_Workout_Executed");

                entity.Property(r => r.Name)
                    .HasMaxLength(300);

                entity.HasMany(r => r.ExerciseExecutions)
                    .WithOne(r => r.Workout)
                    .HasForeignKey(r => r.WorkoutId)
                    .HasConstraintName("FK_ExerciseExecutions_Workout");

            });

            modelBuilder.Entity<ExerciseExecution>(entity =>
            {
                entity
                    .ToTable("ExerciseExecution", "Workout");

                entity
                    .HasKey(r => r.Id)
                    .HasName("PK_ExerciseExecution");

                entity
                    .HasIndex(r => new { r.Order, r.WorkoutId, r.ExerciseId })
                    .HasName("IX_ExerciseExecution_Order_Workout_Exercise");

            });

            modelBuilder.Entity<Exercise>(entity =>
            {
                entity
                    .ToTable("Exercise", "Workout");

                entity
                    .HasKey(r => r.Id)
                    .HasName("PK_Exercise");

                entity
                    .Property(r => r.Name)
                    .HasMaxLength(400);

                entity
                    .HasMany(r => r.ExerciseExecutions)
                    .WithOne(r => r.Exercise)
                    .HasForeignKey(r => r.ExerciseId)
                    .HasConstraintName("FK_ExerciseExecution_Exercise")
                    .IsRequired();

                entity.HasData(new ExerciseSeed().Exercises());

                entity.HasAnnotation("READONLY_ANNOTATION", true);

            });

        }
    }
}
