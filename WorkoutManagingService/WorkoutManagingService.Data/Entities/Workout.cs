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
        public ICollection<ExerciseExecution> ExerciseExecutions { get; set; }
    }
}
