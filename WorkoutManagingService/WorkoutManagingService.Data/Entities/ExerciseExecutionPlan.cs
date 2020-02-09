using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class ExerciseExecutionPlan
    {
        public int Id { get; set; }
        public int WorkoutPlanId { get; set; }
        public WorkoutPlan WorkoutPlan { get; set; }
        public int Series { get; set; }
        public int MinReps { get; set; }
        public int MaxReps { get; set; }
        public int MinAdditionalKgs { get; set; }
        public int MaxAdditionalKgs { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int Order { get; set; }
        public string Description { get; set;}
        public int Break { get; set; }
    }
}
