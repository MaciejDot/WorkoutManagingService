using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Data.Enums;
using WorkoutManagingService.Domain.DTO;

namespace WorkoutManagingService.Domain.Command
{
    public class UpdateWorkoutCommand : IRequest<Unit>
    {
        public string UserId { get; set; }
        public string WorkoutName { get; set; }
        public DateTime ExecutionTime { get; set; }
        public MoodLevelEnum MoodLevel { get; set; }
        public FatigueLevelEnum FatigueLevel { get; set; }
        public IEnumerable<ExerciseExecutionDTO> ExerciseExecutions { get; set; }
    }
}
