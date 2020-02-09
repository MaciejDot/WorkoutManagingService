using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class ExerciseExecution
    {
        public int Id { get; set; }
        public Exercise Exercise { get; set; }
        public int ExerciseId { get; set; }
        public int Order { get; set; }
        public Workout Workout { get; set; }
        public int Repetitions { get; set; }
        public int AdditionalKgs { get; set; }
        public int Break { get; set; }
        public int WorkoutId { get; set; }
        public string Description { get; set; }
    }
}
