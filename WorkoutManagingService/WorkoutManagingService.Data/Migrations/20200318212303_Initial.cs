using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkoutManagingService.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Workout");

            migrationBuilder.EnsureSchema(
                name: "Security");

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Security",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    Username = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FatihueLevel",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FatihueLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupOfExercise",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOfExercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoodLevel",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoodLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(maxLength: 300, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeactivationDate = table.Column<DateTime>(nullable: true),
                    IsPublic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_Users",
                        column: x => x.UserId,
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlan",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    DeactivationDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 400, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    IsPublic = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutPlans_User",
                        column: x => x.UserId,
                        principalSchema: "Security",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 400, nullable: true),
                    IsHold = table.Column<bool>(nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercise_GroupOfExercises",
                        column: x => x.GroupId,
                        principalSchema: "Workout",
                        principalTable: "GroupOfExercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutVersion",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutId = table.Column<string>(maxLength: 100, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Executed = table.Column<DateTime>(nullable: false),
                    FatigueLevelId = table.Column<int>(nullable: false),
                    MoodLevelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutVersion_FatigueLevels",
                        column: x => x.FatigueLevelId,
                        principalSchema: "Workout",
                        principalTable: "FatihueLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutVersion_MoodLevel",
                        column: x => x.MoodLevelId,
                        principalSchema: "Workout",
                        principalTable: "MoodLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseExecutions_Workout",
                        column: x => x.WorkoutId,
                        principalSchema: "Workout",
                        principalTable: "Workout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlanVersion",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutPlanId = table.Column<string>(maxLength: 100, nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlanVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutPlanVersions_WorkoutPlan",
                        column: x => x.WorkoutPlanId,
                        principalSchema: "Workout",
                        principalTable: "WorkoutPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseExecution",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    Repetitions = table.Column<int>(nullable: false),
                    AdditionalKgs = table.Column<int>(nullable: false),
                    Break = table.Column<int>(nullable: false),
                    Series = table.Column<int>(nullable: false),
                    WorkoutVersionId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseExecution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseExecution_Exercise",
                        column: x => x.ExerciseId,
                        principalSchema: "Workout",
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseExecution_WorkoutVersions",
                        column: x => x.WorkoutVersionId,
                        principalSchema: "Workout",
                        principalTable: "WorkoutVersion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseExecutionPlan",
                schema: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutPlanVersionId = table.Column<int>(nullable: false),
                    Series = table.Column<int>(nullable: false),
                    MinReps = table.Column<int>(nullable: false),
                    MaxReps = table.Column<int>(nullable: false),
                    MinAdditionalKgs = table.Column<int>(nullable: false),
                    MaxAdditionalKgs = table.Column<int>(nullable: false),
                    ExerciseId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Break = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseExecutionPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseExecutionPlan_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalSchema: "Workout",
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseExecutionPlan_WorkoutPlanVersions",
                        column: x => x.WorkoutPlanVersionId,
                        principalSchema: "Workout",
                        principalTable: "WorkoutPlanVersion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Workout",
                table: "FatihueLevel",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "NoneFatigue" },
                    { 2, "MildFatigue" },
                    { 3, "ModerateFatigue" },
                    { 4, "SevireFatigue" },
                    { 5, "ExtremeFatigue" }
                });

            migrationBuilder.InsertData(
                schema: "Workout",
                table: "GroupOfExercise",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 50, "Impossible Dips" },
                    { 49, "Dynamic Superman" },
                    { 48, "Dynamic Hollow Body" },
                    { 47, "Leg Raises" },
                    { 46, "Superman" },
                    { 45, "Hollow Body" },
                    { 42, "Inverted Cross Press" },
                    { 43, "Reverse Planche" },
                    { 51, "Neck Hold" },
                    { 41, "Iron Cross" },
                    { 40, "Maltese Lean" },
                    { 39, "Plank" },
                    { 38, "Planche Lean Push Ups" },
                    { 44, "Victorian Cross Leans" },
                    { 52, "Christo" },
                    { 55, "Planche Hollow Body" },
                    { 54, "Zanetti Flies" },
                    { 68, "Reverse Leg Raises Hold" },
                    { 67, "Reverse Leg Raises" },
                    { 66, "Box Planche Press" },
                    { 65, "Box Planche Raises" },
                    { 64, "Front Lever Raises" },
                    { 63, "Box Planche" },
                    { 53, "Half Zanetti Flies" },
                    { 62, "Bridge" },
                    { 60, "Biceps Curls" },
                    { 59, "OHP" },
                    { 58, "Incline Bench Press" },
                    { 57, "Bench Press" },
                    { 56, "Maltese Hollow Body" },
                    { 37, "Planche Lean" },
                    { 61, "Dead Lift" },
                    { 36, "Handstand Flag" },
                    { 35, "Inverted Cross Press" },
                    { 14, "Dips" },
                    { 34, "Inverted Cross" },
                    { 13, "Support Hold" },
                    { 12, "Pull Ups" },
                    { 11, "Rows" },
                    { 10, "Front Lever Pull Ups" },
                    { 9, "Front Lever Press" },
                    { 15, "Human Flag" },
                    { 8, "Front Lever" },
                    { 6, "Back Lever Press" },
                    { 5, "Back Lever" },
                    { 4, "L-sit V-sit Manna" },
                    { 3, "Handstand Press" },
                    { 2, "Handstand Push Ups" },
                    { 1, "Handstand" },
                    { 7, "Back Lever Pull Ups" },
                    { 16, "Muscle Ups" },
                    { 17, "Hefesto" },
                    { 18, "High Pull Ups" },
                    { 33, "Maltese Press" },
                    { 32, "Maltese" },
                    { 31, "Planche Press" },
                    { 30, "Planche Push Ups" },
                    { 29, "Planche" },
                    { 28, "Front Lever Touch" },
                    { 27, "Dragon Press Press" },
                    { 26, "Dragon Press" },
                    { 25, "Dragon Flag Press" },
                    { 24, "Dragon Flag" },
                    { 23, "Victorian Cross" },
                    { 22, "Reverse Hang" },
                    { 21, "Dead Hang" },
                    { 20, "Push Ups" },
                    { 19, "Squats" }
                });

            migrationBuilder.InsertData(
                schema: "Workout",
                table: "MoodLevel",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Depressed" },
                    { 4, "Bored" },
                    { 6, "Upset" },
                    { 2, "Happy" },
                    { 1, "Excited" },
                    { 3, "Contented" },
                    { 7, "Sad" }
                });

            migrationBuilder.InsertData(
                schema: "Workout",
                table: "Exercise",
                columns: new[] { "Id", "GroupId", "IsHold", "Name" },
                values: new object[,]
                {
                    { 100, 1, true, "Wall Handstand" },
                    { 3300, 33, false, "Straddle Maltese Press Eccentric" },
                    { 3203, 32, true, "Full Rings Maltese" },
                    { 3202, 32, true, "Full Maltese" },
                    { 3201, 32, true, "Straddle Rings Maltese" },
                    { 3200, 32, true, "Straddle Maltese" },
                    { 3118, 31, false, "Full Rings Planche Press" },
                    { 3117, 31, false, "Full Rings Planche Press Eccentric" },
                    { 3116, 31, false, "Full Planche Press" },
                    { 3301, 33, false, "Straddle Maltese Press" },
                    { 3115, 31, false, "Full Planche Press Eccentric" },
                    { 3113, 31, false, "Straddle Rings Planche Press Eccentric" },
                    { 3112, 31, false, "Half Lay Planche Press" },
                    { 3111, 31, false, "Half Lay Planche Press Eccentric" },
                    { 3109, 31, false, "Straddle Planche Press" },
                    { 3108, 31, false, "Straddle Planche Press Eccentric" },
                    { 3107, 31, false, "Advanced Rings Tuck Planche Press" },
                    { 3106, 31, false, "Advanced Rings Tuck Planche Press Eccentric" },
                    { 3105, 31, false, "Advanced Tuck Planche Press" },
                    { 3114, 31, false, "Straddle Rings Planche Press" },
                    { 3104, 31, false, "Advanced Tuck Planche Press Eccentric" },
                    { 3302, 33, false, "Straddle Rings Maltese Press Eccentric" },
                    { 3304, 33, false, "Full Maltese Press Eccentric" },
                    { 3700, 37, true, "Planche Lean" },
                    { 3601, 36, true, "Full One Arm Handstand Flag" },
                    { 3600, 36, true, "Full Handstand Flag" },
                    { 3507, 35, false, "Full Inverted Cross Press" },
                    { 3506, 35, false, "Full Inverted Cross Press Eccentric" },
                    { 3505, 35, false, "75 Degrees Inverted Cross Press" },
                    { 3504, 35, false, "75 Degrees Inverted Cross Press Eccentric" },
                    { 3503, 35, false, "45 Degrees Inverted Cross Press" },
                    { 3303, 33, false, "Straddle Rings Maltese Press" },
                    { 3502, 35, false, "45 Degrees Inverted Cross Press Eccentric" },
                    { 3500, 35, false, "30 Degrees Inverted Cross Press Eccentric" },
                    { 3403, 34, true, "Full Inverted Cross" },
                    { 3402, 34, true, "75 Degrees Inverted Cross" },
                    { 3401, 34, true, "45 Degrees Inverted Cross" },
                    { 3400, 34, true, "30 Degrees Inverted Cross" },
                    { 3307, 33, false, "Full Rings Maltese Press" },
                    { 3306, 33, false, "Full Rings Maltese Press Eccentric" },
                    { 3305, 33, false, "Full Maltese Press" },
                    { 3501, 35, false, "30 Degrees Inverted Cross Press" },
                    { 3701, 37, true, "Elevated Planche Lean" },
                    { 3103, 31, false, "Tuck Rings Planche Press" },
                    { 3101, 31, false, "Tuck Planche Press" },
                    { 2801, 28, true, "Straddle Front Lever Touch" },
                    { 2800, 28, true, "Advanced Tuck Front Lever Touch" },
                    { 2707, 27, false, "One Arm Dragon Press Press" },
                    { 2706, 27, false, "One Arm Dragon Press Press Eccentric" },
                    { 2705, 27, false, "Full Dragon Press Press" },
                    { 2704, 27, false, "Full Dragon Press Press Eccentric" },
                    { 2703, 27, false, "Straddle Dragon Press Press" },
                    { 2702, 27, false, "Straddle Dragon Press Press Eccentric" },
                    { 2802, 28, true, "Half Lay Front Lever Touch" },
                    { 2701, 27, false, "Advanced Tuck Dragon Press Press" },
                    { 2604, 26, true, "One Arm Dragon Press" },
                    { 2603, 26, true, "Full Dragon Press" },
                    { 2602, 26, true, "Straddle Dragon Press" },
                    { 2601, 26, true, "Advanced Tuck Dragon Press" },
                    { 2600, 26, true, "L Dragon Press" },
                    { 2507, 25, false, "One Arm Dragon Flag Press" },
                    { 2506, 25, false, "One Arm Dragon Flag Press Eccentric" },
                    { 2505, 25, false, "Full Dragon Flag Press" },
                    { 2700, 27, false, "Advanced Tuck Dragon Press Press Eccentric" },
                    { 3102, 31, false, "Tuck Rings Planche Press Eccentric" },
                    { 2803, 28, true, "Full Front Lever Touch" },
                    { 2900, 29, true, "Tuck Planche" },
                    { 3100, 31, false, "Tuck Planche Press Eccentric" },
                    { 3008, 30, false, "Full Rings Planche Push Ups" },
                    { 3007, 30, false, "Full Planche Push Ups" },
                    { 3006, 30, false, "Straddle Rings Planche Push Ups" },
                    { 3005, 30, false, "Half Lay Planche Push Ups" },
                    { 3004, 30, false, "Straddle Planche Push Ups" },
                    { 3003, 30, false, "Advanced Rings Tuck Planche Push Ups" },
                    { 3002, 30, false, "Advanced Tuck Planche Push Ups" },
                    { 2804, 28, true, "Wide Full Front Lever Touch" },
                    { 3001, 30, false, "Tuck Rings Planche Push Ups" },
                    { 2908, 29, true, "Full Rings Planche" },
                    { 2907, 29, true, "Full Planche" },
                    { 2906, 29, true, "Straddle Rings Planche" },
                    { 2905, 29, true, "Half Lay Planche" },
                    { 2904, 29, true, "Straddle Planche" },
                    { 2903, 29, true, "Advanced Rings Tuck Planche" },
                    { 2902, 29, true, "Advanced Tuck Planche" },
                    { 2901, 29, true, "Tuck Rings Planche" },
                    { 3000, 30, false, "Tuck Planche Push Ups" },
                    { 2504, 25, false, "Full Dragon Flag Press Eccentric" },
                    { 3702, 37, true, "Rings Planche Lean" },
                    { 3800, 38, false, "Planche Lean Push Ups" },
                    { 6301, 63, true, "Half Lay Box Planche" },
                    { 6300, 63, true, "Advanced Tuck Box Planche" },
                    { 6200, 62, true, "Bridge" },
                    { 6100, 61, false, "Dead Lift" },
                    { 6000, 60, false, "Biceps Curls" },
                    { 5900, 59, false, "OHP" },
                    { 5800, 58, false, "Incline Bench Press" },
                    { 5700, 57, false, "Bench Press" },
                    { 6302, 63, true, "Full Box Planche" },
                    { 5600, 56, true, "Maltese Hollow Body" },
                    { 5400, 54, false, "Zanetti Flies" },
                    { 5300, 53, false, "Half Zanetti Flies" },
                    { 5200, 52, true, "Christo" },
                    { 5100, 51, true, "Neck Hold" },
                    { 5001, 50, false, "Impossible Dips" },
                    { 5000, 50, false, "Impossible Dips Eccentric" },
                    { 4901, 49, false, "Superman Raises" },
                    { 4900, 49, false, "Superman Rocks" },
                    { 5500, 55, true, "Planche Hollow Body" },
                    { 4801, 48, false, "Hollow Body Raises" },
                    { 6400, 64, false, "Tuck Front Lever Raise" },
                    { 6402, 64, false, "Super Advanced Tuck Front Lever Raise" },
                    { 6800, 68, true, "Box Revrse Leg Raises (Hips on Box) Hold" },
                    { 6702, 67, false, "Box Revrse Leg Raises (Only Chest on Box)" },
                    { 6701, 67, false, "Box Revrse Leg Raises (Stomach on Box)" },
                    { 6700, 67, false, "Box Revrse Leg Raises (Hips on Box)" },
                    { 6605, 66, false, "Full Box Planche Press" },
                    { 6604, 66, false, "Full Box Planche Press Eccentric" },
                    { 6603, 66, false, "Half Lay Box Planche Press" },
                    { 6602, 66, false, "Half Lay Box Planche Press Eccentric" },
                    { 6401, 64, false, "Advanced Tuck Front Lever Raise" },
                    { 6601, 66, false, "Advanced Tuck Box Planche Press" },
                    { 6502, 65, false, "Full Box Planche Raise" },
                    { 6501, 65, false, "Half Lay Box Planche Raise" },
                    { 6500, 65, false, "Advanced Tuck Box Planche Raise" },
                    { 6407, 64, false, "One Arm Front Lever Raise" },
                    { 6406, 64, false, "Assisted One Arm Front Lever Raise" },
                    { 6405, 64, false, "Wide Full Front Lever Raise" },
                    { 6404, 64, false, "Full Front Lever Raise" },
                    { 6403, 64, false, "Straddle Front Lever Raise" },
                    { 6600, 66, false, "Advanced Tuck Box Planche Press Eccentric" },
                    { 3703, 37, true, "Elevated Rings Planche Lean" },
                    { 4800, 48, false, "Hollow Body Rocks" },
                    { 4702, 47, false, "Full Leg Raises" },
                    { 4101, 41, true, "45 Degrees Iron Cross" },
                    { 4100, 41, true, "30 Degrees Iron Cross" },
                    { 4003, 40, true, "Elevated Rings Maltese Lean" },
                    { 4002, 40, true, "Rings Maltese Lean" },
                    { 4001, 40, true, "Elevated Maltese Lean" },
                    { 4000, 40, true, "Maltese Lean" },
                    { 3911, 39, true, "Elevated Rings Plank" },
                    { 3910, 39, true, "One Arm Rings Plank" },
                    { 4102, 41, true, "75 Degrees Iron Cross" },
                    { 3909, 39, true, "Elevated Rings Plank" },
                    { 3907, 39, true, "Elevated One Arm Plank" },
                    { 3906, 39, true, "One Arm Plank" },
                    { 3905, 39, true, "Elevated One Arm Elbow Plank" },
                    { 3904, 39, true, "One Arm Elbow Plank" },
                    { 3903, 39, true, "Elevated Plank" },
                    { 3902, 39, true, "Plank" },
                    { 3901, 39, true, "Elevated Elbow Plank" },
                    { 3900, 39, true, "Elbow Plank" },
                    { 3908, 39, true, "Rings Plank" },
                    { 4703, 47, false, "One Arm Leg Raises" },
                    { 4103, 41, true, "Full Iron Cross" },
                    { 4201, 42, false, "30 Degrees Iron Cross Press" },
                    { 4701, 47, false, "Straddle Leg Raises" },
                    { 4700, 47, false, "Tuck Leg Raises" },
                    { 4600, 46, true, "Superman" },
                    { 4503, 45, true, "Hollow Body" },
                    { 4502, 45, true, "Straddle Hollow Body" },
                    { 4501, 45, true, "Super Advanced Hollow Body" },
                    { 4500, 45, true, "Advanced Hollow Body" },
                    { 4403, 44, true, "Elevated Rings Victorian Cross Lean" },
                    { 4200, 42, false, "30 Degrees Iron Cross Press Eccentric" },
                    { 4402, 44, true, "Rings Victorian Cross Lean" },
                    { 4400, 44, true, "Victorian Cross Lean" },
                    { 4300, 43, true, "Reverse Planche" },
                    { 4207, 42, false, "Full Iron Cross Press" },
                    { 4206, 42, false, "Full Iron Cross Press Eccentric" },
                    { 4205, 42, false, "75 Degrees Iron Cross Press" },
                    { 4204, 42, false, "75 Degrees Iron Cross Press Eccentric" },
                    { 4203, 42, false, "45 Degrees Iron Cross Press" },
                    { 4202, 42, false, "45 Degrees Iron Cross Press Eccentric" },
                    { 4401, 44, true, "Elevated Victorian Cross Lean" },
                    { 6801, 68, true, "Box Revrse Leg Raises (Stomach on Box) Hold" },
                    { 2503, 25, false, "Straddle Dragon Flag Press" },
                    { 2501, 25, false, "Advanced Tuck Dragon Flag Press" },
                    { 807, 8, true, "One Arm Front Lever" },
                    { 806, 8, true, "One Arm Side Lever" },
                    { 805, 8, true, "Wide Full Front Lever" },
                    { 804, 8, true, "Full Front Lever" },
                    { 803, 8, true, "Half Lay Front Lever" },
                    { 802, 8, true, "Straddle Front Lever" },
                    { 801, 8, true, "Advanced Tuck Front Lever" },
                    { 800, 8, true, "Tuck Front Lever" },
                    { 900, 9, false, "Dead Hang Thru Tuck Front Lever Press To Reverse Hang Eccentric" },
                    { 705, 7, false, "Full Back Lever Pull Ups" },
                    { 703, 7, false, "Straddle Back Lever Pull Ups" },
                    { 702, 7, false, "Advanced Tuck Back Lever Pull Ups" },
                    { 701, 7, false, "Tuck Back Lever Pull Ups" },
                    { 700, 7, false, "German Hang Pull Ups" },
                    { 609, 6, false, "German Hang Thru Full Back Lever Press To Reverse Hang" },
                    { 608, 6, false, "Full Back Lever Press To Reverse Hang" },
                    { 607, 6, false, "German Hang Thru Half Lay Back Lever Press To Reverse Hang" },
                    { 606, 6, false, "Half Lay Back Lever Press To Reverse Hang" },
                    { 704, 7, false, "Half Lay Back Lever Pull Ups" },
                    { 605, 6, false, "German Hang Thru Straddle Back Lever Press To Reverse Hang" },
                    { 901, 9, false, "Tuck Front Lever Press To Reverse Hang" },
                    { 903, 9, false, "Dead Hang Thru Advanced Front Back Lever Press To Reverse Hang Eccentric" },
                    { 1002, 10, false, "Advanced Tuck Front Lever False Grip Pull Ups" },
                    { 1001, 10, false, "Tuck Front Lever Pull Ups" },
                    { 1000, 10, false, "Tuck Front Lever False Grip Pull Ups" },
                    { 918, 9, false, "Dead Hang Thru One Arm Front Lever Press To Reverse Hang" },
                    { 917, 9, false, "One Arm Front Lever Press To Reverse Hang" },
                    { 916, 9, false, "Dead Hang Thru One Arm Front Lever Press To Reverse Hang Eccentric" },
                    { 915, 9, false, "Dead Hang Press To One Arm Front Lever" },
                    { 914, 9, false, "Dead Hang Thru Full Front Lever Press To Reverse Hang" },
                    { 902, 9, false, "Dead Hang Thru Tuck Front Lever Press To Reverse Hang" },
                    { 913, 9, false, "Full Front Lever Press To Reverse Hang" },
                    { 911, 9, false, "Dead Hang Thru Half Lay Front Lever Press To Reverse Hang" },
                    { 910, 9, false, "Half Lay Front Lever Press To Reverse Hang" },
                    { 909, 9, false, "Dead Hang Thru Half Lay Front Lever Press To Reverse Hang Eccentric" },
                    { 908, 9, false, "Dead Hang Thru Straddle Front Lever Press To Reverse Hang" },
                    { 907, 9, false, "Straddle Front Lever Press To Reverse Hang" },
                    { 906, 9, false, "Dead Hang Thru Straddle Front Lever Press To Reverse Hang Eccentric" },
                    { 905, 9, false, "Dead Hang Thru Advanced Front Back Lever Press To Reverse Hang" },
                    { 904, 9, false, "Advanced Tuck Front Lever Press To Reverse Hang" },
                    { 912, 9, false, "Dead Hang Thru Full Front Lever Press To Reverse Hang Eccentric" },
                    { 1003, 10, false, "Advanced Tuck Front Lever Pull Ups" },
                    { 604, 6, false, "Straddle Back Lever Press To Reverse Hang" },
                    { 602, 6, false, "Advanced Tuck Back Lever Press To Reverse Hang" },
                    { 304, 3, false, "Bend Arm Pike Press To Handstand" },
                    { 303, 3, false, "Straigth Arm Straddle Press To Handstand" },
                    { 302, 3, false, "Bend Arm Straddle Press To Handstand" },
                    { 301, 3, false, "Straigth Arm Tuck Press To Handstand" },
                    { 300, 3, false, "Bend Arm Tuck Press To Handstand" },
                    { 207, 2, false, "Free Deep 90 Degree Handstand Push Ups" },
                    { 206, 2, false, "Free 90 Degree Handstand Push Ups" },
                    { 205, 2, false, "Free Wide Handstand Push Ups" },
                    { 305, 3, false, "Straigth Arm Pike Press To Handstand" },
                    { 204, 2, false, "Free Deep Handstand Push Ups" },
                    { 202, 2, false, "Wall Handstand Push Ups" },
                    { 201, 2, false, "Elevated Pike Push Ups" },
                    { 200, 2, false, "Pike Push Ups" },
                    { 105, 1, true, "Hollow Back" },
                    { 104, 1, true, "Free One Arm Handstand" },
                    { 103, 1, true, "Wall One Arm Handstand" },
                    { 102, 1, true, "Handstand On Rings" },
                    { 101, 1, true, "Free Handstand" },
                    { 203, 2, false, "Free Handstand Push Ups" },
                    { 603, 6, false, "German Hang Thru Advanced Tuck Back Lever Press To Reverse Hang" },
                    { 306, 3, false, "Bend Arm L-sit To Handstand" },
                    { 400, 4, true, "Tuck L-sit" },
                    { 601, 6, false, "German Hang Thru Tuck Back Lever Press To Reverse Hang" },
                    { 600, 6, false, "Tuck Back Lever Press To Reverse Hang" },
                    { 507, 5, true, "One Arm Back Lever" },
                    { 506, 5, true, "Wide Full Back Lever" },
                    { 505, 5, true, "Full Back Lever" },
                    { 504, 5, true, "Half Lay Back Lever" },
                    { 503, 5, true, "Straddle Back Lever" },
                    { 502, 5, true, "Advanced Tuck Back Lever" },
                    { 307, 3, false, "Straigth Arm L-sit To Handstand" },
                    { 501, 5, true, "Tuck Back Lever" },
                    { 408, 4, true, "Manna" },
                    { 407, 4, true, "45 Degree V-Sit/Manna" },
                    { 406, 4, true, "Rings V-Sit" },
                    { 405, 4, true, "V-Sit" },
                    { 404, 4, true, "Rings Straddle L-sit" },
                    { 403, 4, true, "Rings L-sit" },
                    { 402, 4, true, "Straddle L-sit" },
                    { 401, 4, true, "L-sit" },
                    { 500, 5, true, "German Hang" },
                    { 2502, 25, false, "Straddle Dragon Flag Press Eccentric" },
                    { 1004, 10, false, "Straddle Front Lever False Grip Pull Ups" },
                    { 1006, 10, false, "Half Lay Front Lever False Grip Pull Ups" },
                    { 2007, 20, false, "One Arm Push Ups" },
                    { 2006, 20, false, "One Arm Push Ups Eccentric" },
                    { 2005, 20, false, "Archer Push Ups" },
                    { 2004, 20, false, "Diamond Push Ups" },
                    { 2003, 20, false, "Regular Push Ups" },
                    { 2002, 20, false, "Regular Push Ups Eccentric" },
                    { 2001, 20, false, "Knee Push Ups" },
                    { 2000, 20, false, "Knee Push Ups Eccentric" },
                    { 2100, 21, true, "Dead Hang" },
                    { 1902, 19, false, "Pistol Squat" },
                    { 1900, 19, false, "Squat" },
                    { 1803, 18, false, "Terrorist Pull Ups" },
                    { 1802, 18, false, "High Pull Ups To Thigs" },
                    { 1801, 18, false, "High Pull Ups To Stomach" },
                    { 1800, 18, false, "High Pull Ups To Chest" },
                    { 1709, 17, false, "Entrade De Diablo" },
                    { 1708, 17, false, "Entrade De Diablo Eccentrinc" },
                    { 1707, 17, false, "Entrade De Angelo" },
                    { 1901, 19, false, "Pistol Squat Eccentric" },
                    { 1706, 17, false, "Entrade De Angelo Eccentrinc" },
                    { 2101, 21, true, "One Arm Dead Hang" },
                    { 2300, 23, true, "Paraller Bars L Victorian Cross (Arms On Bars)" },
                    { 2500, 25, false, "Advanced Tuck Dragon Flag Press Eccentric" },
                    { 2404, 24, true, "One Arm Dragon Flag" },
                    { 2403, 24, true, "Full Dragon Flag" },
                    { 2402, 24, true, "Straddle Dragon Flag" },
                    { 2401, 24, true, "Advanced Tuck Dragon Flag" },
                    { 2400, 24, true, "L Dragon Flag" },
                    { 2312, 23, true, "Paraller Bars L Victorian Cross" },
                    { 2311, 23, true, "Rings Victorian Cross" },
                    { 2200, 22, true, "Reverse Hang" },
                    { 2310, 23, true, "Rings Snake Grip Victorian Cross" },
                    { 2308, 23, true, "Paraller Bars Half Lay Victorian Cross (Only Hands On Bars)" },
                    { 2307, 23, true, "Paraller Bars Super Advanced Tuck Victorian Cross (Only Hands On Bars)" },
                    { 2306, 23, true, "Paraller Bars Advanced Tuck Victorian Cross (Only Hands On Bars)" },
                    { 2305, 23, true, "Paraller Bars L Victorian Cross (Only Hands On Bars)" },
                    { 2304, 23, true, "Paraller Bars Full Victorian Cross (Arms On Bars)" },
                    { 2303, 23, true, "Paraller Bars Half Lay Victorian Cross (Arms On Bars)" },
                    { 2302, 23, true, "Paraller Bars Super Advanced Tuck Victorian Cross (Arms On Bars)" },
                    { 2301, 23, true, "Paraller Bars Advanced Tuck Victorian Cross (Arms On Bars)" },
                    { 2309, 23, true, "Paraller Bars Full Victorian Cross (Only Hands On Bars)" },
                    { 1005, 10, false, "Straddle Front Lever Pull Ups" },
                    { 1705, 17, false, "Back Lever Hefesto" },
                    { 1703, 17, false, "Hefesto" },
                    { 1300, 13, true, "Support Hold" },
                    { 1206, 12, false, "One Arm Pull Ups" },
                    { 1205, 12, false, "One Arm Pull Ups Eccentrinc" },
                    { 1204, 12, false, "Archer Pull Ups" },
                    { 1203, 12, false, "Wide Pull Ups" },
                    { 1202, 12, false, "Wide Pull Up Eccentrinc" },
                    { 1201, 12, false, "Regular Pull Ups" },
                    { 1200, 12, false, "Regular Pull Ups Eccentrinc" },
                    { 1400, 14, false, "Swedish Dips Eccentrinc" },
                    { 1104, 11, false, "One Arm Australian Pull Ups" },
                    { 1102, 11, false, "Wide Australian Pull Ups" },
                    { 1101, 11, false, "Australian Pull Ups" },
                    { 1100, 11, false, "Australian Pull Ups Eccentric" },
                    { 1011, 10, false, "Wide Front Lever Pull Ups" },
                    { 1010, 10, false, "Wide Front Lever False Grip Pull Ups" },
                    { 1009, 10, false, "Full Front Lever Pull Ups" },
                    { 1008, 10, false, "Full Front Lever False Grip Pull Ups" },
                    { 1007, 10, false, "Half Lay Front Lever Pull Ups" },
                    { 1103, 11, false, "Archer Australian Pull Ups" },
                    { 1704, 17, false, "Back Lever Hefesto Eccentrinc" },
                    { 1401, 14, false, "Swedish Dips" },
                    { 1403, 14, false, "Regular Dips" },
                    { 1702, 17, false, "Hefesto Eccentrinc" },
                    { 1701, 17, false, "Reverse Australian Pull Ups" },
                    { 1700, 17, false, "Reverse Australian Pull Ups Eccentrinc" },
                    { 1603, 16, false, "One Arm Muscle Ups" },
                    { 1602, 16, false, "Rings Muscle Ups" },
                    { 1601, 16, false, "Muscle Ups" },
                    { 1600, 16, false, "Muscle Ups Eccentrinc" },
                    { 1504, 15, true, "Full Human Flag" },
                    { 1402, 14, false, "Regular Dips Eccentrinc" },
                    { 1503, 15, true, "Straddle Human Flag" },
                    { 1501, 15, true, "Human Flag Reverse Hang" },
                    { 1500, 15, true, "Human Flag Hang" },
                    { 1409, 14, false, "Bulgarian Dips Eccentrinc" },
                    { 1408, 14, false, "Ring Dips" },
                    { 1407, 14, false, "Korean Dips" },
                    { 1406, 14, false, "Korean Dips Eccentrinc" },
                    { 1405, 14, false, "Single Bar Dips" },
                    { 1404, 14, false, "Single Bar Dips Eccentrinc" },
                    { 1502, 15, true, "Advanced Tuck Human Flag" },
                    { 6802, 68, true, "Box Revrse Leg Raises (Only Chest on Box) Hold" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_GroupId",
                schema: "Workout",
                table: "Exercise",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseExecution_ExerciseId",
                schema: "Workout",
                table: "ExerciseExecution",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseExecution_WorkoutVersionId",
                schema: "Workout",
                table: "ExerciseExecution",
                column: "WorkoutVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseExecution_Order_Workout_Exercise",
                schema: "Workout",
                table: "ExerciseExecution",
                columns: new[] { "Order", "WorkoutVersionId", "ExerciseId" });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseExecutionPlan_ExerciseId",
                schema: "Workout",
                table: "ExerciseExecutionPlan",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseExecutionPlan_WorkoutPlanVersionId",
                schema: "Workout",
                table: "ExerciseExecutionPlan",
                column: "WorkoutPlanVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseExecutionPlan_Order_WorkoutPlanId_ExerciseId",
                schema: "Workout",
                table: "ExerciseExecutionPlan",
                columns: new[] { "Order", "WorkoutPlanVersionId", "ExerciseId" });

            migrationBuilder.CreateIndex(
                name: "IX_Workout_Created",
                schema: "Workout",
                table: "Workout",
                column: "Created");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_UserId",
                schema: "Workout",
                table: "Workout",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_UserId_DeactivationDate_Name",
                schema: "Workout",
                table: "Workout",
                columns: new[] { "UserId", "DeactivationDate", "Name" },
                unique: true,
                filter: "[DeactivationDate] IS NOT NULL AND [Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlans_UserId",
                schema: "Workout",
                table: "WorkoutPlan",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlan_UserId_DeactivationDate_Name",
                schema: "Workout",
                table: "WorkoutPlan",
                columns: new[] { "UserId", "DeactivationDate", "Name" },
                unique: true,
                filter: "[DeactivationDate] IS NOT NULL AND [Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlanVersion_WorkoutPlanId_Created",
                schema: "Workout",
                table: "WorkoutPlanVersion",
                columns: new[] { "WorkoutPlanId", "Created" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutVersion_FatigueLevelId",
                schema: "Workout",
                table: "WorkoutVersion",
                column: "FatigueLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutVersion_MoodLevelId",
                schema: "Workout",
                table: "WorkoutVersion",
                column: "MoodLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutVersion_WorkoutId",
                schema: "Workout",
                table: "WorkoutVersion",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutVersion_WorkoutId_Created",
                schema: "Workout",
                table: "WorkoutVersion",
                columns: new[] { "WorkoutId", "Created" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseExecution",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "ExerciseExecutionPlan",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "WorkoutVersion",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "Exercise",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "WorkoutPlanVersion",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "FatihueLevel",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "MoodLevel",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "Workout",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "GroupOfExercise",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "WorkoutPlan",
                schema: "Workout");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Security");
        }
    }
}
