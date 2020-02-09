using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Domain.Models;

namespace WorkoutManagingService.Models
{
    public class WorkoutPlanModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ExercisePlanModel> Exercises { get; set; }
    }
}
