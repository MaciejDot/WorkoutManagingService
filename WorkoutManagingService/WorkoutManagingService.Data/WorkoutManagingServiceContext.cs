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
        public DbSet<MoodLevel> MoodLevels { get; set; }
        public DbSet<FatigueLevel> FatigueLevels { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<ExerciseExecution> ExerciseExecutions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GroupOfExercises> GroupOfExercises { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<ExerciseExecutionPlan> ExerciseExecutionPlans { get; set; }
        public DbSet<WorkoutPlanVersion> WorkoutPlanVersions { get; set; }
        public DbSet<WorkoutVersion> WorkoutVersions { get; set; }
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

                entity.HasMany(r => r.WorkoutPlans)
                    .WithOne(r => r.User)
                    .HasForeignKey(r => r.UserId)
                    .HasConstraintName("FK_WorkoutPlans_User")
                    .IsRequired();
            });

            modelBuilder.Entity<WorkoutPlanVersion>(entity =>
            {

                entity.ToTable("WorkoutPlanVersion", "Workout");

                entity.HasKey(r => r.Id)
                    .HasName("PK_WorkoutPlanVersion");

                entity.Property(r => r.WorkoutPlanId)
                    .HasMaxLength(100);

                entity.HasIndex(r => new { r.WorkoutPlanId, r.Created })
                    .HasName("IX_WorkoutPlanVersion_WorkoutPlanId_Created");

                entity.HasMany(r => r.ExerciseExecutionPlans)
                        .WithOne(r => r.WorkoutPlanVersion)
                        .HasForeignKey(r => r.WorkoutPlanVersionId)
                        .HasConstraintName("FK_ExerciseExecutionPlan_WorkoutPlanVersions")
                        .IsRequired();
            });

            modelBuilder.Entity<WorkoutPlan>(entity =>
            {
                entity.ToTable("WorkoutPlan", "Workout");

                entity.Property(r => r.Id)
                    .HasMaxLength(100);

                entity.HasMany(r => r.WorkoutPlanVersions)
                    .WithOne(r => r.WorkoutPlan)
                    .HasForeignKey(r => r.WorkoutPlanId)
                    .HasConstraintName("FK_WorkoutPlanVersions_WorkoutPlan")
                    .IsRequired();

                entity.HasKey(r => r.Id)
                    .HasName("PK_WorkoutPlan");

                entity.Property(x => x.Name)
                    .HasMaxLength(400);

                entity.Property(x => x.Description)
                    .HasMaxLength(1000);

                entity.HasIndex(x => x.UserId)
                    .HasName("IX_WorkoutPlans_UserId");


                entity.HasIndex(r => new { r.UserId, r.DeactivationDate, r.Name })
                    .IsUnique();

            });

            modelBuilder.Entity<ExerciseExecutionPlan>(entity =>
            {
                entity.ToTable("ExerciseExecutionPlan", "Workout");

                entity.HasKey(x => x.Id)
                    .HasName("PK_ExerciseExecutionPlan");

                entity.HasIndex(x => new { x.Order, x.WorkoutPlanVersionId, x.ExerciseId })
                    .HasName("IX_ExerciseExecutionPlan_Order_WorkoutPlanId_ExerciseId");

                entity.Property(x => x.Description).HasMaxLength(1000);
            });

            modelBuilder.Entity<WorkoutVersion>(entity =>
            {
                entity.ToTable("WorkoutVersion", "Workout");

                entity.HasKey(r => r.Id)
                    .HasName("PK_WorkoutVersion");

                entity.Property(r => r.WorkoutId)
                    .HasMaxLength(100);

                entity.HasIndex(r => new { r.WorkoutId, r.Created })
                    .HasName("IX_WorkoutVersion_WorkoutId_Created");

                entity.HasIndex(r => r.MoodLevelId)
                    .HasName("IX_WorkoutVersion_MoodLevelId");

                entity.HasIndex(r => r.WorkoutId)
                    .HasName("IX_WorkoutVersion_WorkoutId");

                entity.HasMany(r => r.ExerciseExecutions)
                        .WithOne(r => r.WorkoutVersion)
                        .HasForeignKey(r => r.WorkoutVersionId)
                        .HasConstraintName("FK_ExerciseExecution_WorkoutVersions")
                        .IsRequired();
            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.ToTable("Workout", "Workout");

                entity.HasKey(r => r.Id)
                    .HasName("PK_Workout");
                entity.Property(r => r.Id)
                   .HasMaxLength(100);
                entity.Property(r => r.UserId)
                    .HasMaxLength(100);

                entity.HasIndex(r => r.UserId)
                    .HasName("IX_Workout_UserId");

                entity.HasIndex(r => r.Created)
                    .HasName("IX_Workout_Created");

                entity.Property(r => r.Name)
                    .HasMaxLength(300);

                entity.HasMany(r => r.WorkoutVersions)
                    .WithOne(r => r.Workout)
                    .HasForeignKey(r => r.WorkoutId)
                    .HasConstraintName("FK_ExerciseExecutions_Workout");


                entity.HasIndex(r => new { r.UserId, r.DeactivationDate, r.Name })
                    .IsUnique();

            });

            modelBuilder.Entity<ExerciseExecution>(entity =>
            {
                entity
                    .ToTable("ExerciseExecution", "Workout");

                entity
                    .HasKey(r => r.Id)
                    .HasName("PK_ExerciseExecution");

                entity
                    .HasIndex(r => new { r.Order, r.WorkoutVersionId, r.ExerciseId })
                    .HasName("IX_ExerciseExecution_Order_Workout_Exercise");

                entity
                    .Property(r => r.Description)
                    .HasMaxLength(1000);

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
                    .HasIndex(r => r.GroupId)
                    .HasName("IX_Exercise_GroupId");

                entity
                    .HasMany(r => r.ExerciseExecutions)
                    .WithOne(r => r.Exercise)
                    .HasForeignKey(r => r.ExerciseId)
                    .HasConstraintName("FK_ExerciseExecution_Exercise")
                    .IsRequired();

                entity.HasData(new ExerciseSeed().Exercises());

                entity.HasAnnotation("READONLY_ANNOTATION", true);

            });

            modelBuilder.Entity<GroupOfExercises>(entity =>
            {
                entity.ToTable("GroupOfExercise", "Workout");

                entity.HasKey(r => r.Id)
                    .HasName("PK_GroupOfExercises");

                entity.HasMany(r => r.Exercises)
                    .WithOne(r => r.GroupOfExercises)
                    .HasForeignKey(r => r.GroupId)
                    .HasConstraintName("FK_Exercise_GroupOfExercises")
                    .IsRequired();

                entity.Property(r => r.Name)
                    .HasMaxLength(400);

                entity.HasData(new GroupOfExerciseSeed().GroupsOfExercises());

                entity.HasAnnotation("READONLY_ANNOTATION", true);
            });

            modelBuilder.Entity<MoodLevel>(entity =>
            {
                entity.ToTable("MoodLevel", "Workout");

                entity.HasKey(r => r.Id)
                    .HasName("PK_MoodLevel");

                entity.Property(r => r.Name)
                    .HasMaxLength(400);

                entity.HasMany(r => r.WorkoutVersions)
                    .WithOne(r => r.MoodLevel)
                    .HasForeignKey(r => r.MoodLevelId)
                    .HasConstraintName("FK_WorkoutVersion_MoodLevel")
                    .IsRequired();

                entity.HasData(new MoodLevelSeed().MoodLevels());

                entity.HasAnnotation("READONLY_ANNOTATION", true);
            });

            modelBuilder.Entity<FatigueLevel>(entity =>
            {
                entity.ToTable("FatihueLevel", "Workout");

                entity.HasKey(r => r.Id)
                    .HasName("PK_FatihueLevel");

                entity.Property(r => r.Name)
                    .HasMaxLength(400);

                entity.HasMany(r => r.WorkoutVersions)
                    .WithOne(r => r.FatigueLevel)
                    .HasForeignKey(r => r.FatigueLevelId)
                    .HasConstraintName("FK_WorkoutVersion_FatigueLevels")
                    .IsRequired();

                entity.HasData(new FatigueLevelSeed().FatigueLevels());

                entity.HasAnnotation("READONLY_ANNOTATION", true);
            });
        }
    }
}
