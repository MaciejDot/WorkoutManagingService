using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManagingService.Domain.Models;

namespace WorkoutManagingService.Domain.Command
{
    public class UpdateWorkoutPlanCommand : IRequest<Unit>
    {
        public string WorkoutName { get; set; }
        public string UserId { get; set; }
        public IEnumerable<ExercisePlanModel> Exercises { get; set; }
    }
}
