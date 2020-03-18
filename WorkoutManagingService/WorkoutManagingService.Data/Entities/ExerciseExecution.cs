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
        public WorkoutVersion WorkoutVersion { get; set; }
        public int Repetitions { get; set; }
        public int AdditionalKgs { get; set; }
        public int Break { get; set; }
        public int Series { get; set; }
        public int WorkoutVersionId { get; set; }
        public string Description { get; set; }
    }
}
