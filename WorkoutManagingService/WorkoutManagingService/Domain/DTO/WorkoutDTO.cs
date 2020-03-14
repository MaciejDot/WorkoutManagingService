using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManagingService.Domain.DTO
{
    public class WorkoutDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Mood { get; set; }
        public DateTime DateOfWorkout { get; set; }
        public int Fatigue { get; set; }
        public IEnumerable<SendExerciseExecutionDTO> Exercises { get; set; }
    }
}
