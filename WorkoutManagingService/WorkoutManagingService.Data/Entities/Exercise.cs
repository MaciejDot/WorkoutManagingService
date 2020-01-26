using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsHold { get; set; }
        public ICollection<ExerciseExecution> ExerciseExecutions { get; set; }
    }
}
