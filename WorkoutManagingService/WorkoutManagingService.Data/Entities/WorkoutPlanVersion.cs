using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutManagingService.Data.Entities
{
    public class WorkoutPlanVersion
    {
        public int Id { get; set; }
        public string WorkoutPlanId { get; set; }
        public WorkoutPlan WorkoutPlan { get; set; }
        public DateTime Created { get; set; }

        public ICollection<ExerciseExecutionPlan> ExerciseExecutionPlans { get; set; }
    }
}
