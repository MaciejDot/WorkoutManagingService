using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class WorkoutVersion
    {
        public int Id { get; set; }
        public string WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public DateTime Created { get; set; }
        public DateTime Executed { get; set; }
        public FatigueLevel FatigueLevel { get; set; }
        public int FatigueLevelId { get; set; }
        public MoodLevel MoodLevel { get; set; }
        public int MoodLevelId { get; set; }
        public ICollection<ExerciseExecution> ExerciseExecutions { get; set; }
    }
}
