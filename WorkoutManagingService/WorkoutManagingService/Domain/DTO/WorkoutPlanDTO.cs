using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Domain.Models;

namespace WorkoutManagingService.Domain.DTO
{
    public class WorkoutPlanDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<ExercisePlanViewModel> Exercises { get; set; }
    }
}
