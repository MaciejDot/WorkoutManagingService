using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Data.Enums;
using WorkoutManagingService.Domain.DTO;

namespace WorkoutManagingService.Models
{
    public class WorkoutModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Mood { get; set; }
        public DateTime DateOfWorkout { get; set; }
        public int Fatigue { get; set; }
        public IEnumerable<ExerciseExecutionDTO> Exercises { get; set; }
    }
}
