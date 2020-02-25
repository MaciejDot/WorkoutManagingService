using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Executed { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public FatigueLevel FatigueLevel { get; set; }
        public int FatigueLevelId { get; set; }
        public MoodLevel MoodLevel { get; set; }
        public int MoodLevelId { get; set; }
        public ICollection<ExerciseExecution> ExerciseExecutions { get; set; }
    }
}
